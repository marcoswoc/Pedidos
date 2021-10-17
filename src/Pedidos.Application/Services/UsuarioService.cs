using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Pedidos.Application.Exceptions;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Models.Usuario;
using Pedidos.Application.Security;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IOptions<JwtOptions> _jwtOptions;
        private readonly IMapper _mapper;

        public UsuarioService(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IOptions<JwtOptions> jwtOptions,
            IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtOptions = jwtOptions;
            _mapper = mapper;
        }

        public async Task<IdentityResult> CreateAsync(UsuarioDto model)
        {
            var user = _mapper.Map<IdentityUser>(model);
            var resultado = await _userManager.CreateAsync(user, model.Password);

            return resultado;
        }

        public async Task<TokenDto> LoginAsync(LoginDto model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName);
            ValidarLoginAsync(await _signInManager.CheckPasswordSignInAsync(user, model.Password, false));

            return GerarTokenAsync(user);
        }

        private void ValidarLoginAsync(SignInResult signIn)
        {
            if (signIn?.Succeeded == true) return;

            throw new CoreException("Login ou senha inválido.");
        }

        private TokenDto GerarTokenAsync(IdentityUser usuario)
        {
            var handler = new JwtSecurityTokenHandler();
            var securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_jwtOptions.Value.SecretKey));

            var tokenDescriptor = handler.CreateToken(new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, usuario.UserName)
                }),
                Expires = DateTime.UtcNow.AddSeconds(_jwtOptions.Value.ExpirySeconds),
                SigningCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature)
            });

            return new TokenDto
            {
                Token = handler.WriteToken(tokenDescriptor),
                Result = true,
            };
        }
    }
}
