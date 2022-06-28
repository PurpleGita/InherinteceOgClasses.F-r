using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InherinteceOgClasses;

namespace InherinteceOgClasses
{
    internal class Program
    {
        //main static void, som køre en gang når programmet starter, her fra kalder vi metoderne og udskiver fårne 
        static void Main(string[] args)
        {
            var Får1 = new RiddeFår();
            var Får2 = new RiddeFår();
            var Får3 = new FarmFår();
            var Får4 = new FarmFår();
            var Får5 = new FarmFår();
            List<Får> Fårlist = new List<Får>();

            Tools.SetFår(Fårlist , Får1 , "Mikkel" , 4 , "UldFår" , 15 , "Jhon", 5);
            Tools.SetFår(Fårlist, Får2, "Sara", 5, "StortFår", 16, "Rasmus", 6);
            Tools.SetFår(Fårlist, Får3, "Silja", 3, "UldFår", 4, "Det Grønne");
            Tools.SetFår(Fårlist, Får4, "Daniel", 4, "StortFår", 3, "Dank");
            Tools.SetFår(Fårlist, Får5, "Juel", 4,"BrilleFår",3, "Får");

            Console.WriteLine("klik på en tast for at printe Får");
            Console.ReadKey();
            Console.Clear();


            Tools.PrintFår(Fårlist);

            Console.ReadKey();


        }

    }


}
