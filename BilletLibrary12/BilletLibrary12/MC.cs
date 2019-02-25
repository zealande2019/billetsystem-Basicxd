using System;

namespace BilletLibrary12
{
    public class MC : KøretøjBase
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
        /// <returns>Skal returner enten 118,75 med brobiz eller 125 uden brobiz</returns>
        public override double Pris(bool brobiz)
        {
            if (brobiz == true)
            {
                return 118.75;
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