using LevvaCoins.Domain.Enums;

namespace LevvaCoins.Logic.Dto
{
    public class TransacaoDto 
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public TipoTransacaoEnum Tipo { get; set; }
        public int CategotiaId { get; set; }
        //public virtual CategoriaDto? Categoria { get; set; }
        public int UsuarioId { get; set; }
        //public virtual UsuarioDto? Usuario { get; set; }
    }
}
