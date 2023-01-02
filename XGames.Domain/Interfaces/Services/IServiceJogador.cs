using System;
using XGames.Domain.Arguments.Jogador;

namespace XGames.Domain.Interfaces.Services
{
    public interface IServiceJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);
        AdicionarJogadorRequest AdicionarJogador(AdicionarJogadorRequest request);
    }
}