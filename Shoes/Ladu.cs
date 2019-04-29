using System;
using System.Collections.Generic;

namespace Shoes
{
    class Ladu
    {
        string nimi;
        List<Toode> tooted = new List<Toode>();

        public Ladu(string uusNimi)
        {
            nimi = uusNimi;
        }

        public void Lisa(Toode toode)
        {
            tooted.Add(toode);
        }

        public void Eemalda(Toode toode)
        {
            tooted.Remove(toode);
        }

        public Toode ToodeRibakoodiJargi(string ribakood)
        {
            foreach (Toode toode in tooted)
            {
                if (toode.KusiRibakoodi() == ribakood)
                {
                    return toode;
                }
            }
            return null;
        }

        public string KusiNime()
        {
            return nimi;
        }

    }

}
