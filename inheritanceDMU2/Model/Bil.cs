using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceDMU2.Model
{
    public abstract class Bil : IBil
    {

        // props
        public double BilPrisExAfgift { get; private set; }

        public int KøbsÅr { get; private set; }

        public string Mærke { get; set; }

        public string RegistringNr { get; set; }

        // ctor
        public Bil(string mærke, int købsår, double bilPrisExAfgift)
        {
            this.Mærke = mærke;
            this.KøbsÅr = købsår;
            this.BilPrisExAfgift = bilPrisExAfgift;
        }


        // metods
        public virtual double RegistreringAfgift()
        {

            if (KøbsÅr <= 2014)
            {

                if (BilPrisExAfgift <= 80500)
                {
                    return BilPrisExAfgift * 1.05;
                }
                if (BilPrisExAfgift >= 80500)
                {
                    
                    double sum1 = 80500 * 1.05;
                    double sum2 = (BilPrisExAfgift - 80500) * 1.80;

                    return sum1 + sum2;
                }

            }

            if (KøbsÅr >= 2015)
            {
                if (BilPrisExAfgift <= 81700)
                {
                    return BilPrisExAfgift * 1.05;
                }
                if (BilPrisExAfgift >= 81700)
                {
                    double sum1 = 81700 * 1.05;
                    double sum2 = (BilPrisExAfgift - 81700) * 1.80;

                    return sum1 + sum2;

                }

            }
            
                return 0;
                        
        }

        public double TotalPris()
        {
            return BilPrisExAfgift + RegistreringAfgift();
        }

        public abstract double HalvÅrligEjeafgift();

        public abstract double RækkeVidde();

     

    }
}
