using LibrarySystem.Application;
using LibrarySystem.Application.Services;
using LibrarySystem.Domain.Entities;
using LibrarySystem.Domain.Enums;
using LibrarySystem.Domain.Interfaces;
using LibrarySystem.Domain.Services;
using LibrarySystem.Infrastructure;
using LibrarySystem.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();

serviceCollection
    .AddInfrastructure()
    .AddApplication();

var serviceProvider = serviceCollection.BuildServiceProvider();

var appService = serviceProvider.GetRequiredService<LivroAppService>();

Console.WriteLine("=== SISTEMA DE REESTRUTURADO EM CAMADAS ===");

appService.CadastrarNovoLivro("Dom Quixote", "Pafuncio", "alds", 
CategoriaLivro.Historia, 50.00m);
appService.CadastrarNovoLivro("SW", "Beltrano", "alqw9ts", 
CategoriaLivro.Ficcao, 20.00m);
appService.CadastrarNovoLivro("Clean Code", "Fulano", "sgfads", 
CategoriaLivro.Tecnologia, 15.00m);

foreach(var livro in appService.ListarAcervo())
{
    Console.WriteLine(
        $"[OK] Cadastrado: {livro.Titulo} - R$ {livro.Preco}");
}