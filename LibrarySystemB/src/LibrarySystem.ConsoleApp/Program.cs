using LibrarySystem.Application;
using LibrarySystem.Application.Services;
using LibrarySystem.Domain.Enums;
using LibrarySystem.Infrastructure;
using LibrarySystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();

string connectionString = "Host=localhost;Port=5432;Database=librarydb;Username=postgres;Password=Aluno123";

serviceCollection.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));

serviceCollection
    .AddInfrastructure()
    .AddApplication();

var serviceProvider = serviceCollection.BuildServiceProvider();

var appService = serviceProvider.GetRequiredService<LivroAppService>();

Console.WriteLine("=== SISTEMA DE REESTRUTURADO EM CAMADAS ===");

appService.CadastrarNovoLivro("Dom Quixote", Guid.NewGuid(), "alds", 
CategoriaLivro.Historia, 50.00m);
appService.CadastrarNovoLivro("SW", Guid.NewGuid(), "alqw9ts", 
CategoriaLivro.Ficcao, 20.00m);
appService.CadastrarNovoLivro("Clean Code", Guid.NewGuid(), "sgfads", 
CategoriaLivro.Tecnologia, 15.00m);

foreach(var livro in appService.ListarAcervo())
{
    Console.WriteLine(
        $"[OK] Cadastrado: {livro.Titulo} - R$ {livro.Preco}");
}