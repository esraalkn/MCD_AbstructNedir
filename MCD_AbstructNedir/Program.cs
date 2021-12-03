using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstructNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Abstruct ve Interface Kavramları
             * Kendimize işi yapacak bir rol model çıkartırız. Nasıl olacağının kurallarını hazırlar ve nesnelerimizde kurallarımızı kullanırız. 
             * Bu bölümde oluşturmuş olduğumuz nesnelerimizi nasıl kurallar ile şartlayabileceğimizi konuşacağız.
             * 
             */
            //temekSinif T1 = new temekSinif(); Abstruct Class new anahtar kelimesi ile bir örneği alınamaz.

            SuperMusteri SP1 = new SuperMusteri();
            SP1.testAbstract();

            Musteri M1 = new Musteri();
            M1.test();
            M1.testAbstract();
            Console.ReadKey();
        }
    }
}
