using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace exploreMostar.Model.Requests
{
   public class KorisniciInsertRequest
    {
        [Required]
        [MinLength(3)]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Telefon { get; set; }
        [Required]
        [MinLength(4)]
        public string KorisnickoIme { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation{ get; set; }
        public int? GradId { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public string PutanjaSlike { get; set; }
        public List<int> Uloge { get; set; } = new List<int>();

    }
}
