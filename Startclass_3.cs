using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARpv24_C_;

namespace TARpv24_C_
{
    internal class Startclass_3
    {
        static void Main(string[] args)
        {
            //   // 3.Osa Massivid, List, Kordused
            //    Random rnd = new Random();

            //    List<string> nimed = new List<string>();
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.Write($"{i + 1}. Nimi: ");
            //        nimed.Add(Console.ReadLine());

            //    }
            //    Console.WriteLine("---------------------------------------------");
            //    foreach (string nimi in nimed)
            //    {
            //        Console.WriteLine(nimi);
            //    }
            //    //Massiv
            //    int[] arvud = new int[10];
            //    int j = 0;
            //    while (j < 10)
            //    {
            //        Console.WriteLine(j + 1);
            //        arvud[j] = rnd.Next(1, 101);
            //        j++;
            //    }
            //    foreach (int wer in arvud)
            //    {
            //        Console.WriteLine(wer);
            //    }

            //    List<Isik> isikud = new List<Isik>();
            //    j = 0;
            //    do
            //    {
            //        Console.WriteLine(j + 1);
            //        Isik isik = new Isik();
            //        Console.Write("Eesnimi: ");
            //        isik.eesnimi = Console.ReadLine();
            //        Console.Write("Perenimi: ");
            //        isik.perenimi = Console.ReadLine();
            //        isikud.Add(isik);
            //        j++;

            //    } while (j < 5);
            //    isikud.Sort((x, y) => x.eesnimi.CompareTo(y.eesnimi));
            //    Console.WriteLine($"Kokku on {isikud.Count()} isikud");
            //    foreach (Isik isik in isikud)
            //    {
            //        isik.Prindi_andmed();
            //    }
            //    Console.WriteLine($"Kolmandal kohal on <{isikud[2].eesnimi}> isik");


            //    Console.WriteLine("Ülesanne 1");
            //    int[] arv = Osa3_Funktsioonid.GenereeriRuudud(-100, 100);
            //    for (int i = 0; i < arv.Length; i++)
            //    {
            //        Console.WriteLine(arv[i]);
            //    }

            //    Console.WriteLine("Ülesanne 2");
            //    double[] arvud1 = Osa3_Funktsioonid.Tekstist_arvud();
            //    var tulemus = Osa3_Funktsioonid.AnalüüsiArve(arvud1);
            //    Console.WriteLine($"Summa: {tulemus.Item1:F2}, Keskmine: {tulemus.Item2:F2}, Korrutis: {tulemus.Item3:F2}");

            //    Console.WriteLine("Ülesanne 3");
            //    List<Inimene> inimesed = new List<Inimene>();
            //    int l = 0;
            //    do
            //    {
            //        Console.WriteLine(l + 1);
            //        Inimene inimene = new Inimene();
            //        Console.Write("Nimi: ");
            //        inimene.nimi = Console.ReadLine();
            //        Console.Write("Vanus: ");
            //        try
            //        {
            //            inimene.vanus = int.Parse(Console.ReadLine());
            //        }
            //        catch (FormatException)
            //        {
            //            Console.WriteLine("Palun sisesta korrektne vanus");
            //            continue;
            //        }
            //        inimesed.Add(inimene);
            //        l++;
            //    } while (l < 5);
            //    var statistika = Inimene.Statistika(inimesed);
            //    Console.WriteLine($"Kõigi inimeste vanuste summa: {statistika.Item1}");
            //    Console.WriteLine($"Keskmine vanus: {statistika.Item2:F2}");
            //    Console.WriteLine($"Vanim inimene: {statistika.Item3}");
            //    Console.WriteLine($"Noorim inimene: {statistika.Item4}");

            //Console.WriteLine("Ülesanne 4");
            //string märksõna = "elevant";
            //Console.WriteLine(Osa3_Funktsioonid.KuniMärksõnani(märksõna));

            //Console.WriteLine("Ülesanne 5");
            //Console.WriteLine(Osa3_Funktsioonid.ArvaArv());


        }
    }
}
