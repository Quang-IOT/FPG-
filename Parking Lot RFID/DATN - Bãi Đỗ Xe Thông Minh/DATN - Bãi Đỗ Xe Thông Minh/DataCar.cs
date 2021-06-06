using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN___Bãi_Đỗ_Xe_Thông_Minh
{
    class DataCar
    {
        public string str_BienSoXe { get; set; }
        public string str_LoaiXe { get; set; }
        public string str_MauXe { get; set; }
        public string str_LoaiVe { get; set; }
        public DateTime dt_GioVao { get; set; }
        public int int_TienThu { get; set; }
        public string int_trangThai { get; set; }
        public string str_maRFID { get; set; }

        private static string error = "Username does not exist!";

        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }

        public static bool IsEqual(DataCar Car1, DataCar Car2)
        {
            if (Car1 == null || Car2 == null) { return false; }

            if (Car1.str_BienSoXe != Car2.str_BienSoXe)
            {
                error = "Username does not exist!";
                return false;
            }

            return true;
        }
    }
}
