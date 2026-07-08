using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Web_App_Movijuntos.Models;

namespace Web_App_Movijuntos.Models
{
    [Table("Criterios")]
    public class Criterio
    {
        [Key]
        public int IdCriterio { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar se possui rampas")]
        public required bool Rampas { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar se possui corrimãos")]
        [Display(Name = "Corrimãos")]
        public required bool Corrimaos { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar se possui banheiros acessíveis")]
        [Display(Name = "Banheiros Acessíveis")]
        public required bool BanheiroAcess { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar se possui vagas de estacionamento")]
        [Display(Name = "Vagas de estacionamento")]
        public required bool VagasEstacion { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar se possui sinalização tátil")]
        [Display(Name = "Sinalização Tátil")]
        public required bool SinalizacaoTatil { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar se possui sinalização sonora")]
        [Display(Name = "Sinalização Sonora")]
        public required bool SinalizacaoSonora { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar se possui sinalização visual")]
        [Display(Name = "Sinalização Visual")]
        public required bool SinalizaçãoVisual { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar se possui caminho livre de obstáculos")]
        [Display(Name = "Caminho livre de obstáculos")]
        public required bool CaminhoLivre { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar se possui portas e coredores acessíveis")]
        [Display(Name = "Portas e corredores acessíveis")]
        public required bool PortasCorredor { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a avaliação")]
        [Display(Name = "Avaliação")]
        public int IdAvaliacao { get; set; }


        [ForeignKey("IdAvaliacao")]
        public Avaliacao Avaliacao { get; set; }
    }

}