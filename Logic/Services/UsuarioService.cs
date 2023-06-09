using AutoMapper;
using LevvaCoins.Data.Interfaces;
using LevvaCoins.Domain.Models;
using LevvaCoins.Logic.Dto;
using LevvaCoins.Logic.Dtos;
using LevvaCoins.Logic.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LevvaCoins.Logic.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public UsuarioService(IUsuarioRepository repository, IMapper mapper, IConfiguration configuration) 
        {
            _repository = repository;
            _mapper = mapper;
            _configuration = configuration;
        }
        public void Create(UsuarioDto usuario)
        {
           var _usuario = _mapper.Map<Usuario>(usuario);
            _repository.Create(_usuario);
        }

        public void Delete(int Id)
        {
            _repository.Delete(Id);
        }

        public UsuarioDto Get(int Id)
        {
            var usuario = _mapper.Map<UsuarioDto>(_repository.Get(Id));
            return usuario;
        }

        public List<UsuarioDto> GetAll()
        {
            var usuarios = _repository.GetAll();
          return _mapper.Map<List<UsuarioDto>>(usuarios);
        }

        public void Update(UsuarioDto usuario)
        {
           var _usuario = _mapper.Map<Usuario>(usuario);
            _repository.Update(_usuario);
        }
        public LoginDto Login(LoginDto loginDto)
        {
            var usuario = _repository.GetByEmailAndSenha(loginDto.Email, loginDto.Senha);

            if (usuario == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration.GetSection("Secret").Value);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, usuario.Email)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            loginDto.Token = tokenHandler.WriteToken(token);
            loginDto.Nome = usuario.Nome;
            loginDto.Email = usuario.Email;
            loginDto.Senha = null;

            return loginDto;
        }
    }
}
