using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_11_26
{
    internal class Auto
    {
        private List<(Szemely Szemely, DateTime Kezdet, DateTime Vege)> Tulajdonosok = [];
        public string Rendszam { get; set; }
        public string Gyarto { get; set; }
        public string Modell { get; set; }
        public int Teljesitmeny { get; set; }
        public int Terfogat { get; set; }
        public int Fogyasztas { get; set; }


        public string GetTulajdonosok()
        {
            string result = string.Empty;
            foreach (var t in Tulajdonosok)
            {
                result += $"{t.Szemely}\n {t.Kezdet: yy-MM-dd}-{t.Vege:yy-MM-dd}\n";
            }
            return result;
        }
        public void AddnewTulajdonos(Szemely szemely, DateTime kezdet, DateTime vege)
        {
            Tulajdonosok.Add((szemely, kezdet, vege));
        }

        public override string ToString() =>
            $"Rendszám: {Rendszam}, Gyártó: {Gyarto}, Modell: {Modell}" +
            $" Teljesítmény: {Teljesitmeny}hp, Térfogat: {Terfogat}cc, Fogyasztás: {Fogyasztas}mpg";
        public Auto(string rendszam, string gyarto, string modell, int teljesitmeny, int terfogat, int fogyasztas)
        {
            Rendszam = rendszam;
            Gyarto = gyarto;
            Modell = modell;
            Teljesitmeny = teljesitmeny;
            Terfogat = terfogat;
            Fogyasztas = fogyasztas;
        }
    }

}
