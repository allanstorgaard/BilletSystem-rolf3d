﻿using System;
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

        public MC(string nummerplade,bool brobizz,DateTime Dato) : base(nummerplade,brobizz,Dato)
        {
            this.Nummerplade = nummerplade;
        }

        public override int Pris()
        {
            if (Brobizz)
            {
                Console.WriteLine("Du har Brobizz, og for 5% i rabat! ");
                return 125 - (125 / 100 * 5);
               
            }
            return 125;
        }

        public override string KøretøjType()
        {
            return "MC";
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
