using LibrarySystem.Domain.Entities;
using LibrarySystem.Domain.Enums;
using LibrarySystem.Domain.Services;

Console.WriteLine("=== SISTEMA DE GERENCIAMENTO BIBLIOTECARIO ===");

var biblioteca = new BibliotecaService();

var l1 = new Livro("Dom Quixote", "Pafuncio", "alds", 
CategoriaLivro.Historia, 50.00m);
var l2 = new Livro("SW", "Beltrano", "alqw9ts", 
CategoriaLivro.Ficcao, 20.00m);
var l3 = new Livro("Clean Code", "Fulano", "sgfads", 
CategoriaLivro.Tecnologia, 15.00m);

biblioteca.AdicionarLivro(l1);
biblioteca.AdicionarLivro(l2);
biblioteca.AdicionarLivro(l3);

l1.Alugar();

Console.WriteLine("\n--- Livros de Tecnologia ---");
foreach (var livro in biblioteca.BuscarPorCategoria(CategoriaLivro.Tecnologia))
{
    Console.WriteLine($"- {livro.Titulo} ({livro.Autor}) | R$ {livro.Preco}");
}

Console.WriteLine("\n--- Livros disponiveis ---");
foreach (var livro in biblioteca.ObterDisponiveis())
{
    Console.WriteLine($"- {livro.Titulo} ({livro.Autor}) | R$ {livro.Preco}");
}

Console.WriteLine("\n--- Valor total ---\n" + biblioteca.ObterValorTotalAcervo());