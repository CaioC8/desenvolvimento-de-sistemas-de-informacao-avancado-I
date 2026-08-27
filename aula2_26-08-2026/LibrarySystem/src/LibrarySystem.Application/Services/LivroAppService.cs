using LibrarySystem.Domain.Entities;
using LibrarySystem.Domain.Enums;
using LibrarySystem.Domain.Interfaces;

namespace LibrarySystem.Application.Services;

public class LivroAppService
{
    private readonly ILivroRepository _repository;
    private readonly IServicoNotificacao _servicoNotificacao;

    public LivroAppService(ILivroRepository repository, IServicoNotificacao servicoNotificacao)
    {
        _repository = repository; 
        _servicoNotificacao = servicoNotificacao;
    }

    public void CadastrarNovoLivro(string titulo, string autor, string isbn, CategoriaLivro categoria, decimal preco)
    {
        var livro = new Livro(titulo, autor, isbn, categoria, preco);
        _repository.Adicionar(livro);
        _servicoNotificacao.EnviarMensagem($"Livro {titulo} cadastrado com sucesso.\n");
    }

    public IEnumerable<Livro> ListarAcervo() 
    {
        return _repository.ObterTodos();
    }
}