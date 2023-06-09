using LevvaCoins.Domain.Models;
using LevvaCoins.Logic.Dto;

namespace LevvaCoins.Data.Interfaces
{
    public interface ITransacaoRepository
    {
        void Create(Transacao transacao);
        Transacao Get(int Id);
        List<Transacao> GetAll();
        void Update(Transacao transacao);
        void Delete(int Id);
        //void Create(Transacao transacao);
    }
}
