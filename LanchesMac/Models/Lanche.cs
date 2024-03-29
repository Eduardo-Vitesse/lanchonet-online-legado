﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "Informe o nome do lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]
        [Display(Name = "Nome do lanche")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a descrição do lanche")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        [Display(Name = "Descrição do lanche")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "Informe a descrição detalhada do lanche")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        [Display(Name = "Descrição detalhada do lanche")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe a descrição detalhada do lanche")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999.99")]
        [Display(Name = "Preço")]
        public decimal preco { get; set; }

        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        [Display(Name = "Caminho imagem normal")]
        public string ImagemUrl { get; set; }

        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        [Display(Name = "Caminho imagem miniatura")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool isLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        // Relacionamento
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
