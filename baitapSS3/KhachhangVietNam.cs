using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M.Session3.baitapSS3
{
    public class KhachhangVietNam : Khachhang
    {
        public override double calculateMoney()
        {
            double calculate = 0;
            if(this.Sl < 50)
            {
                calculate = (this.Sl * 1000);
            }
            else if(this.Sl >= 50 && this.Sl < 100)
            {
                calculate = (this.Sl - 50) * 1200 + (50 * 1000);
            }
            else if(this.Sl >= 100 && this.Sl < 200)
            {
                calculate = (this.Sl - 100) * 1500 + (50 * 1000) + (50 * 1200);
            }
            else
            {
                calculate = (this.Sl - 200) * 2000 + (50 * 1000) + (50 * 1200) + (100 * 1500);
            }
            return calculate;

        }
        public KhachhangVietNam(int khachhangId, string khachhangName, string date, string dt, double sl) : base(khachhangId, khachhangName, date, dt, sl) { }
    }


}
