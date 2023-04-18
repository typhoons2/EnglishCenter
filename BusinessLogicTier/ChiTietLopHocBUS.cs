using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataAccessTier;

namespace BusinessLogicTier
{
    public class ChiTietLopHocBUS
    {
        public bool insertChiTietLopHoc(ChiTietLopHoc ct)
        {
            return new ChiTietLopHocDAO().insertChiTietLopHoc(ct);
        }

        public List<ChiTietLopHoc> selectChiTietLopHoc(String maLop)
        {
            return new ChiTietLopHocDAO().selectChiTietLopHoc(maLop);
        }

        public ChiTietLopHoc selectChiTietLopHocByMaHV(String maHV)
        {
            return new ChiTietLopHocDAO().selectChiTietLopHocByMaHV(maHV);
        }
    }
}

/*
 Code trên định nghĩa một lớp ChiTietLopHocBUS trong tầng Business Logic Tier của một ứng dụng. Lớp này có nhiệm vụ xử
lý các thao tác liên quan đến thông tin chi tiết của các lớp học.

Cụ thể, lớp ChiTietLopHocBUS cung cấp 3 phương thức:

    insertChiTietLopHoc: Phương thức này nhận đối tượng ChiTietLopHoc (được định nghĩa trong tầng DTO) và thêm thông 
   tin chi tiết của lớp học tương ứng vào cơ sở dữ liệu thông qua đối tượng ChiTietLopHocDAO ở tầng DataAccessTier. 
   Phương thức trả về giá trị boolean cho biết việc thêm thông tin chi tiết lớp học thành công hay không.

    selectChiTietLopHoc: Phương thức này nhận vào mã lớp và trả về danh sách các đối tượng ChiTietLopHoc tương ứng với
   mã lớp đó thông qua đối tượng ChiTietLopHocDAO.

    selectChiTietLopHocByMaHV: Phương thức này nhận vào mã học viên và trả về đối tượng ChiTietLopHoc tương ứng với mã
   học viên đó thông qua đối tượng ChiTietLopHocDAO.

Các phương thức của lớp ChiTietLopHocBUS thực hiện việc truy xuất cơ sở dữ liệu thông qua các đối tượng DAO ở tầng 
DataAccessTier và trả về kết quả cho các lớp ở tầng Presentation Tier sử dụng. */