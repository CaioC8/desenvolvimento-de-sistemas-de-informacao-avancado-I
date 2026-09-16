using LibrarySystem.Domain.Entities;

namespace LibrarySystem.Domain.Entites;

public class Autor
{
    public Guid Id { get; private set;}
    public string Nome { get; private set;}
    public string Nacionalidade { get; private set;}
    public readonly List<Livro> _livros = new();

    public IReadOnlyCollection<Livro> Livros => _livros.AsReadOnly();

    public Autor(string nome, string nacionalidade)
    {
        Id = Guid.NewGuid();
        Nome = nome;
        Nacionalidade = nacionalidade;
    }
}