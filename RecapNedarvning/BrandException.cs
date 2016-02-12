using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapNedarvning
{
    public class GrønAfgiftException : Exception
    {

        const string text = "Grønafgift er forkert";

        public GrønAfgiftException()
           :this(text)
        {
        }

        public GrønAfgiftException(string message)
        : base(message)
    {
        }

        public GrønAfgiftException(string message, Exception inner)
        : base(message, inner)
    {
        }


    }
}
