using EfCrud.Data;
using EfCrud.Entities;
using Microsoft.EntityFrameworkCore;



#region Criação
var category = new Category(0, "Categoria 1", "categoria-1", "Descrição da Categoria 1");

using var context = new AppDbContext();

await context.Categories.AddAsync(category);

await context.SaveChangesAsync();
#endregion

#region Leitura
var categories = await context.Categories.ToListAsync();


foreach (var item in categories)
{
    Console.WriteLine($"Id: {item.Id}, Titulo:{item.Title}, SubTitulo:{item.Slug}, Descrição:{item.Description}");
}

var cat = await context.Categories.FirstOrDefaultAsync(x => x.Id == 3);

Console.WriteLine($"Id: {cat.Id}, Titulo:{cat.Title}, SubTitulo:{cat.Slug}, Descrição:{cat.Description}");
#endregion

#region Atualizar
cat.Title = "Novo Titulo";

context.Categories.Update(cat);

await context.SaveChangesAsync();

Console.WriteLine($"Id: {cat.Id}, Titulo:{cat.Title}, SubTitulo:{cat.Slug}, Descrição:{cat.Description}");
#endregion

#region Deletar

context.Categories.Remove(cat);

context.SaveChanges();
#endregion

Console.ReadLine();