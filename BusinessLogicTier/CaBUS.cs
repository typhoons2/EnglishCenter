    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DataAccessTier;
    using DTO;

    namespace BusinessLogicTier
    {
        public class CaBUS
        {
            CaDAO mCaDAO;

            public CaBUS()
            {
                mCaDAO = new CaDAO();
            }

            public List<Ca> getAllCa()
            {
                return mCaDAO.getAllCa();
            }

            public Ca selectCa(String maCa)
            {
                return mCaDAO.selectCa(maCa);
            }
        }
    }

/*
Đây là mã nguồn của một lớp CaBUS trong tầng Business Logic Tier của một ứng dụng. Lớp này được sử dụng để thực hiện 
các tác vụ liên quan đến đối tượng Ca.

    Cụ thể, lớp CaBUS có các phương thức sau:

    Phương thức khởi tạo không tham số: Tạo một đối tượng CaDAO để sử dụng trong các phương thức khác.

    Phương thức getAllCa(): Trả về một danh sách các đối tượng Ca từ cơ sở dữ liệu thông qua đối tượng CaDAO.

Phương thức selectCa(String maCa): Trả về một đối tượng Ca cụ thể với mã Ca tương ứng được truyền vào thông qua đối 
tượng CaDAO.

Các phương thức này đều gọi đến các phương thức tương ứng của đối tượng CaDAO để thực hiện các thao tác truy vấn và 
trả về kết quả. Lớp CaBUS này sẽ được sử dụng trong tầng Presentation Tier để hiển thị dữ liệu và thực hiện các chức 
năng của ứng dụng liên quan đến đối tượng Ca.*/