using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceDMU2.Model
{
    public class DieselBil : Bil
    {
        // prop
        public bool PartikelFilter { get; set; }
        public double tank { get; set; }
        public double KmPrLiter { get; set; }

        // ctor
        public DieselBil(string mærke, int købsår, double kmPrLiter, double bilPrisExAfgift, double tank, bool partikelFilter) 
            : base(mærke, købsår, bilPrisExAfgift)
        {
            this.tank = tank;
            this.KmPrLiter = kmPrLiter;
            this.PartikelFilter = partikelFilter;
        }

        public DieselBil(string mærke, int købsår, double kmPrLiter, double bilPrisExAfgift, double tank) 
            : this(mærke, købsår, kmPrLiter, bilPrisExAfgift, tank, true)
        {
        }


        // metoder
        public override double HalvÅrligEjeafgift()
        {
            if (KmPrLiter <15)
            {
                if (PartikelFilter == true)
                {
                    return 2000;
                }
                else
                {
                    return 2500;
                }

            }
            if (KmPrLiter >= 15 && KmPrLiter <= 25)
            {
                if (PartikelFilter == true)
                {
                    return 1000;
                }
                else
                {
                    return 1500;
                }
            }
            if (KmPrLiter >= 25)
            {
                if (PartikelFilter == true)
                {
                    return 350;
                }
                else
                {
                    return 850;
                }
            }

            return 0;
       }

        public override double RækkeVidde()
        {
            return tank * KmPrLiter;
            
        }

        public override string ToString()
        {
            return $"Mærke = {Mærke} \nKøbs år = {KøbsÅr} \nPris = {TotalPris()} \nRække vidde = {RækkeVidde()} \nFilter = {PartikelFilter} \nEjer afgift = {HalvÅrligEjeafgift()}";
        }

    }
}
