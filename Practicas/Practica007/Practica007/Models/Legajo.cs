using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica007.Models
{
    public class Legajo
    {
        public int NUMEROLEGAJO { get; set; }
        public int DNI { get; set; }
        public string APELLIDONOMBRE { get; set; }
        public string FECHADECARGA { get; set; }

        public Legajo(int NUMEROLEGAJO, int DNI, string APELLIDONOMBRE, string FECHADECARGA)
        {
            this.NUMEROLEGAJO = NUMEROLEGAJO;
            this.DNI = DNI;
            this.APELLIDONOMBRE = APELLIDONOMBRE;
            this.FECHADECARGA = FECHADECARGA;
            

        }
    }
}