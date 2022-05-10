using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unava
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clovek karel = new Clovek("Karel Nový", 25);

            Console.WriteLine(karel);

            karel.Beh(10);
            karel.Beh(10);
            karel.Beh(10);

            Console.ReadKey();
        }
    }
}
