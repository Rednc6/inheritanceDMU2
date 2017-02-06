using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceDMU2.Model
{
    class BenzinBil : Bil
    {
        public BenzinBil(string mærke, int købsår, double kmPrLiter, double bilPrisExAfgift) : base(mærke, købsår, kmPrLiter, bilPrisExAfgift)
        {
        }

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
    }
}
