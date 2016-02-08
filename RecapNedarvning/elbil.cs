using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RecapNedarvning
{
    public class ElBil : Bil, IElMotor
    {

        public int BatteriKapacitet { get; set; }
        public int KmPrKW { get; set; }

        public ElBil(int pris, int købsår, int kmPrKw, int battteriKapacitet)
            :base(pris,købsår)
        {
            this.KmPrKW = kmPrKw;
            this.BatteriKapacitet = battteriKapacitet;
        }

        /// <summary>
        /// rækkevidden for fuld opladning af batteriet
        /// </summary>
        /// <returns></returns>
        public override int RækkeVidde()
        {
            return BatteriKapacitet*KmPrKW;
        }

        /// <summary>
        /// grønafgift for ElBil
        /// </summary>
        /// <returns></returns>
        public override int GrønAfgift()
        {
            return 0;
        }

        /// <summary>
        /// registreringsafgiften for elbil
        /// </summary>
        /// <returns></returns>
        public override int Registreringsafgift()
        {
            return base.Registreringsafgift() * 20 / 100;
        }

        /// <summary>
        /// Ladetid i timer
        /// </summary>
        /// <returns></returns>
        public int LadeTid()
        {
            return 5;
        }
    }
}
