using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Põhikonstruktsioonid_1
{
    internal class Osa1_funktsioonid
    {
        public static float Kalkulaator(float arv1, float arv2)
        {
            float k = arv1 * arv2;
            return k;
        }
        public static string Kuu_nimetus(int kuu_nr)
        {
            string kuu = "";
            switch (kuu_nr)
            {
                case 1: kuu = "Jaanuar"; break;
                case 2: kuu = "Veebruar"; break;
                case 3: kuu = "Märts"; break;
                case 4: kuu = "Aprill"; break;
                case 5: kuu = "Mai"; break;
                case 6: kuu = "Juuni"; break;
                case 7: kuu = "Juuli"; break;
                case 8: kuu = "August"; break;
                case 9: kuu = "September"; break;
                case 10: kuu = "Oktoober"; break;
                case 11: kuu = "Novemberr"; break;
                case 12: kuu = "Detsember"; break;
                default:
                    kuu = "Viga";
                    break;
            }
            return kuu;
        }
        public static string Hooaeg(int kuu_nr)
        {
            string hoo = "";
            if (kuu_nr == 1 || kuu_nr == 2 || kuu_nr == 12) // && - and, || - or
            {
                hoo = "Talv";
            }
            else if (kuu_nr > 2 && kuu_nr < 6)
            {
                hoo = "Kevad";
            }
            else if (kuu_nr > 5 && kuu_nr < 9)
            {
                hoo = "Suvi";
            }
            else if (kuu_nr > 8 && kuu_nr < 12)
            {
                hoo = "Kevad";
            }
            else
            {
                hoo = "Viga";
            }
            return hoo;
        }
        public static string Pilet(int vanus)
        {
            string pilet = "";
            if (vanus < 6 && vanus > 1)
            {
                pilet = "Tasuta";
            }
            else if (vanus > 5 && vanus < 15)
            {
                pilet = "Lastepilet";
            }
            else if (vanus > 14 && vanus < 66)
            {
                pilet = "Täispilet";
            }
            else if (vanus > 65 && vanus < 100)
            {
                pilet = "Sooduspilet";
            }
            else
            {
                pilet = "Viga andmetega";
            }
            return pilet;
        }
        public static string Nimi(string nimi, string nimi2)
        {
            string nimi_ = "";
            if (nimi.ToLower() == "sasha" && nimi2.ToLower() == "mariia" || nimi.ToLower() == "mariia" && nimi2.ToLower() == "sasha")
            {
                nimi_ = "Te olete täna pinginaabrid.";
            }
            else
            {
                nimi_ = "Te ei ole täna pinginaabrid.";
            }
            return nimi_;

        }
        public static float Pind(float arv1, float arv2)
        {
            float pild = arv1 * arv2;
            return pild;
        }
        public static float Hind(float m, float p)
        {
            float hind = m * p;
            return hind;
        }
        public static float Summa(float arv)
        {
            float summa = arv / 0.7f;
            return summa;
        }
        public static string Temperatuut(float arv)
        {
            string a = "";
            if (arv > 18)
            {
                a = "Temperatuur on ruumi jaoks liiga kõrge.";
            }
            else
            {
                a = "Temperatuur on korras.";
            }
            return a;
        }
        public static string Pikk (float arv)
        {
            string b = "";
            if (arv < 160)
            {
                b = "Olete lühike.";
            }
            else if (arv >= 160 && arv <= 180)
            {
                b = "Teie pikkus on keskmine.";
            }
            else
            {
                b = "Olete pikk.";
            }
            return b;
        }
        public static string Sugu( string d)
        {
            string b = "";
            if (d.ToLower() == "mees")
            {
                b = "Sinu on sugu mees.";
            }
            else
            {
                b= "Sinu on sugu naine.";
            }
            return b;
        }
        public static string Pikk_naine(float arv)
        {
            string b = "";
            if (arv < 160)
            {
                b = "Olete lühike.";
            }
            else if (arv >= 160 && arv <= 175)
            {
                b = "Teie pikkus on keskmine.";
            }
            else
            {
                b = "Olete pikk.";
            }
            return b;
        }
        public static float Hind (float m , int  kogus, float l, int kogus2, float s, int kogus3)
        {
            float hind = m * kogus + l * kogus2 + s * kogus3;
            return hind;
        }
    }
}
