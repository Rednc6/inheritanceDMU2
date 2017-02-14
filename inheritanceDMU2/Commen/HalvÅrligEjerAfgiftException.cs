using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceDMU2.Commen
{
    public class HalvÅrligEjerAfgiftException : Exception
    {
        const string text = "HalvÅrligEjerafgift er forkert,Km/l er mindre end 5 km/l ";

        public HalvÅrligEjerAfgiftException()
        : this(text)
        {
        }

        public HalvÅrligEjerAfgiftException(string message)
        : base(message)
        {
        }

        public HalvÅrligEjerAfgiftException(string message, Exception inner)
        : base(message, inner)
        { }

    }
    
}
