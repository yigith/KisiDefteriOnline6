using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiDefteriOnline6
{
    public class Kisi
    {
        public string Ad { get; set; } = "";

        public string Soyad { get; set; } = "";

        public string TamAd => $"{Ad} {Soyad}";

        public override string ToString()
        {
            return $"Kişi ({Ad} {Soyad})";
        }
    }
}
