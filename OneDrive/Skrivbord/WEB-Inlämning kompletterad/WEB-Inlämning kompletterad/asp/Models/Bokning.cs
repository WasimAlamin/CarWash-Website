using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class Bokning
    {

        public  int Id { get; set; }

        public string Tvättprogram { get; set; }
        public string Namn { get; set; }

        public string Email { get; set; }

        public int Telefon { get; set; }

        public int Tid { get; set; }

        public string Datum { get; set; }
    }
}
