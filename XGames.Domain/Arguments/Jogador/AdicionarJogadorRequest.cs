using XGames.Domain.Entities.ValueObjects;

namespace XGames.Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest
    {
        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public string Senha { get; set; }
    }
}