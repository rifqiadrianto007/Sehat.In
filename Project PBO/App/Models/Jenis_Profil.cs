using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO.App.Models
{
    public class Jenis_Profil
    {
        [Key]
        public int Id_jenis_profil { get; set; }
        [Required]
        public string nama_jenis_profil { get; set; }
    }
}
