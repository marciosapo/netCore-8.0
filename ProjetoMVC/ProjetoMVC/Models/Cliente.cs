using System.ComponentModel.DataAnnotations;

namespace ProjetoMVC.Models
{
    public class Cliente
    {
            [Key]
            public int Id { get; set; }
            [Required]
            public string nome { get; set; } = string.Empty;
            [Required]
            public string email { get; set; } = string.Empty;
            [Required]
            public int telefone { get; set; }
    }
}
