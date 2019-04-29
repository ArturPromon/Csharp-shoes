using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes
{
    class Program
    {
        public static void Main(string[] args)
        {

            Suurus S = new Suurus("S");
            Suurus M = new Suurus("M");
            Suurus L = new Suurus("L");
            Varv valge = new Varv("valge", "#ffffff");
            Varv must = new Varv("must", "#000000");
            Varv sinine = new Varv("sinine", "#0000ff");

            Toode toode1 = new Toode("Nike", "123456", 0, 79.99, valge, M);
            Toode toode2 = new Toode("Adidas", "987654", 4, 65.99, must, S);
            Toode toode3 = new Toode("Puma", "101010", 2, 19.99, sinine, L);

            Ladu ladu = new Ladu("Tallinn");
            ladu.Lisa(toode1);
            ladu.Lisa(toode2);
            ladu.Lisa(toode3);

            // -----

            string sisestus;

            Console.WriteLine("Sisesta ribakood tootele, mis asub laos " + ladu.KusiNime() + ":");
            sisestus = Console.ReadLine();
            Toode leitudToode = ladu.ToodeRibakoodiJargi(sisestus);

            if (leitudToode == null)
            {
                Console.WriteLine("Toode ei leitud!");
            }
            else
            {
                Console.WriteLine("Leidnud toode " + leitudToode.KusiNime());
            }

            Console.WriteLine("Sisesta soobiv suurus: ");
            sisestus = Console.ReadLine();
            Suurus uusSuurus = new Suurus(sisestus);
            string Suurus = uusSuurus.Suurus();

            if (Suurus == null)
            {
                Console.WriteLine("Suurust ei leitud!");
            }
            else
            {
                Console.WriteLine("Suurus " + uusSuurus.KusiNime() + " on teise sõnaga " + Suurus + ".");
            }

            Console.ReadLine();

        }
    }
}
