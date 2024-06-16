using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO.App.Models
{
    internal class Obat
    {
        public int IdObat { get; set; }
        public string NamaObat { get; set; }
        public string Fungsi { get; set; }
        public string Dosis { get; set; }
        public int IdJenis { get; set; }
    }
}