using LibrarySystem.Application;
using LibrarySystem.Application.Services;
using LibrarySystem.Domain.Entites;
using LibrarySystem.Domain.Entities;
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

Console.WriteLine("=== SISTEMA COM EF-CORE ===");

using(var scope = serviceProvider.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    context.Database.Migrate();

    var autor = new Autor("Fulano", "Brasileiro");
    var livro = new Livro("Clean Code", autor.Id, "isbn", CategoriaLivro.Tecnologia, 130.00m);

    context.Autores.Add(autor);
    context.Livros.Add(livro);
    context.SaveChanges();

    Console.WriteLine("[SUCESSO] Dados salvos no banco");

    var livrosDoBanco = context.Livros.Include(l => l.Autor).ToList();

    foreach(var item in livrosDoBanco)
    {
        Console.WriteLine($"Livro: {item.Titulo} | Autor: {item.Autor.Nome}");
    }
}