using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace plantitas.Models
{
    [Table("t_fails")]
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID {get; set;}

        [Required(ErrorMessage = "Por favor ingrese Titulo del Fail")]
        [Display(Name="Titulo Producto")]
        public String Titulo {get; set;}

        [Required(ErrorMessage = "Please enter Nombre")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "Please enter Image Name")]
        public String ImagenName { get; set; }

        [Required(ErrorMessage = "Please enter Due Date")]
        public DateTime DueDate { get; set; }

        [Required(ErrorMessage = "Please enter Status")]
        public String Status { get; set; }

        public virtual ICollection<Proforma> ProformaItems { get; set; }

    }
}