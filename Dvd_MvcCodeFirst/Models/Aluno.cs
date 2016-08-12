using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Dvd_MvcCodeFirst.Models
{
    public class Aluno
    {
        [Key]
        public int IDAluno { get; set; }

        [DisplayName("Professor")]
        public int IDProfessor { get; set; }

        [Required(ErrorMessage ="O nome é obrigaório")]
        [MaxLength(50), MinLength(5)]
        public string NomeAluno { get; set; }

        [Required(ErrorMessage ="Digite o email")]
        [StringLength(250)]
        public string Email { get; set; }

        [Range(1980, 2020, ErrorMessage ="O ano deverá ser entre 1980 e 2020")]
        public int Ano { get; set; }

        public bool Aprovado { get; set; }
        public DateTime Inscrição { get; set; }

        // lazy loading = add virtual
        public virtual Professor Professor { get; set; }
    
    }
}