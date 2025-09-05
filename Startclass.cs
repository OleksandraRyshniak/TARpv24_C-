using System.Text;

namespace TARpv24_C_
{
    internal class Startclass
    {
        public static void Main(string[] args)
        {
            //2. Osa
            //Random rnd = new Random();
            //int kuu_number=rnd.Next(1, 12);
            //string nimetus = Osa1_funktsioonid.Kuu_nimetus(kuu_number);
            //Console.WriteLine($"Nr: {kuu_number} - {nimetus}");

            //Console.WriteLine("Kas sa tahad dekodeerida arv -> nimetusse?");
            //string vastus=Console.ReadLine();
            //if (vastus.ToLower() != "jah")
            //{
            //    Console.WriteLine("Ei taha, siis ei taha");
            //}
            //else
            //{
            //    try
            //    {
            //        Console.WriteLine("Nr: ");
            //        kuu_number = int.Parse(Console.ReadLine());
            //        Console.WriteLine(Osa1_funktsioonid.Hooaeg(kuu_number));
            //    }
            //    catch (Exception e)
            //    {

            //        Console.WriteLine(e);
            //    }
            //}

            // 1 Ülesanne

            //Console.WriteLine("Mis su nimi on?");
            //string vastus = Console.ReadLine();
            //    if (vastus.ToLower() == "juku")
            //    {
            //        Console.WriteLine("Me läheme täna kinno. Kui vana sa oled?");
            //        try
            //        {
            //            int vanus = int.Parse(Console.ReadLine());
            //            Console.WriteLine(Osa1_funktsioonid.Pilet(vanus));
            //        }
            //        catch (Exception l)
            //        {
            //            Console.WriteLine(l );
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Me ei lähe täna kinno.");
            //    }

            ////2 Ülesanne
            //Console.WriteLine("1.Mis su nimi on?");
            //string nimi = Console.ReadLine();
            //Console.WriteLine("2.Mis su nimi on?");
            //string nimi2 = Console.ReadLine();
            //Console.WriteLine(Osa1_funktsioonid.Nimi(nimi, nimi2));

            ////3 Ülesanne
            //Console.WriteLine("Kui pikk on sinu tuba? (vastus meetrites)");
            //try
            //{
            //    float pikk = float.Parse(Console.ReadLine());
            //    Console.WriteLine("Kui lai on sinu tuba ? (vastus meetrites)");
            //    try
            //    {
            //        float lai = float.Parse(Console.ReadLine());
            //        float pild = Osa1_funktsioonid.Pind(pikk, lai);
            //        Console.WriteLine($"Sinu toa pindala: {pild}");
            //        Console.WriteLine("Kas sa tahad remonti teha?");
            //        string v = Console.ReadLine();
            //        if (v.ToLower() != "ei")
            //        {
            //            Console.WriteLine( "Kui palju maksab ruutmeeter?");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Tšao!");
            //        }
            //        try
            //        {
            //            float r = float.Parse(Console.ReadLine());
            //            Console.WriteLine($"Põranda vahetamise hind: {Osa1_funktsioonid.Hind(r, pild)}");
            //        }
            //        catch (Exception p)
            //        {
            //            Console.WriteLine(p);
            //        }
            //    }
            //    catch (Exception j)
            //    {
            //        Console.WriteLine(j);
            //    }
            //}
            //catch (Exception k)
            //{
            //    Console.WriteLine(k);
            //}

            // 4 Ülesanne
            Random rnd = new Random();
            int arv=rnd.Next(1, 100);
            Console.WriteLine($"Hind 30% soodustusega: {arv}, Algne hind: {Osa1_funktsioonid.Summa(arv)}");

            //5 Ülesanne
            Console.WriteLine("Mis temperatuur praegu on?");
            try
            {
                float tem = float.Parse(Console.ReadLine());
                Console.WriteLine(Osa1_funktsioonid.Temperatuut(tem));
            }
            catch (Exception ü)
            {
                Console.WriteLine(ü);
            }

            //6 Ülesanne
            //Спроси рост человека и сообщи, низкий он, средний или высокий (границы установи сам).

            //Спроси у человека рост и пол и сообщи, низкий он, средний или высокий(несколько блоков условий могут быть вложенными).

            //Спроси у человека в магазине отдельно, хочет ли он купить молоко, булку, хлеб. Сложи цены и сообщи, сколько стоят все купленные продукты.
            
            //1. Osa
            //Console.OutputEncoding = Encoding.UTF8;

            //Console.BackgroundColor = ConsoleColor.Magenta;
            //Console.ForegroundColor = ConsoleColor.DarkYellow;

            //Console.WriteLine("Tere tulemast! Mis on sinu nimi?");//выводит текст на консоль
            //string tekst = Console.ReadLine();//функция спрашивает что-то у пользователя
            //Console.WriteLine($"{tekst}, Rõõm näha!");// $ = f
            //int a = 1000; // целые числа
            //char taht = 'A';
            //Console.Write($"Esimene arv on {a}, Sisesta b = ... ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Esimene arv on {0}, Sisesta {1}. Summa on {2}", a, b, a + b);
            //Console.WriteLine("Ujukomaarv");
            //double d = double.Parse(Console.ReadLine()); // десятичные
            //Console.WriteLine(d);
            //float f= float.Parse(Console.ReadLine());
            //Console.WriteLine(f);
            //bool t = false; // bool

            //Random random = new Random(); // random
            //a = random.Next(-100,200);
            //Console.WriteLine(a);

            //float vastus=Osa1_funktsioonid.Kalkulaator(f, a);
            //Console.WriteLine($"arv1 = {f}, arv2 = {a}. Kalkulaatori tulemus: {vastus}");
        }
        }
}
