using LevvaCoins.Logic.Dto;

namespace LevvaCoins.Logic.Interfaces
{
    public interface ICategoriaService
    {
        void Create(CategoriaDto categoria);
        CategoriaDto Get(int Id);
        List<CategoriaDto> GetAll();
        void Update(CategoriaDto categoria);
        void Delete(int Id);
    }
}
