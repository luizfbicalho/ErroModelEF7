using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Model.Configuracao;
using Model.Models;

namespace TesteErro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str = "Server=.\\SQL2019;Initial Catalog=sadi2;Persist Security Info=False;User ID=sa;Password=sa!2019;MultipleActiveResultSets=True;Encrypt=False;TrustServerCertificate=False;Connection Timeout=30;";
            var optionsBuilder = new DbContextOptionsBuilder<ModelContext>().UseLazyLoadingProxies()
    .UseSqlServer(str);

            using (var context = new ModelContext(optionsBuilder.Options))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var emp = new Empreendimento { Praca = new Praca() };
                context.Add(emp);
                context.Add(emp.Praca);
                context.SaveChanges();
            }

            using (var context = new ModelContext(optionsBuilder.Options))
            {
                var emps = context.Empreendimento.ToList();
            }

        }
    }
}