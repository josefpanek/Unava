using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unava
{
    internal class Clovek
    {
        /// <summary>
        /// Celé jméno
        /// </summary>
        private string jmeno;
        /// <summary>
        /// Věk
        /// </summary>
        private int vek;
        /// <summary>
        /// Únava
        /// </summary>
        private int unava = 0;
        /// <summary>
        /// Inicializuje novou instanci
        /// </summary>
        /// <param name="jmeno">Celé jméno</param>
        /// <param name="vek">Věk</param>
        
        public Clovek(string jmeno, int vek)
        {
            this.jmeno = jmeno;
            this.vek = vek;
        }

        /// <summary>
        /// Vrátí textovou reprezentaci člověka
        /// </summary>
        /// <returns>textová reprezentace člověka</returns>
        public override string ToString()
        {
            return String.Format("{0} ({1})", jmeno, vek);
        }
        /// <summary>
        /// Uběhne danou vzdálenost
        /// </summary>
        /// <param name="vzdalenost">Vzdálenost v Km</param>
        public void Beh(int vzdalenost)
        {
            if (unava + vzdalenost <= 20)
                unava += vzdalenost;
            else
                Console.WriteLine("Jsem příliš unavený");
        }
        /// <summary>
        /// Spí danou dobu
        /// </summary>
        /// <param name="cas">Doba v hodinách</param>
        public void Spat(int cas)
        {
            if (unava == 0)
                Console.WriteLine("Nechce se mi spát");
            else if (unava - 10 * cas >= 0)
                unava -= 10 * cas;
            else
                unava = 0;
        }
    }
}