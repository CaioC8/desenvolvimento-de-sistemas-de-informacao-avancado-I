using LibrarySystem.Domain.Entities;
using LibrarySystem.Domain.Enums;

namespace LibrarySystem.Domain.Interfaces;

public interface ILivroRepository
{
    void Adicionar(Livro livro);

    IEnumerable<Livro> ObterTodos();

    IEnumerable<Livro> ObterPorCategoria(CategoriaLivro categoria);
}