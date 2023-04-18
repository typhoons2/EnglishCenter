using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataAccessTier;

namespace BusinessLogicTier
{
    public class ChuongTrinhHocBUS
    {
        ChuongTrinhHocDAO mChuongTrinhHocDAO;

        public ChuongTrinhHocBUS()
        {
            mChuongTrinhHocDAO = new ChuongTrinhHocDAO();
        }

        public List<ChuongTrinhHoc> getListChuongTrinhHoc()
        {
            return new ChuongTrinhHocDAO().getListChuongTrinhHoc();
        }

        public bool themChuongTrinhHoc(ChuongTrinhHoc cth)
        {
            ChuongTrinhHocDAO cthDao = new ChuongTrinhHocDAO();
            return cthDao.themChuongTrinhHoc(cth);
            
        }

        public bool xoaChuongTrinhHoc(String ma)
        {
            return new ChuongTrinhHocDAO().xoaChuongTrinhHoc(ma);
        }
        public bool suaChuongTrinhHoc(ChuongTrinhHoc cth)
        {
            ChuongTrinhHocDAO cthDao = new ChuongTrinhHocDAO();
            return cthDao.suaChuongTrinhHoc(cth);
        }

        public String getMaCTFromTenCT(String tenCT)
        {
            return mChuongTrinhHocDAO.getMaChuongTrinhHocFromTen(tenCT);
        }

        public String getTenChuongTrinhHocByMa(String maCTH)
        {
            return mChuongTrinhHocDAO.getTenChuongTrinhHocByMa(maCTH);
        }
    }
}
/*
 Đây là mã C# cho một lớp được gọi là ChuongTrinhHocBUS, đại diện cho lớp logic của một ứng dụng. Lớp này chứa các phương
thức để lấy danh sách chương trình học, thêm, xóa và sửa chương trình học. Ngoài ra, lớp này cũng có hai phương thức để 
lấy mã hoặc tên chương trình học bằng mã hoặc tên chương trình học.

Cụ thể, các phương thức trong lớp ChuongTrinhHocBUS bao gồm:

    Phương thức getListChuongTrinhHoc(): Lấy danh sách các chương trình học bằng cách sử dụng đối tượng 
ChuongTrinhHocDAO.

    Phương thức themChuongTrinhHoc(ChuongTrinhHoc cth): Thêm một chương trình học mới bằng cách sử dụng đối tượng 
ChuongTrinhHocDAO và trả về kết quả thành công hay thất bại.

    Phương thức xoaChuongTrinhHoc(String ma): Xóa một chương trình học bằng cách sử dụng đối tượng ChuongTrinhHocDAO và 
trả về kết quả thành công hay thất bại.

    Phương thức suaChuongTrinhHoc(ChuongTrinhHoc cth): Sửa đổi thông tin của một chương trình học bằng cách sử dụng đối tượng
ChuongTrinhHocDAO và trả về kết quả thành công hay thất bại.

    Phương thức getMaCTFromTenCT(String tenCT): Lấy mã chương trình học dựa trên tên chương trình học.
    
    Phương thức getTenChuongTrinhHocByMa(String maCTH): Lấy tên chương trình học dựa trên mã chương trình học.

Đối tượng mChuongTrinhHocDAO được khởi tạo trong hàm tạo (constructor) của lớp để sử dụng trong các phương thức của lớp.
 */