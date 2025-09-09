using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv24_C_
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

        //Создай класс Inimene с полями:
        //string Nimi(имя)
        //int Vanus(возраст)
        //Создай метод Statistika(List<Inimene> inimesed), который:
        //вычисляет сумму всех возрастов и средний возраст,
        //находит самого старшего и самого младшего человека,
        //возврщает эти значения в виде кортежа Tuple<int, double, Inimene, Inimene>.
        //Пользватель вводит 5 человек(имя и возраст отдельно).


    }
}
