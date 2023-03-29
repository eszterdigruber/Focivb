using System.IO;
using System.Text;
namespace Focivb
{
    internal class Program
    {
        static List<VB> VbList = new List<VB>();
        static void Main(string[] args)
        {
            Feladat3(); Console.WriteLine("\n--------------------------\n");
            Feladat4(); Console.WriteLine("\n--------------------------\n");
            Feladat5(); Console.WriteLine("\n--------------------------\n");
            Feladat6(); Console.WriteLine("\n--------------------------\n");
        }

        private static void Feladat6()
        {
            int db = 0;
            foreach (var v in VbList) {
                db++;
            }
            Console.WriteLine("6.feladat: ");
        }

        private static void Feladat5()
        {
            int OsszeFeroHelySzam = 0;
            foreach (var v in VbList)
            {
                OsszeFeroHelySzam += v.Ferohely;
            }
            double AtlagFeroHely = (double)OsszeFeroHelySzam / VbList.Count;
            Console.WriteLine($"5.feladat: Átlagos férőhelyszám: {AtlagFeroHely:0.0}");
        }

        private static void Feladat4()
        {
            int MinFerohely = int.MaxValue;
            string MinVaros = "cica";
            string MinNev = "kutya";
            foreach (var v in VbList)
            {
                if (MinFerohely > v.Ferohely)
                {
                    MinFerohely = v.Ferohely;
                    MinVaros = v.Varos;
                    MinNev = v.Nev1;
                }
            }
            Console.WriteLine($"4.feladat: A legkevesebb férőhely: " +
                $"\n\tVáros: {MinVaros}" +
                $"\n\tStadion neve: {MinNev}" +
                $"\n\tFérőhely: {MinFerohely}");
        }

        private static void Feladat3()
        {
            var sr = new StreamReader(@"vb2018.txt", Encoding.UTF8);
            string sor = "";
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                VbList.Add(new VB(sor));
            }
            sr.Close();
            Console.WriteLine($"3.feladat: Stadionok száma: {VbList.Count}");
        }
    }
}