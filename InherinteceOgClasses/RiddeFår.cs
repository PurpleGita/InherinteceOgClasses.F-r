using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherinteceOgClasses
{
    //en classe af RiddeFår som inherter fra Får classen
    public class RiddeFår : Får
    {
        public int GåTurKM { get; set; }
        public string RidderNavn { get; set; }
        public int KampeDystet { get; set; }


    }
}
