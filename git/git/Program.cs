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
            Console.WriteLine(InRange(pirmas, antras, trecias));
            Console.WriteLine(IsPrimal(pirmas));
            Console.WriteLine(D20(pirmas));
            Console.WriteLine(D10(pirmas));
            Console.WriteLine(D6(pirmas));

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
        static bool InRange(int pirmas, int antras, int trecias)
        {
            if (pirmas < antras && pirmas > trecias)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsPrimal(int pirmas)
        {
            for (int i = 0; i < pirmas; i++)
            {              
                if (pirmas < 1 || (pirmas % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int D20(int skaicius)
        {
            skaicius = new Random().Next(0, 20);
            return skaicius;
        }
        static int D10(int skaicius)
        {
            skaicius = new Random().Next(0, 10);
            return skaicius;
        }
        static int D6(int skaicius)
        {
            skaicius = new Random().Next(0, 6);
            return skaicius;
        }
    }
}
