using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace DAO_BLL
{
    public class HinhThucDAO
    {
        #region Properties

        DataQLKhachSanDataContext dataContext = new DataQLKhachSanDataContext();

        #endregion

        #region Methods

        public List<HinhThucBO> GetAllDataHinhThuc()
        {
            var lstResult = from objHT in dataContext.tbl_HinhThucs
                            select new HinhThucBO()
                            {
                                MaHinhThuc = objHT.MaHinhThuc,
                                TenHinhThuc = objHT.TenHinhThuc
                            };
            return lstResult.OrderByDescending(x => x.MaHinhThuc).ToList();
        }

        #endregion
    }
}
