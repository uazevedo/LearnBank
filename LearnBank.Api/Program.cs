
using LearnBank.Application.Common.Interfaces.Persistence;
using LearnBank.Application.Features.Users.CreateUser;
using LearnBank.Application.Features.Users.ListUsers;
using LearnBank.Persistence;

namespace LearnBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            builder.Services.AddSingleton<IUserRepository, InMemoryUserRepository>();
            builder.Services.AddScoped<CreateUserHandler>();
            builder.Services.AddScoped<ListUsersHandler>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
