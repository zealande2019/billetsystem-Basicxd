using System;

namespace BilletLibrary12
{
    public class MC : KøretøjBase
    {
        /// <summary>
        /// Angiv om der bliver brugt brobiz eller ej, ved hjælp af true eller false
        /// </summary>
        /// <param name="brobiz"></param>
        /// <returns>Skal returner enten 118,75 med brobiz eller 125 uden brobiz</returns>
        public override decimal Pris(bool brobiz)
        {
            if (brobiz == true)
            {
                return 125;
            }
            else
            {
                return 125;
            }

        }

        /// <summary>
        /// Hvilken køretøj det er
        /// </summary>
        /// <returns>Skal returnere bil</returns>
        public override string Køretøj()
        {
            return "MC";
        }
    }
}