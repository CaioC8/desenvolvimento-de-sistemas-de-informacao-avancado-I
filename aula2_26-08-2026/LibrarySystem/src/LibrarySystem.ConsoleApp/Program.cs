using LibrarySystem.Application;
using LibrarySystem.Application.Services;
using LibrarySystem.Domain.Entities;
using LibrarySystem.Domain.Enums;
using LibrarySystem.Domain.Interfaces;
using LibrarySystem.Domain.Services;
using LibrarySystem.Infrastructure;
using LibrarySystem.Infrastructure.Repositories;
using LibrarySystem.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();

serviceCollection.AddInfrastructure().AddApplication();

var serviceProvider = serviceCollection.BuildServiceProvider();

var appService = serviceProvider.GetRequiredService<LivroAppService>();

Console.WriteLine("=== SISTEMA DE GERENCIAMENTO BIBLIOTECARIO ===");

appService.CadastrarNovoLivro("Dom Quixote", "Pafuncio", "alds", CategoriaLivro.Historia, 50.00m);
appService.CadastrarNovoLivro("SW", "Beltrano", "alqw9ts", CategoriaLivro.Ficcao, 20.00m);
appService.CadastrarNovoLivro("Clean Code", "Fulano", "sgfads", CategoriaLivro.Tecnologia, 15.00m);

foreach(var livro in appService.ListarAcervo())
{
    Console.Write($"[OK] Cadastrado: {livro.Titulo} - R$ {livro.Preco}\n");
}


// var biblioteca = new BibliotecaService();

// var l1 = new Livro("Dom Quixote", "Pafuncio", "alds", 
// CategoriaLivro.Historia, 50.00m);
// var l2 = new Livro("SW", "Beltrano", "alqw9ts", 
// CategoriaLivro.Ficcao, 20.00m);
// var l3 = new Livro("Clean Code", "Fulano", "sgfads", 
// CategoriaLivro.Tecnologia, 15.00m);

// biblioteca.AdicionarLivro(l1);
// biblioteca.AdicionarLivro(l2);
// biblioteca.AdicionarLivro(l3);

// l1.Alugar();

// Console.WriteLine("\n--- Livros de Tecnologia ---");
// foreach (var livro in biblioteca.BuscarPorCategoria(CategoriaLivro.Tecnologia))
// {
//     Console.WriteLine($"- {livro.Titulo} ({livro.Autor}) | R$ {livro.Preco}");
// }

// Console.WriteLine("\n--- Livros disponiveis ---");
// foreach (var livro in biblioteca.ObterDisponiveis())
// {
//     Console.WriteLine($"- {livro.Titulo} ({livro.Autor}) | R$ {livro.Preco}");
// }

// Console.WriteLine("\n--- Valor total ---\n" + biblioteca.ObterValorTotalAcervo());