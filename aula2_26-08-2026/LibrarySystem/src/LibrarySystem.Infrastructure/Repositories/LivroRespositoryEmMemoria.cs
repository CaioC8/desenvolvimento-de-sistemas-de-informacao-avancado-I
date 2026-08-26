using LibrarySystem.Domain.Entities;
using LibrarySystem.Domain.Enums;
using LibrarySystem.Domain.Interfaces;

namespace LibrarySystem.Infrastructure.Repositories;

public class LivroRepository : ILivroRepository
{
    private readonly List<Livro> _livros = new();

    public void Adicionar(Livro livro)
    {
        _livros.Add(livro);
    }

    public IEnumerable<Livro> ObterTodos() => _livros;

    public IEnumerable<Livro> ObterPorCategoria(CategoriaLivro categoria)
    {
        return _livros.Where(l => l.Categoria == categoria);
    }
}