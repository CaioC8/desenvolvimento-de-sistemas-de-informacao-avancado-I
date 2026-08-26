using LibrarySystem.Domain.Entities;
using LibrarySystem.Domain.Enums;

namespace LibrarySystem.Domain.Services;

public class BibliotecaService
{
    private readonly List<Livro> _livros = new();

    public void AdicionarLivro(Livro livro)
    {
        _livros.Add(livro);
    }

    public IEnumerable<Livro> ObterTodos() => _livros;

    //LINQ
    public IEnumerable<Livro> ObterDisponiveis()
    {
        return _livros.Where(l => l.Disponivel).ToList();
    }
    
    public IEnumerable<Livro> BuscarPorCategoria(CategoriaLivro categoria)
    {
        return _livros.Where(l => l.Categoria == categoria).ToList();
    }
    
    public decimal ObterValorTotalAcervo()
    {
        return _livros.Sum(l => l.Preco);
    }
}