using System;
using XGames.Domain.Arguments.Jogador;

namespace XGames.Domain.Interfaces.Repositories
{
    public class IRepositoryJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);
        Guid AdicionarJogador(AdicionarJogadorRequest request);
    }
}