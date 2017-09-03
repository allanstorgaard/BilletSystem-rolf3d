﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystemDLL
{
    public class Bil : Køretøj , IWeekendRabat
    {

        public override string Nummerplade { get; set; }
        public override bool Brobizz { get; set; }

       

        //public string Nummerplade { get; set; }
        //public DateTime Dato;

        public Bil(string nummerplade,bool brobizz,DateTime Dato): base(nummerplade,brobizz,Dato)
        {
            this.Nummerplade = nummerplade;
            
        }

        public override int Pris()
        {
            
            if (Brobizz)
            {
                Console.WriteLine("Du har Brobizz, og for 5% i rabat! ");
                return 240 - (240 / 100 * 5);
            }
            else
            {
                return 240;
            }


            
        }

        public override string KøretøjType()
        {
            return "Bil";
        }


        //public int Pris()
        //{
        //    return 240;
        //}

        //public string Køretøj()
        //{
        //    return "Bil";
        //}

        public override string ToString()
        {
            return this.Brobizz.ToString() + Nummerplade.ToString();
        }

        /// <summary>
        /// Til interface
        /// </summary>
        public int WeekendRabat { get; set; }
        public int WeekendRabatter()
        {
            List<DayOfWeek> RabatDage = new List<DayOfWeek>() { DayOfWeek.Saturday, DayOfWeek.Sunday };

            if (RabatDage.Contains(DayOfWeek.Saturday) || RabatDage.Contains(DayOfWeek.Sunday))
            {
                Console.WriteLine("Du for rabat fordi det er weekend! ");
                if (Brobizz)
                {
                    return 240 - (240 / 100 * 5) - (240/100 * 20);
                }
                return 240 - (240 / 100 * 20);

            }
            return 240;

        }
    }
}
