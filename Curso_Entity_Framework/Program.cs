using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Curso_Entity_Framework;


            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();
        app.MapGet("/", () => "Hello World");

            app.MapGet("/dbconexion", async ([FromServices] TareasContext dbContext) =>
                {
                    dbContext.Database.EnsureCreated();
                    return Results.Ok("Base de datos en memoria" + dbContext.Database.IsInMemory());
                });

            app.Run();
