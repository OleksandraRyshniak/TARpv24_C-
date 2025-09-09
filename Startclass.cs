using System.Text;

namespace TARpv24_C_
{
    internal class Startclass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.OutputEncoding = Encoding.UTF8;

            //1.Osa
            Console.OutputEncoding = Encoding.UTF8;

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("Tere tulemast! Mis on sinu nimi?");//выводит текст на консоль
            string tekst = Console.ReadLine();//функция спрашивает что-то у пользователя
            Console.WriteLine($"{tekst}, Rõõm näha!");// $ = f
            int a = 1000; // целые числа
            char taht = 'A';
            Console.Write($"Esimene arv on {a}, Sisesta b = ... ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Esimene arv on {0}, Sisesta {1}. Summa on {2}", a, b, a + b);
            Console.WriteLine("Ujukomaarv");
            double d = double.Parse(Console.ReadLine()); // десятичные
            Console.WriteLine(d);
            float f = float.Parse(Console.ReadLine());
            Console.WriteLine(f);
            bool t = false; // bool

            Random random = new Random(); // random
            a = random.Next(-100, 200);
            Console.WriteLine(a);

            float vastus = Osa1_funktsioonid.Kalkulaator(f, a);
            Console.WriteLine($"arv1 = {f}, arv2 = {a}. Kalkulaatori tulemus: {vastus}");






        }
    }
}
