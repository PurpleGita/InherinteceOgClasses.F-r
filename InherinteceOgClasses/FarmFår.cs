using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherinteceOgClasses
{
    //en class af FarmFår som inherter fra Får classen
    internal class FarmFår : Får
    {
        public int AntalGederKæmpetMod { get; set; }

        public string YnglingsGræs { get; set; }

        //chekker om fårets navn er Juek og hvis det er ændre den racen til Ged 
        public override string CheckGed()
        {
            if (FårNavn == "Juel") 
            {
                FårRace = "Ged";
                return "Ged"; }
            else { return FårRace; }

        }
    }

}
