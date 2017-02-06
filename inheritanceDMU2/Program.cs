using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inheritanceDMU2.Model;

namespace inheritanceDMU2
{
    class Program
    {

        static void Main(string[] args)
        {


        List<DieselBil> DieselBilListe = new List<DieselBil>();

            DieselBilListe.Add(new DieselBil("Fiat", 1943, 2, 500, false));
            DieselBilListe.Add(new DieselBil("Porche", 1943, 2, 500, false));
            DieselBilListe.Add(new DieselBil("Toyota", 1943, 2, 500));
            DieselBilListe.Add(new DieselBil("Madeup", 1943, 2, 500));
            DieselBilListe.Add(new DieselBil("Tiredofmaking up", 1943, 2, 500));

            foreach (var item in DieselBilListe)
            {
                Console.WriteLine($"{item.Mærke} + {item.KøbsÅr} + {item.KmPrLiter} + {item.BilPrisExAfgift} + {item.PartikelFilter}");

            }

            Console.ReadKey();






            // Bil nyBil1 = new Bil(200000000); abstract 
        }
    }
}
