using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstructNedir
{
   public abstract class temekSinif        
    {
        public DateTime kayitTarih { get; set; }
        public DateTime guncellemeTarih { get; set; }

        public temekSinif()
        {
            kayitTarih = DateTime.Now;
            guncellemeTarih = DateTime.Now;
        }

        public void test()
        {
            Console.WriteLine("temel sınıf => test");
        }

        public abstract void testAbstract();//metot imzası (metotdaki gibi çengelli parantez içine tanımlar yapılmaz!)


    }
}
