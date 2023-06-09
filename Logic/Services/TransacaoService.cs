using AutoMapper;
using LevvaCoins.Data.Interfaces;
using LevvaCoins.Domain.Models;
using LevvaCoins.Logic.Dto;
using LevvaCoins.Logic.Interfaces;

namespace LevvaCoins.Logic.Services
{
    public class TransacaoService : ITransacaoService
    {
        private readonly ITransacaoRepository _repository;
        private readonly IMapper _mapper;
        public TransacaoService(ITransacaoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Create(TransacaoDto transacao)
        {
            var _transacao = _mapper.Map<Transacao>(transacao);
            _repository.Create(_transacao);

        }

        public void Delete(int Id)
        {
            _repository.Delete(Id);
        }

        public TransacaoDto Get(int Id)
        {
            var transacao = _mapper.Map<TransacaoDto>(_repository.Get(Id));
            return transacao;
        }

        public List<TransacaoDto> GetAll()
        {
            var transacaos = _mapper.Map<List<TransacaoDto>>(_repository.GetAll());
            return transacaos;
        }

        public void Update(TransacaoDto transacao)
        {
            var _transacao = _mapper.Map<Transacao>(transacao);
            _repository.Update(_transacao);


        }
    }
}
