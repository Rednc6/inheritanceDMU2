using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceDMU2.Model
{
    class DieselBil : Bil
    {
        // prop
        public bool PartikelFilter { get; set; }

        // ctor
        public DieselBil(string mærke, int købsår, double kmPrLiter, double bilPrisExAfgift, bool partikelFilter) : base(mærke, købsår, kmPrLiter, bilPrisExAfgift)
        {
        }

        public DieselBil(string mærke, int købsår, double kmPrLiter, double bilPrisExAfgift) : this(mærke, købsår, kmPrLiter, bilPrisExAfgift, true)
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


    }
}
