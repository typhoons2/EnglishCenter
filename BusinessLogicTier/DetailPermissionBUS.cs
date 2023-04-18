using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;

namespace BusinessLogicTier
{
    public class DetailPermissionBUS
    {
        public List<String> getListTabByPermission(String permission)
        {
            return new DetailPermissionDAO().getListTabByPermission(permission);
        }
    }
}


/*
Đây là mã C# cho một lớp được gọi là DetailPermissionBUS, đại diện cho lớp logic của một ứng dụng. Lớp này chỉ chứa một 
phương thức là getListTabByPermission, để lấy danh sách các tab bằng cách sử dụng đối tượng DetailPermissionDAO, dựa trên 
một quyền được cấp cho người dùng.

Cụ thể, phương thức getListTabByPermission(String permission) sẽ trả về danh sách các tab được phép truy cập bởi người 
dùng với quyền được cấp, được lấy từ đối tượng DetailPermissionDAO. Tham số đầu vào của phương thức là permission, đại 
diện cho quyền được cấp.

Đối tượng DetailPermissionBUS không có hàm tạo (constructor) nào được định nghĩa trong mã, và có namespace là 
BusinessLogicTier.
*/