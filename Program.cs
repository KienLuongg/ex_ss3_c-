using T2204M.Session3;
using T2204M.Session3.baitapSS3;
using System;
    public class Program 
    {
        public static void Main(string[] args)
    {
        KhachhangNuocNgoai nn = new KhachhangNuocNgoai(2, "Kien", "02/01/2001", "sinh hoat", 155);
        Console.WriteLine(nn.calculateMoney());
        KhachhangVietNam vn = new KhachhangVietNam(3, "Kien", "02/01/2001", "doi", 200);
        Console.WriteLine(vn.calculateMoney());
    }
        public static void Main2(string[] args)
        {
            Car c = new Car() { Brand = "Toyota", Type = "Sedan" };
            Console.WriteLine(c.machines[0]);
            Console.WriteLine(c[1]);
            c.machines.Add("Led");
            try 
            {
                int x = 10;
                int y = 0;
                Console.WriteLine("x/y = ");
                int z = x / y;
                Console.WriteLine("z");
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
    
