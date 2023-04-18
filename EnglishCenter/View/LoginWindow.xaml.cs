﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BusinessLogicTier;
using DTO;
using System.Collections;

namespace EnglishCenter.View
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        ///  biến kiểu MainWindow, được khai báo để sử dụng ở đoạn code phía sau.
        public MainWindow mainWindow;
        // Một đối tượng kiểu UserBUS, được khởi tạo bằng hàm tạo của lớp UserBUS.
        private UserBUS mUserBus;
        //Đây là hàm tạo của lớp LoginWindow, được gọi khi một đối tượng LoginWindow được khởi tạo. Hàm này sử dụng đối tượng UserBUS để kiểm tra kết nối đến
        //database thông qua hàm checkConnection().
        public LoginWindow()
        {            
            
            mUserBus = new UserBUS();             
            checkConnection();                         
        }

        //Kiểm tra kết nối đến database
        private void checkConnection()
        {
            if (!mUserBus.isConnectionOpen())
            {
                //Nếu có lỗi xảy ra thì hiện cửa sổ thông báo
                LoginError error = new LoginError();
                error.Show();
                this.Close();
            }
            else
            {
                //Hiển cửa sổ làm việc chính
                mainWindow = new MainWindow();
                InitializeComponent();
                tbUsername.Focus();
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
            //this.Close();
        }

        public static List<T> GetLogicalChildCollection<T>(object parent) where T : DependencyObject
        {
            List<T> logicalCollection = new List<T>();
            GetLogicalChildCollection(parent as DependencyObject, logicalCollection);
            return logicalCollection;
        }

        private static void GetLogicalChildCollection<T>(DependencyObject parent, List<T> logicalCollection) where T : DependencyObject
        {
            IEnumerable children = LogicalTreeHelper.GetChildren(parent);
            foreach (object child in children)
            {
                if (child is DependencyObject)
                {
                    DependencyObject depChild = child as DependencyObject;
                    if (child is T)
                    {
                        logicalCollection.Add(child as T);
                    }
                    GetLogicalChildCollection(depChild, logicalCollection);
                }
            }
        }

        //Kiểm tra user, chỉ hiện những control được phép truy cập
        private void login_Click(object sender, RoutedEventArgs e)
        {
            if (tbUsername.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không đúng.");
                return;
            }
            if (tbPass.Password == "")
            {
                MessageBox.Show("Mật khẩu không đúng.");
                return;
            }
            User user = new User(tbUsername.Text, tbPass.Password, "");
            if (mUserBus.checkUser(user))
            {
                //lay permission theo user
                //lấy quyền hạn của người dùng thông qua một đối tượng mUserBus và lưu vào biến permission.
                String permission = mUserBus.getPermissionByUser(user);
                //lấy quyền hạn của người dùng thông qua một đối tượng mUserBus và lưu vào biến permission.
                //Dòng thứ ba lấy danh sách các tên tab phù hợp với quyền hạn của người dùng từ một đối tượng
                //DetailPermissionBUS.
                user.MPermission = permission;
                //lay danh sach tab theo permission
                List<String> listNameTab = new DetailPermissionBUS().getListTabByPermission(permission);
                List<Button> listBtn = GetLogicalChildCollection<Button>(mainWindow);
                List<TabItem> listTab = GetLogicalChildCollection<TabItem>(mainWindow);
                for (int i = 0; i < listNameTab.Count; i++)
                {
                    Button btn = listBtn.Find(m => m.Name == listNameTab[i]);
                    if (btn != null)
                    {
                        btn.Visibility = Visibility.Hidden;
                    }
                    TabItem tab = listTab.Find(m => m.Name == listNameTab[i]);
                    if (tab != null)
                    {
                        tab.Visibility = Visibility.Collapsed;
                    }
                }
                User u = mUserBus.selectUserByUsername(tbUsername.Text);
                mainWindow.User = u;
                mainWindow.Show();
                this.Close();
            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            
        }

        //Ấn Enter thay vì click button Đăng nhập
        private void tb_username_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                loginButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                e.Handled = true;
            }
        }

        private void tbUsername_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbUsername_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
