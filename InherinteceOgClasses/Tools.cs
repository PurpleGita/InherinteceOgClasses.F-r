using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherinteceOgClasses
{
    internal class Tools
    {
        //metode med 2 overloads til at tage imod de 2 forskelige type Får typer der er.
        public static void SetFår(List<Får> Fårlist, RiddeFår FårObjekt, string fårnavn, int fårvægt, string fårrace, int gåturKM, string riddernavn, int kampedystet)
        {
            FårObjekt.FårNavn = fårnavn;
            FårObjekt.FårVægt = fårvægt;
            FårObjekt.FårRace = fårrace;
            FårObjekt.GåTurKM = gåturKM;
            FårObjekt.RidderNavn = riddernavn;
            FårObjekt.KampeDystet = kampedystet;
            Fårlist.Add(FårObjekt);
        }
        public static void SetFår(List<Får> Fårlist, FarmFår FårObjekt, string fårnavn, int fårvægt, string fårrace, int antalgederkæmpetmod, string ynglingsgræs)
        {
            FårObjekt.FårNavn = fårnavn;
            FårObjekt.FårVægt = fårvægt;
            FårObjekt.FårRace = fårrace;
            FårObjekt.AntalGederKæmpetMod = antalgederkæmpetmod;
            FårObjekt.YnglingsGræs = ynglingsgræs;
            Fårlist.Add(FårObjekt);
        }

        //denne metode udprinter listen af får og alle deres properties. Den køre også CheckGed()
        public static void PrintFår(List<Får> Fårlist)
        {
            int i = 0;
            foreach (var item in Fårlist)
            {
                Fårlist[i].CheckGed();
                Console.WriteLine("");
                Console.WriteLine(Fårlist[i].FårNavn + ":");
                var props = Fårlist[i].GetType().GetProperties();
                var sb = new StringBuilder();
                foreach (var værdi in props)
                {
                    sb.AppendLine(værdi.Name + ": " + værdi.GetValue(Fårlist[i], null));
                }
                Console.WriteLine(sb.ToString());
                i++;
            }
        }

    }
}
