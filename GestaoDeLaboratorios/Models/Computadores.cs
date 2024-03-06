using System.ComponentModel.DataAnnotations;

namespace GestaoDeLaboratorios.Models
{
    public class Computadores
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Marca { get; set;}
        [Required]
        public string Processador { get; set;}
        [Required]
        public string PlacaMae { get; set;}
        public int Memoria { get; set;}
        public int HD { get; set;}
        [Required]
        public int NumeroPratrimonio { get; set; }
        public string DataDeCompra { get; set; }

    }
}
