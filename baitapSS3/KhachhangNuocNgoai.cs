using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M.Session3.baitapSS3
{
    public class KhachhangNuocNgoai : Khachhang
    {
        public string qt;
        public KhachhangNuocNgoai(int khachhangId, string khachhangName, string date, string dt, double sl) : base(khachhangId, khachhangName, date, dt, sl)
        {
            this.qt = qt;
        }
        public string Qt { get => qt; set => qt = value; }

        public override double calculateMoney()
        {
            double calculate = 0;
            calculate = this.Sl * 2000;
            return calculate;
        }
    }
}
