using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_App_Movijuntos.Models
{
    [Table("Fotos")]
    public class Foto
    {
        [Key]
        public int IdFoto { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a descrição")]
        [DataType(DataType.Upload)]
        public string urlFoto { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a avaliação")]
        [Display(Name = "Avaliação")]
        public int IdAvaliacao { get; set; }

        [ForeignKey("IdAvaliacao")]
        public Avaliacao Avaliacao { get; set; }
    }

}