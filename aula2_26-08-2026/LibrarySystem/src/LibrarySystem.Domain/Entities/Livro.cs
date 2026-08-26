using LibrarySystem.Domain.Enums;

namespace LibrarySystem.Domain.Entities;

public class Livro
{
    public Guid Id { get; private set; }
    public string Titulo { get; private set; }
    public string Autor { get; private set; }
    public string Isbn { get; private set; }
    public bool Disponivel { get; private set; }
    public decimal Preco { get; private set; }
    public CategoriaLivro Categoria { get; private set; }

    public Livro (string titulo, string autor, string isbn,
    CategoriaLivro categoria, decimal preco)
    {
        Id = Guid.NewGuid();
        Titulo = titulo;
        Autor = autor;
        Isbn = isbn;
        Categoria = categoria;
        Preco = preco;
        Disponivel = true;
    }

    public void Alugar()
    {
        if (!Disponivel) throw 
        new InvalidOperationException("O livro já está alugado!");

        Disponivel = false;
    }

    public void Devolver()
    {
        Disponivel = true;
    }
}