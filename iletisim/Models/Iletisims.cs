using System.ComponentModel.DataAnnotations;

namespace Iletisim.Models
{
    public class Iletisims
    {

        [Key]
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Mail { get; set; }
        public string Mesaj { get; set; }

        public string Departman { get; set; }
        public string Telefon { get; set; }


    }
}