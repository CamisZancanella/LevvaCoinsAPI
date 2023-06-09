using LevvaCoins.Domain.Enums;
using LevvaCoins.Logic.Dto;

namespace LevvaCoins.Domain.Models
{
    public class Transacao 
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public TipoTransacaoEnum Tipo { get; set; }
        public int CategotiaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public int UsuarioId { get; set; }
        public virtual UsuarioDto Usuario { get; set; }
    }
}
