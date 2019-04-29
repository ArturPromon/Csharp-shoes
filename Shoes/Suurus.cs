using System;
namespace Riidepood
{
    public class Suurus
    {
        string nimi;
        public Suurus(string uusNimi)
        {
            nimi = uusNimi;
        }

        public string KusiNime()
        {
            return nimi;
        }

        public string Suurus()
        {
            switch (nimi)
            {
                case "S":
                    return "small";
                case "M":
                    return "medium";
                case "L":
                    return "large";
                default:
                    return null;
            }
        }
    }
}
