using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL
{
    public class MC : Køretøj
    {

        public override string Nummerplade { get; set; }
        public override bool Brobizz { get; set; }
        public int McPriserKr = 210;

        public MC(string nummerplade,bool brobizz,DateTime Dato, bool turøresund, bool turstorebælt) : base(nummerplade,brobizz,Dato,turøresund,turstorebælt)
        {
            this.Nummerplade = nummerplade;
        }

        public override int PrisStorebælt()
        {
            if (Brobizz)
            {
                //Console.WriteLine("Du har Brobizz, og for 5% i rabat! ");
                //return 125 - (125 / 100 * 5);
                Console.WriteLine("Du har brobizz så prísen er fast 73 for Motorcykler,-");
                return 73;

            }
            return McPriserKr;
        }

        public override string KøretøjType()
        {
            return "Øresund MC";
        }

        //public override int Pris()
        //{
        //    return 50;
        //}

        public override int PrisStoreBælt()
        {
            if (KøretøjType().Contains("Bil"))
            {
                Console.WriteLine("Øresund Bil");
                return 410;
            }
            if (KøretøjType().Contains("Bil") && Brobizz)
            {
                Console.WriteLine("Øresund Bil med Brobizz");
                return 161;
            }
            if (KøretøjType().Contains("MC") && Brobizz)
            {
                Console.WriteLine("Øresund MC med Brobizz");
                return 73;

            }
            Console.WriteLine("Øresund MC");
            return 210;
        }

        // Inden arv

        //public string Nummerplade { get; set; }
        //public DateTime dato;

        //public MC(string nummerplade)
        //{
        //    this.Nummerplade = nummerplade;
        //}

        //public int Pris()
        //{
        //    return 125;
        //}

        //public string Køretøj()
        //{
        //    return "MC";
        //}


    }
}

//Kommentar