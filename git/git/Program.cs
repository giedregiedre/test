using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasykite tris skaicius: ");
            int pirmas = Convert.ToInt32(Console.ReadLine());
            int antras = Convert.ToInt32(Console.ReadLine());
            int trecias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Max(pirmas, antras, trecias));

            Console.ReadKey();
        }
        static string Max(int pirmas, int antras, int trecias)
        {

            if (pirmas > antras && pirmas > trecias)
            {
                return "Didziausias pirmas ivestas sakicius";
            }
            else if (antras > pirmas && antras > trecias)
            {
                return "Didziausias antras ivestas sakicius";
            }
            else if (trecias > pirmas && trecias > antras)
            {
                return "Didziausias trecais ivestas sakicius";
            }
            else
                return "Kazkurie skaiciai vienodi";
        }
    }
}
