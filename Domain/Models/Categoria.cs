using LevvaCoins.Logic.Dto;

namespace LevvaCoins.Domain.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public virtual List<TransacaoDto> Transacoes { get; set; }
    }
}
