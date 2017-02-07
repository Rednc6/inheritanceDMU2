using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceDMU2.Model
{
    sealed class BenzinBil : Bil
    {
        // prop
        public int tank { get; set; }

        public double KmPrLiter { get; set; }


        // ctor
        public BenzinBil(string mærke, int købsår, double kmPrLiter, double bilPrisExAfgift, int tank) : base(mærke, købsår, bilPrisExAfgift)
        {
            this.KmPrLiter = kmPrLiter;
            this.tank = tank;
        }

        // metod
        public override double HalvÅrligEjeafgift()
        {
            if (KmPrLiter <20)
            {
                return 1200;
            }
            if (KmPrLiter >= 20 && KmPrLiter <= 28)
            {
                return 600;
            }
            if (KmPrLiter > 28)
            {
                return 320;
            }

            return 0;
        }

        public override double RækkeVidde()
        {
            return tank * KmPrLiter;
            
        }

        public override string ToString()
        {
            return $"Mærke = {Mærke} \nKøbs år = {KøbsÅr} \nPris = {TotalPris()} \nRække vidde = {RækkeVidde()} \nEjer afgift {HalvÅrligEjeafgift()}";
        }
    }
}
