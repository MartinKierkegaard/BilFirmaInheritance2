using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapNedarvning
{
    public abstract class Bil
    {
        private int Pris { get; set; }
        public int KøbsÅr { get; private set; }
        public string BilMærke { get; set; }
        public string RegNr { get; set; }
      

        protected Bil(int pris, int købsår)
        {
            this.Pris = pris;
            this.KøbsÅr = købsår;
        }

        /// <summary>
        /// viser rækkevidden for bilen 
        /// </summary>
        /// <returns></returns>
        public abstract int RækkeVidde();

        //protected abstract int RækkeVidde1();

        /// <summary>
        /// beregner registreringsafgiften for bilen
        /// </summary>
        /// <returns></returns>
        public virtual int Registreringsafgift()
        {
            //if (KøbsÅr < 2014)
            //    throw new ArgumentException("Købsåret kan ikke være mindre end 2014 ");

            int pct105afgift2015 = 80500;
            int pct105afgift2016 = 81700;

            if (KøbsÅr <= 2015)
            {
              return  beregnAfgift(pct105afgift2015);
            }
            else
            {
               return beregnAfgift(pct105afgift2016);
            }

            //return 0;
        }

        /// <summary>
        /// beregner lav og høj afgift
        /// </summary>
        /// <param name="minimumafgift"> lav regafgift</param>
        /// <param name="pris">prisen på bilen uden regafgift</param>
        /// <returns></returns>
        private int beregnAfgift(int minimumafgift)
        {
            //if (this.Pris <= 0)
            //{
            //    throw new ArgumentException("prisen må ikke være <= 0");
                 
                //return 0;
            //}


            if (this.Pris <= minimumafgift)
                return Pris*105/100;

            int pct105 = 0;
            int pct180 = 0;

            pct105 = minimumafgift * 105/100;
            pct180 = (this.Pris - minimumafgift) * 180/100;
            return pct105 + pct180;

        }

        public virtual int GrønAfgift()
        {
            return 2000;
        }

//Personbiler  105 % af værdien op til 81.700 kr.og 180 % af resten
//Motorcykler  105 % af værdien mellem 9.200-25.800 kr.og 180 % af resten


    }
}
