using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes
{
    class Toode
    {
        string nimi;
        string ribakood;
        int laoseis;
        double hind;
        Varv varv;
        Suurus suurus;

        public Toode(string uusNimi, int uusLaoseis, string uusRibakood, double uusHind, Varv uusVarv, Suurus uusSuurus)
        {
            nimi = uusNimi;
            ribakood = uusRibakood;
            hind = uusHind;
            varv = uusVarv;
            suurus = uusSuurus;
            laoseis = uusLaoseis;

        }

        public string KusiNime()
        {
            return nimi;
        }

        public string KusiRibakoodi()
        {
            return ribakood;
        } 

    }
}
