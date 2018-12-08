using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razredi_valjak_kugla
{
    class Program
    {
        static void Main(string[] args)
        {
            Valjak v1 = new Valjak((float)2.36,(float)3.6);
            Valjak v2 = new Valjak((float)7.25,(float)1.5);
            Valjak v3 = new Valjak((float)6.295,(float)1.33);

            List<Valjak> valjaks = new List<Valjak>();

            valjaks.Add(v1);
            valjaks.Add(v2);
            valjaks.Add(v3);

            foreach (Valjak v in valjaks)
            {
                v.Ispis();
                Console.WriteLine("Ukupna povrsina:{0}", v.UkupnaPovrsina());
            }

            valjaks.Sort();

            foreach (Valjak v in valjaks)
            {
                v.Ispis();
                Console.WriteLine("Ukupna povrsina:{0}", v.UkupnaPovrsina());
            }
        }
    }
}
