using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstructNedir
{
    public class Musteri : temekSinif
    {

        public int musteriID { get; set; }

        public Musteri()
        {
            musteriID = 1;
        }
        public override void testAbstract()
        {
            Console.WriteLine("musteri => testAbstruct");
        }
    }
}
