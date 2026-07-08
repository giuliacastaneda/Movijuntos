
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_App_Movijuntos.Models
{
    [Table("Locais")]
    public class Local
    {
        [Key]
        public int IdLocal { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar o Nome")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o endereço")]
        [Display(Name = "Endereço")]
        public required string Endereco { get; set; }

        public  List<Avaliacao> Avaliacoes { get; set; }
        [NotMapped]
        public double NotaMedia
        {
            get
            {
                if (Avaliacoes == null || Avaliacoes.Count == 0)
                    return 0;
                return Avaliacoes.Average(a => (double)a.Nota);
            }
        }

        public ICollection<Criterio> Criterios { get; set; }

        [ForeignKey("Id")]
        public Usuario Usuario { get; set; }
    }
}