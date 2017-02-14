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

            List<IBil> BilListe = new List<IBil>();
            BilListe.Add(new ElBil("ElMonster", 2015, 80500, 50, 10));
            BilListe.Add(new BenzinBil("BB", 2015, 10, 50000, 50));
            BilListe.Add(new DieselBil("DB - filter", 2015, 10, 50000, 50, false));
            BilListe.Add(new DieselBil("DB + filter", 2015, 10, 50000, 50, true));


            foreach (var carItem in BilListe)
            {
                if (carItem is ElBil)
                {
                    ElBil eB = carItem as ElBil;

                    Console.WriteLine("ElBil");
                    Console.WriteLine(eB + "\n");
                    
                }
                if (carItem is DieselBil)
                {
                    DieselBil dB = carItem as DieselBil;

                    Console.WriteLine("DieselBil");
                    Console.WriteLine(dB + "\n");

                }
                if (carItem is BenzinBil)
                {
                    BenzinBil bB = carItem as BenzinBil;

                    Console.WriteLine("BenzinBil");
                    Console.WriteLine(bB + "\n");

                }
                if (carItem is IElBil)
                {
                    IElBil ieB = carItem as IElBil;

                    Console.WriteLine("IelBil interface");
                    Console.WriteLine(ieB.LadeTid());


                }

            }


            Console.ReadKey();






            // Bil nyBil1 = new Bil(200000000); abstract 
        }
    }
}
