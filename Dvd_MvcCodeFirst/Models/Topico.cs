using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Dvd_MvcCodeFirst.Models
{
    public class Topico
    {
        [Key]
        public int IDtopico { get; set; }

        [DisplayName("Professor")]
        public int IDProfessor { get; set; }

        [Required(ErrorMessage ="Digite o tópico")]
        [MaxLength(100), MinLength(5)]
        public string Descricao { get; set; }

        // lazy loading = add virtual
        public virtual Professor Professor { get; set; }
    }
}