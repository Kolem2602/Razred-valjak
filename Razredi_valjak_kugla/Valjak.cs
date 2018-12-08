using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razredi_valjak_kugla 
{
    class Valjak : IComparable <Valjak>
    {
        private float polumjer_baze;
        private float visina;

        public Valjak()
        {
            polumjer_baze = 1;
            visina = 1;
        }

        public Valjak(float polumjer_baze, float visina)
        {
            this.polumjer_baze = polumjer_baze;
            this.visina = visina;
        }

        public float PolumjerBaze
        {
            get => polumjer_baze;
            set => polumjer_baze = value;
        }

        public float Visina
        {
            get { return visina; }
            set { visina = value; }
        }

        public double PovrsinaBaze ()
        {
            return polumjer_baze * polumjer_baze * 3.14;
        }

        public double PovrsinaPlasta()
        {
            return 2*3.14*polumjer_baze*visina;
        }
        
        public double UkupnaPovrsina ()
        {
            return (2 * 3.14 * polumjer_baze * visina)+(polumjer_baze * polumjer_baze * 3.14) ;
        }
         
        public double Volumen()
        {
            return 3.14 * (polumjer_baze * polumjer_baze) * visina;
        }

        public void Ispis ()
        {
            Console.WriteLine("Polumjer baze valjka: {0}", polumjer_baze);
            Console.WriteLine("Visina valjka: {0}", visina);
            
        }

        public int CompareTo(Valjak other)
        {
            return this.UkupnaPovrsina().CompareTo(other.UkupnaPovrsina());
        }
    }
}
