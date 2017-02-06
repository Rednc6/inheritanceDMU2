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
            if (PartikelFilter == true)
            {
                return base.HalvÅrligEjeafgift();

            }
            else
            {
                return base.HalvÅrligEjeafgift() + 500;

            }


        }


    }
}
