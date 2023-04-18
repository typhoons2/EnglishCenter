using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataAccessTier;

namespace BusinessLogicTier
{
    public class DeThiBUS
    {
        DeThiDAO mDeThiDAO;

        public DeThiBUS() {
            mDeThiDAO = new DeThiDAO();
        }

        public List<DeThi> getListDeThi()
        {
            return new DeThiDAO().getListDeThi();
        }

        public int getIndex()
        {
            List<DeThi> ds = mDeThiDAO.getListDeThi();
            if (ds.Count > 0)
            {
                return ds.Select(m => int.Parse(m.MMaDeThi)).Max() + 1;
            }
            return 1;
        }

        public bool themDeThi(DeThi dth)
        {
            dth.MMaDeThi = getIndex().ToString();
            return new DeThiDAO().themDeThi(dth);
        }

        public bool xoaDeThi(String ma)
        {
            return new DeThiDAO().xoaDeThi(ma);
        }

        public bool suaDeThi(DeThi dethi)
        {
            return new DeThiDAO().suaDeThi(dethi);
        }
    }
}

/*
Đây là mã C# cho một lớp được gọi là DeThiBUS, đại diện cho lớp logic của một ứng dụng. Lớp này chứa các phương thức để thao tác với dữ liệu bài thi trong ứng dụng, sử dụng đối tượng DeThiDAO.

Cụ thể, lớp DeThiBUS có các phương thức sau:

Phương thức getListDeThi(): Lấy danh sách bài thi từ đối tượng DeThiDAO.
Phương thức getIndex(): Lấy chỉ mục của bài thi tiếp theo để thêm mới. Nếu danh sách rỗng, chỉ mục sẽ là 1. Ngược lại, chỉ mục sẽ được lấy bằng cách tìm giá trị lớn nhất của MaDeThi trong danh sách bài thi, sau đó cộng thêm 1.
Phương thức themDeThi(DeThi dth): Thêm một bài thi mới vào danh sách bài thi thông qua đối tượng DeThiDAO. Phương thức cũng tự động thiết lập mã bài thi của bài thi mới bằng cách gọi getIndex().
Phương thức xoaDeThi(String ma): Xóa một bài thi khỏi danh sách bài thi thông qua đối tượng DeThiDAO, dựa trên mã bài thi được cung cấp.
Phương thức suaDeThi(DeThi dethi): Sửa thông tin một bài thi trong danh sách bài thi thông qua đối tượng DeThiDAO.
Đối tượng DeThiBUS không có hàm tạo (constructor) nào được định nghĩa trong mã, và có namespace là BusinessLogicTier.
*/