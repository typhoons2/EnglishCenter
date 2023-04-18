using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataAccessTier;

namespace BusinessLogicTier
{
    public class GiangVienBUS
    {
        GiangVienDAO mGiangVienDAO;

        public GiangVienBUS()
        {
            mGiangVienDAO = new GiangVienDAO();
        }

        public List<GiangVien> getListGiangVien()
        {
            return mGiangVienDAO.getListGiangVien();
        }

        public bool insertGiangVien(GiangVien gv)
        {
            int maxIdGV = this.getMaGiangVienMax();
            if (maxIdGV <= 0)
            {
                return false;
            }
            gv.MMaGiangVien = (maxIdGV + 1).ToString();
            return mGiangVienDAO.insertGiangVien(gv);
        }

        public bool deleteGiangVien(String maGV)
        {
            return mGiangVienDAO.deleteGiangVien(maGV);
        }

        public int getMaGiangVienMax()
        {
            int result = 0;
            try
            {
                int.TryParse(mGiangVienDAO.getMaxIdGiangVien(), out result);
            }
            catch (Exception)
            {
                //throw;
            }
            return result;
        }

        public GiangVien selectGiangVien(String maGV)
        {
            return mGiangVienDAO.selectGiangVien(maGV);
        }

        public bool updateGiangVien(GiangVien gv)
        {
            return mGiangVienDAO.updateGiangVien(gv);
        }
    }
}

/*
Đây là class GiangVienBUS trong một ứng dụng quản lý giảng viên. Class này được sử dụng để thực hiện các chức năng liên quan đến việc quản lý thông tin giảng viên.

Trong class này, có các thuộc tính và phương thức như sau:

Thuộc tính:

mGiangVienDAO: là một đối tượng kiểu GiangVienDAO, được sử dụng để thao tác với cơ sở dữ liệu.
Phương thức:

getListGiangVien(): phương thức này được sử dụng để lấy danh sách tất cả các giảng viên.
insertGiangVien(GiangVien gv): phương thức này được sử dụng để thêm một giảng viên mới vào cơ sở dữ liệu. Trong đó, tham số gv là đối tượng kiểu GiangVien chứa thông tin về giảng viên mới.
deleteGiangVien(String maGV): phương thức này được sử dụng để xóa một giảng viên khỏi cơ sở dữ liệu. Tham số maGV là mã giảng viên cần xóa.
getMaGiangVienMax(): phương thức này được sử dụng để lấy mã giảng viên lớn nhất trong cơ sở dữ liệu.
selectGiangVien(String maGV): phương thức này được sử dụng để lấy thông tin của một giảng viên dựa trên mã giảng viên.
updateGiangVien(GiangVien gv): phương thức này được sử dụng để cập nhật thông tin của một giảng viên trong cơ sở dữ liệu. Tham số gv là đối tượng kiểu GiangVien chứa thông tin về giảng viên cần cập nhật.
*/