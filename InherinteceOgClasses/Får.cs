using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InherinteceOgClasses;

namespace InherinteceOgClasses
{

    //den overordnet Får class
    public class Får
    {
        public int FårVægt { get; set; }
        public string FårNavn { get; set; }
        public string FårRace { get; set; }

        public virtual string CheckGed()
        {
            return FårRace;
        }


    }






}
