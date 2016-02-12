using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RecapNedarvning
{
    
    /// <summary>
    /// DiselBil object
    /// </summary>
    public class Dieselbil : Bil
    {

        public bool PartikelFilter { get; set; }
        public int KmPrLiter { get; set; }

        /// <summary>
        /// angiver tanken i liter
        /// </summary>
        public int Tank { get; set; }

        public Dieselbil(int pris, int købsår, int kmLiter, int tank)
           :this(pris, købsår, kmLiter, tank, true)
        {
        }


        public Dieselbil(int pris,int købsår, int kmLiter, int tank, bool partikelFilter)
            :base(pris,købsår)
        {
            this.PartikelFilter = partikelFilter;
            this.Tank = tank;
            this.KmPrLiter = kmLiter;
        }

        /// <summary>
        /// grøn afgift for dieselbil
        /// </summary>
        /// <returns></returns>
        public override int GrønAfgift()
        {
            int afgift = 0;

            if (this.KmPrLiter < 5)
            {
                throw new ArgumentException("Bilen kører for kort på liter skal være over 5");
            }

            if (PartikelFilter)
            {
                
            }

            // her skal der beregnes noget grøn afgift

            //if (afgift <= 0)
            //{
            //    throw new GrønAfgiftException();
                
            //}

            return base.GrønAfgift() + 1000;
        }

        /// <summary>
        /// rækkevidden for dieselbilen
        /// </summary>
        /// <returns></returns>
        public override int RækkeVidde()
        {
            return Tank*KmPrLiter;
        }
    }
}
