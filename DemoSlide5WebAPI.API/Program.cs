using DemoSlide5WebAPI.API.IRepository;
using DemoSlide5WebAPI.API.IRepository.Repository;

namespace DemoSlide5WebAPI.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}