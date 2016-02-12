using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapNedarvning
{
    public class BenzinBil : Bil
    {

        /// <summary>
        /// angiver tanken i liter
        /// </summary>
        public int Tank { get; set; }
        public int KmPrLiter { get; set; }


        /// <summary>
        /// konstruktor for Benzinbil
        /// </summary>
        /// <param name="pris"></param>
        /// <param name="købsår"></param>
        /// <param name="kmPrL"></param>
        public BenzinBil(int pris, int købsår,int tank, int kmLiter)
            :base(pris,købsår)
        {
            this.KmPrLiter = kmLiter;
            this.Tank = tank;
        }


        public override int RækkeVidde()
        {
            if (Tank <= 0 || KmPrLiter <=0)
                throw new ArgumentException(String.Format("Værdien af tank eller KmprL skal være > 0. tank er : {0}, KmPrL er : {1} ",Tank,KmPrLiter));
            return Tank*KmPrLiter;
        }

        public override int GrønAfgift()
        {
            return base.GrønAfgift()-500;
        }
    }
}
