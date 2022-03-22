using System.ComponentModel.DataAnnotations;

namespace LivrariaAPI.Models
{
    public class Livro
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public string Categoria { get; set; }
        public string Img { get; set; }
    }
}
