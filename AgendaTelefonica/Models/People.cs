using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendaTelefonica.Models
{
    public class People
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Dígito mínimo 4, máximo 100")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [RegularExpression(@"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$", ErrorMessage = "Número inválido")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Campo obrigatório"), MaxLength(150)]
        public string Address { get; set; }
    }
}