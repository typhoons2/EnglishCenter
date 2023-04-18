using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataAccessTier;

namespace BusinessLogicTier
{
    public class ChiTietThiXepLopBUS
    {
        public ChiTietThiXepLopBUS()
        { }

        public List<ChiTietThiXepLop> getAllChiTietTXL()
        {
            return new ChiTietThiXepLopDAO().getAllChiTietTXL();
        }

        public bool updateKetQuaThi(List<ChiTietThiXepLop> ds)
        {
            return new ChiTietThiXepLopDAO().updateKetQuaThi(ds);
        }

        public List<ChiTietThiXepLop> getChiTietTXLByMaTXL(String maTXL)
        {
            return new ChiTietThiXepLopDAO().getChiTietTXLByMaTXL(maTXL);
        }
        public bool addHocVien(HocVien hv, ThiXepLop txl)
        {
            return new ChiTietThiXepLopDAO().addHocVien(hv, txl);
        }

        public bool insertChiTietThiXepLop(ChiTietThiXepLop txl)
        {
            return new ChiTietThiXepLopDAO().insertChiTietThiXepLop(txl);
        }

        public String getMaCTHocDeNghi(String maTXL, String maHV)
        {
            return new ChiTietThiXepLopDAO().getMaCTHocDeNghi(maTXL, maHV);
        }
    }
}


/*
 Đoạn code trên là một lớp ChiTietThiXepLopBUS thuộc tầng Business Logic Tier (BLL) trong kiến trúc 3 tầng. Lớp này 
chứa các phương thức để thao tác dữ liệu của lớp ChiTietThiXepLop (được định nghĩa trong DTO) thông qua lớp 
ChiTietThiXepLopDAO (được định nghĩa trong DataAccessTier).

Các phương thức trong lớp ChiTietThiXepLopBUS bao gồm:

    getAllChiTietTXL(): trả về danh sách tất cả các chi tiết thi xếp lớp.
    
    updateKetQuaThi(List<ChiTietThiXepLop> ds): cập nhật kết quả thi cho danh sách chi tiết thi xếp lớp được truyền vào
    
    getChiTietTXLByMaTXL(String maTXL): trả về danh sách chi tiết thi xếp lớp theo mã thi xếp lớp được truyền vào.  
    
    addHocVien(HocVien hv, ThiXepLop txl): thêm học viên vào danh sách thi xếp lớp được truyền vào.
    
    insertChiTietThiXepLop(ChiTietThiXepLop txl): thêm chi tiết thi xếp lớp mới vào cơ sở dữ liệu.

    getMaCTHocDeNghi(String maTXL, String maHV): trả về mã chi tiết học đề nghị của học viên được truyền vào trong 
   thi xếp lớp.
 
 */
