using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Põhikonstruktsioonid_1
{
    internal class Startclass_2
    {
        public static void Main(string[] args)
        {
            //2.Osa
            Random rnd = new Random();
            int kuu_number = rnd.Next(1, 12);
            string nimetus = Osa1_funktsioonid.Kuu_nimetus(kuu_number);
            Console.WriteLine($"Nr: {kuu_number} - {nimetus}");

            Console.WriteLine("Kas sa tahad dekodeerida arv -> nimetusse?");
            string vastus2 = Console.ReadLine();
            if (vastus2.ToLower() != "jah")
            {
                Console.WriteLine("Ei taha, siis ei taha");
            }
            else
            {
                try
                {
                    Console.WriteLine("Nr: ");
                    kuu_number = int.Parse(Console.ReadLine());
                    Console.WriteLine(Osa1_funktsioonid.Hooaeg(kuu_number));
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
            }

            //1 Ülesanne

            Console.WriteLine("Mis su nimi on?");
            string vastus1 = Console.ReadLine();
            if (vastus1.ToLower() == "juku")
            {
                Console.WriteLine("Me läheme täna kinno. Kui vana sa oled?");
                try
                {
                    int vanus = int.Parse(Console.ReadLine());
                    Console.WriteLine(Osa1_funktsioonid.Pilet(vanus));
                }
                catch (Exception l)
                {
                    Console.WriteLine(l);
                }
            }
            else
            {
                Console.WriteLine("Me ei lähe täna kinno.");
            }

            //2 Ülesanne

            Console.WriteLine("1.Mis su nimi on?");
            string nimi = Console.ReadLine();
            Console.WriteLine("2.Mis su nimi on?");
            string nimi2 = Console.ReadLine();
            Console.WriteLine(Osa1_funktsioonid.Nimi(nimi, nimi2));

            //3 Ülesanne

            Console.WriteLine("Kui pikk on sinu tuba? (vastus meetrites)");
            try
            {
                float pikk = float.Parse(Console.ReadLine());
                Console.WriteLine("Kui lai on sinu tuba ? (vastus meetrites)");
                try
                {
                    float lai = float.Parse(Console.ReadLine());
                    float pild = Osa1_funktsioonid.Pind(pikk, lai);
                    Console.WriteLine($"Sinu toa pindala: {pild}");
                    Console.WriteLine("Kas sa tahad remonti teha?");
                    string v = Console.ReadLine();
                    if (v.ToLower() != "ei")
                    {
                        Console.WriteLine("Kui palju maksab ruutmeeter?");
                    }
                    else
                    {
                        Console.WriteLine("Tšao!");
                    }
                    try
                    {
                        float r = float.Parse(Console.ReadLine());
                        Console.WriteLine($"Põranda vahetamise hind: {Osa1_funktsioonid.Hind(r, pild)}");
                    }
                    catch (Exception p)
                    {
                        Console.WriteLine(p);
                    }
                }
                catch (Exception j)
                {
                    Console.WriteLine(j);
                }
            }
            catch (Exception k)
            {
                Console.WriteLine(k);
            }

            // 4 Ülesanne

            Random random1 = new Random();
            int arv = random1.Next(1, 100);
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

            Console.WriteLine("Mis sinu pikk on?(cm) ");
            try
            {
                float pikkus = float.Parse(Console.ReadLine());
                Console.WriteLine(Osa1_funktsioonid.Pikk(pikkus));
            }
            catch (Exception ö)
            {
                Console.WriteLine(ö);
            }

            //7 Ülesanne    

            Console.WriteLine("Sisesta sinu sugu:");
            string b1 = Console.ReadLine();
            if (b1.ToLower() == "mees")
            {
                Console.WriteLine("Sinu on sugu mees.");
                Console.WriteLine("Mis sinu pikk on?(cm) ");
                try
                {
                    float pikkus = float.Parse(Console.ReadLine());
                    Console.WriteLine(Osa1_funktsioonid.Pikk(pikkus));
                }
                catch (Exception p)
                {
                    Console.WriteLine(p);
                }
            }
            else
            {
                Console.WriteLine("Sinu on sugu naine.");
                Console.WriteLine("Mis sinu pikk on?(cm) ");
                try
                {
                    float pikkus = float.Parse(Console.ReadLine());
                    Console.WriteLine(Osa1_funktsioonid.Pikk_naine(pikkus));
                }
                catch (Exception p)
                {
                    Console.WriteLine(p);

                }
            }

            //8 Ülesanne
            float piim = 0.60f;
            float leib = 1.20f;
            float sai = 0.80f;
            int iu = 0;
            Console.WriteLine("Tere.Kas te soovite piima osta?");
            string kus = Console.ReadLine();
            if (kus.ToLower() == "jah")
            {
                Console.WriteLine("Sisesta kogus: ");
                try
                {
                    int kogus = int.Parse(Console.ReadLine());
                    Console.WriteLine("Kas te soovite leiba osta?");
                    string v = Console.ReadLine();
                    if (v.ToLower() == "jah")
                    {
                        Console.WriteLine("Sisesta kogus: ");
                        try
                        {
                            int kogus2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Kas te soovite saiakest osta?");
                            string n = Console.ReadLine();
                            if (n.ToLower() == "jah")
                            {
                                Console.WriteLine("Sisesta kogus: ");
                                try
                                {
                                    int kogus3 = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"Kokku: {Osa1_funktsioonid.Hind(piim, kogus, leib, kogus2, sai, kogus3)}");
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e);
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Kokku: {Osa1_funktsioonid.Hind(piim, kogus, leib, kogus2, iu, iu)}");
                            }
                        }                   
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Kas sa tahad saiakest osta?");
                        string m = Console.ReadLine();
                        if (m.ToLower() == "jah")
                        {
                            Console.WriteLine("Sisesta kogus: ");
                            try
                            {
                                int kogus3 = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Kokku: {Osa1_funktsioonid.Hind(piim, kogus, iu, iu, sai, kogus3)}");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Kokku: {Osa1_funktsioonid.Hind(piim, kogus)}");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

        }
    }
}
