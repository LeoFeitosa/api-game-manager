using XGames.Domain.Interfaces.Services;
using XGames.Domain.Interfaces.Repositories;
using System;

namespace XGames.Domain.Services
{
    public class ServiceJogador : IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                throw new Exception("AutenticarJogadorRequest e obrigatório");
            }

            if (string.IsNullOrEmpty(request.Email))
            {
                throw new Exception("Informe um email");
            }

            if (IsEmail(request.Email))
            {
                throw new Exception("Informe um email");
            }

            if (string.IsNullOrEmpty(request.Senha))
            {
                throw new Exception("Informe uma senha");
            }

            if (request.Senha.Length < 6)
            {
                throw new Exception("Digite uma senha de no mínimo 6 caracteres");
            }

            var response = _repositoryJogador.AutenticarJogador(request);
            return response;
        }

        public AdicionarJogadorRequest AdicionarJogador(AdicionarJogadorRequest request)
        {
            Guid id = _repositoryJogador.AdicionarJogador(request);
            return new AdicionarJogadorRequest(Id = id, Message = "Operação realizada com sucesso");
        }

        private bool IsEmail(string email)
        {
            return false;
        }
    }
}