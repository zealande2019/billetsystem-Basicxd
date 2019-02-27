using System;

namespace BilletLibrary12
{
    abstract public class KøretøjBase
    {
        /// <summary>
        /// Man kan sætte datoen
        /// </summary>
        public DateTime Dato { get; set; }

        /// <summary>
        /// Nummerplade kan ikke være længere end 7
        /// </summary>
        public string Nummerplade
        {
            get { return Nummerplade; }
            set
            {
                if (Nummerplade.Length <= 7)
                {
                    Nummerplade = value;
                }
                else
                {
                    throw new ArgumentException($"Nummeret må ikke være længere end 7 - Du skrev {value}");
                }
            }
        }

        public abstract decimal Pris(bool brobiz);

        public abstract string Køretøj();
    }
}