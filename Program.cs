using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje2
{
    internal class Program
    {
        class ProgramskiJezik
        {
            double postotak;

            public double Postotak { get => postotak; set => postotak = value; }
        }

        class Proceduralni : ProgramskiJezik
        {
            public Proceduralni(double postotak)
            {
                Postotak = postotak;
            } 
        }

        class Objektni : ProgramskiJezik
        {
            public Objektni(double postotak)
            {
                Postotak = postotak;    
            }
        }


        class Funkcionalni : ProgramskiJezik
        {
            public Funkcionalni(double postotak)
            {
                Postotak= postotak;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Upisšite x ");
            Proceduralni x = new Proceduralni(Convert.ToInt32(Console.ReadLine()));
            Objektni y = new Objektni(Convert.ToInt32(Console.ReadLine()));
            Funkcionalni z = new Funkcionalni(Convert.ToInt32(Console.ReadLine()));

            double zbroj = x.Postotak + y.Postotak + z.Postotak;

            if (zbroj != 100)
            {
                Console.WriteLine("Neispravan upis podataka ");
            }
            else {

                if (x.Postotak > y.Postotak && x.Postotak > z.Postotak)

                    Console.WriteLine("Najzastupljenij su proceduralni jezici");

                else if (y.Postotak > z.Postotak)
                    Console.WriteLine("Najzastupljeniji su objektni jezici");

                else
                    Console.WriteLine("Najzastupljeniji su funkcuionalni jezici");
        }

            Console.ReadKey();

        }
    }
}
