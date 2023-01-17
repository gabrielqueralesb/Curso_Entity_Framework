using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Curso_Entity_Framework;

        var builder = WebApplication.CreateBuilder(args);
        //builder.Services.AddDbContext<TareasContext>(p => p.UseInMemoryDatabase("TareasDB"));
        //builder.Services.AddSqlServer<TareasContext>("Data Source=NB0288\\SQLEXPRESS;Initial Catalog= TareasDb;Trusted_Connection=True; Integrated Security=True"); //"Data Source= NB0288\\SQLEXPRESS;Initial Catalog=TareasDb;user id=sa;Password=1234"
        builder.Services.AddSqlServer<TareasContext>("Data Source= NB0288\\SQLEXPRESS;Initial Catalog=TareasDb;user id=sa;Password=1234");

var app = builder.Build();
        app.MapGet("/", () => "Hello World");

            app.MapGet("/dbconexion", async ([FromServices] TareasContext dbContext) =>
                {
                    dbContext.Database.EnsureCreated();
                    return Results.Ok("Base de datos en memoria: " + dbContext.Database.IsInMemory());
                });

            app.Run();
