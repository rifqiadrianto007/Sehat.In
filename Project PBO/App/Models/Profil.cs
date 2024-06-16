using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO.App.Models
{
    public class Profil
    {
        [Key]
        public int? id_profil {  get; set; }
        [Required]
        public string nama { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string alamat {  get; set; }
        public string kota { get; set; }
        public string negara { get; set; }
        public int no_telfon {  get; set; }
        [ForeignKey("Jenis_Profil")]
        public int id_jenis_profil { get; set; }
    }
}
