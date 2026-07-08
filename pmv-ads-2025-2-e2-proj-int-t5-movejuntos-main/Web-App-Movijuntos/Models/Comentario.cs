using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Web_App_Movijuntos.Models;

namespace Web_App_Movijuntos.Models

{
    [Table("Comentarios")]
    public class Comentario
{
    [Key]
    public int IdComentario { get; set; }

    [Required(ErrorMessage = "Obrigatorio informar a descrição")]
    public string Mensagem { get; set; }

    [Required(ErrorMessage = "Obrigatorio informar a avaliação")]
    [Display(Name = "Avaliação")]
    public int IdAvaliacao { get; set; }

    [ForeignKey("Id")]
    public Usuario Usuario { get; set; }

    [ForeignKey("IdAvaliacao")]
    public Avaliacao Avaliacao { get; set; }
    }

}