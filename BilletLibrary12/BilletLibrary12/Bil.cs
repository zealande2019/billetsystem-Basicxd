using System;

namespace BilletLibrary12
{
    public class Bil : KøretøjBase
    {

        /// <summary>
        /// Nummerplade kan ikke være længere end 7
        /// </summary>
        public string Nummerplade
        {
            get { return Nummerplade; }
            set
            {
                if (Nummerplade.Length < 8)
                {
                    Nummerplade = value;
                }
                else
                {
                    throw new ArgumentException($"Nummeret må ikke være længere end 7 - Du skrev {value}");
                }
            }
        }



        /// <summary>
        /// Man kan sætte datoen
        /// </summary>
        public DateTime Dato { get; set; }

        /// <summary>
        /// Angiv om der bliver brugt brobiz eller ej, ved hjælp af true eller false
        /// </summary>
        /// <param name="brobiz"></param>
        /// <returns>Skal returner enten 237,5 med brobiz eller 250 uden brobiz</returns>
        public override decimal Pris(bool brobiz)
        {
            if (brobiz == true)
            {
                decimal rabat = ((250M / 100M) * 5M);

                return 250 - rabat;
            }
            else
            {
                return 250;
            }

        }

        /// <summary>
        /// Hvilken køretøj det er
        /// </summary>
        /// <returns>Skal returnere bil</returns>
        public override string Køretøj()
        {
            return "Bil";
        }


    }

}
