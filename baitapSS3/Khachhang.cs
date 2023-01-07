using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M.Session3.baitapSS3
{
    public abstract class Khachhang
    {
        private int khachhangId;
        private string khachhangName;
        private string date;
        private string dt;
        private double sl;

        public int KhachhangId { get => khachhangId; set=> khachhangId = value; }
        public string KhachhangName { get => khachhangName; set=> khachhangName = value; }
        public string Date {  get => date; set => date = value; }
        public string Dt { get=> dt; set => dt = value; }
        public double Sl { get=> sl; set => sl = value; }

        public Khachhang(int khachhangId, string khachhangName, string date, string dt, double sl)
        {
            this.khachhangId = khachhangId;
            this.khachhangName = khachhangName;
            this.date = date;
            this.dt = dt;
            this.sl = sl;
        }

        public abstract double calculateMoney();

        
        
    }
}
