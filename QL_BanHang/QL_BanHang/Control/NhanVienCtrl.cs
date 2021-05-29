using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QL_BanHang.Model;
using QL_BanHang.Object;


namespace QL_BanHang.Control
{
    class NhanVienCtrl
    {
        NhanVienMod nvMod = new NhanVienMod();
        public DataTable getData()
        {
            return nvMod.GetData();
        }

        public bool addData(NhanVienObj nvObj)
        {
            return nvMod.AddData(nvObj);
        }

        public bool upData(NhanVienObj nvObj)
        {
            return nvMod.UpdData(nvObj);
        }

        public bool delData(string ma)
        {
            return nvMod.DelData(ma);
        }
    }
}
