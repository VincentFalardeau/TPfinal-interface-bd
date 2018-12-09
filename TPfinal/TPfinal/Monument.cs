using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPfinal
{
    public class Monument
    {
        public int IdMonument { get; set; }
        public string Nom { get; set; }
        public DateTime DateConstruction { get; set; }
        public string Histoire { get; set; }
        public string Image { get; set; }
        public decimal Prix { get; set; }
        public int Etoiles { get; set; }
    }
}
