using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Põhikonstruktsioonid_1
{
    internal class Osa3_Funktsioonid
    {
        public static int[] GenereeriRuudud(int min, int max)
        {
            Random rnd = new Random();
            int N = rnd.Next(-100, 100);
            int M = rnd.Next(-100, 100);
            int k = 0;
            if (N < M)
            {
                int[] massive = new int[M - N + 1];
                for (int i = M; i <= N; i++)
                {
                    massive[k] = i * i;
                    k++;
                }
                return massive;
            }
            else
            {
                int[] massive = new int[N - M + 1];
                for (int i = M; i <= N; i++)
                {
                    massive[k] = i * i;
                    k++;
                }
                return massive;
            }
        }
        public static double[] Tekstist_arvud()
        {
            Console.WriteLine("Sisesta arvud koosa või tühikuga eraldatult: ");
            string sisend=Console.ReadLine();
            char[] eraldajad = new char[] {' ', ',', ';' };
            string[] osad = sisend.Split(eraldajad, StringSplitOptions.RemoveEmptyEntries);
            double[] arvud = new double[osad.Length];
            for (int i = 0; i < osad.Length; i++)
            {
                arvud[i] = Convert.ToDouble(osad[i]);
            }
            return arvud;
        }
        public static Tuple<double, double, double> AnalüüsiArve(double[] arvud)
        {
            double summa = arvud.Sum();
            double keskmine = arvud.Average();
            double korrutis = 1;
            foreach (double arv in arvud)
            {
                korrutis *= arv;
            }
            return Tuple.Create(summa, keskmine, korrutis);
        }
        public static string KuniMärksõnani(string märksõna)
        {
            List<string> vastus = new List<string>();
            string sõna = "";
            do
            {
                Console.WriteLine("Osta elevant ära!");
                sõna = Console.ReadLine();
                vastus.Add(sõna);
            }
            while (sõna.ToLower() != märksõna);
            for (int i = 0; i < vastus.Count; i++)
                Console.WriteLine($"{i+1}. {vastus[i]}");
            return "Tubli";
        }
        public static string ArvaArv()
        {
            Random rnd = new Random();
            string vastus;
            string vas = "";
            do
            {
                Console.WriteLine("Kas tahad numbrit ära arvata?");
                vastus = Console.ReadLine();
                if (vastus != "jah")
                {
                    Console.WriteLine("Mäng lõpeb.");
                    break;
                }
                int arv = rnd.Next(1, 100);
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Arva arv: ");
                    try
                    {
                        int kas_arv = int.Parse(Console.ReadLine());
                        if (kas_arv == arv)
                        {
                            vas = "Õige!";
                            continue;
                        }
                        else if (kas_arv < arv)
                        {
                            Console.WriteLine("Liiga väike");
                        }
                        else if (kas_arv > arv)
                        {
                            Console.WriteLine("Liiga suur!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                Console.WriteLine($"Sa kaotasid. Õige arv {arv}!");
            }
            while (vastus.ToLower()=="jah");
            return vas;
        }
        public static int SuurimNeliarv(int[] arvud)
        {
            Array.Sort(arvud);
            Array.Reverse(arvud);
            int summa = arvud[0] * 1000 + arvud[1] * 100 + arvud[2] * 10 + arvud[3];
            return summa;
        }
        public static string GenereeriKorrutustabel(int ridadeArv, int veergudeArv)
        {
            int[,] numbers = new int[ridadeArv, veergudeArv];
            for (int i = 0; i < ridadeArv; i++)
            {
                for (int j = 0; j < veergudeArv; j++)
                {
                    numbers[i, j] = (i + 1) * (j + 1);
                }
            }
            for (int i = 0; i < ridadeArv; i++)
            {
                for (int j = 0; j < veergudeArv; j++)
                {
                    Console.Write($"{numbers[i, j],4}");
                }
                Console.WriteLine();
            }
            return "Korrutustabel";
        }
        public static string Nimetus(string[] nimi)
        {
            nimi[2] = "Kati";
            nimi[5] = "Mati";
            return ($"3. {nimi[2]} ja 6. {nimi[5]}");

        }
    }
}
