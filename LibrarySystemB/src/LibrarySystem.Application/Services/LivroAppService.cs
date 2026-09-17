using LibrarySystem.Domain.Entities;
using LibrarySystem.Domain.Enums;
using LibrarySystem.Domain.Interfaces;

namespace LibrarySystem.Application.Services;

public class LivroAppService
{
    private readonly ILivroRepository _repository;

    public LivroAppService(ILivroRepository repository)
    {
        _repository = repository;
    }

    public void CadastrarNovoLivro(string titulo, Guid autorId,
     string isbn, CategoriaLivro categoria, decimal preco)
    {
        var livro = new Livro(titulo, autorId, isbn, categoria, preco);
        _repository.Adicionar(livro);
    }

    public IEnumerable<Livro> ListarAcervo()
    {
        return _repository.ObterTodos();
    }
}