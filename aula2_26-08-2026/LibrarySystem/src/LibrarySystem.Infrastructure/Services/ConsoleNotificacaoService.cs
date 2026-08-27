using LibrarySystem.Domain.Interfaces;

namespace LibrarySystem.Infrastructure.Services;

public class ConsoleNotificacaoService : IServicoNotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.Write(mensagem);
    }
}