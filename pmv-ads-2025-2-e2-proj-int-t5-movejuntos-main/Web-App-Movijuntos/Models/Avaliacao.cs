using Web_App_Movijuntos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_App_Movijuntos.Models
{
    [Table("Avaliacoes")]
    public class Avaliacao
    {
        [Key]
        public int IdAvaliacao { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a data")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a nota")]
        public int Nota { get; set; }

       
        [Required(ErrorMessage = "Obrigatorio informar o local")]
        [Display(Name = "Local")]
        public int IdLocal { get; set; }

        [ForeignKey("IdLocal")]
        public Local Local { get; set; }

        [ForeignKey("Id")]
        public Usuario Usuario { get; set; }


        public ICollection<Criterio> Criterios { get; set; } 
        public ICollection<Comentario> Comentarios { get; set; }
        public ICollection<Foto> Fotos { get; set; }
    }
}