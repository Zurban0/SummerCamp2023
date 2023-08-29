namespace CityInfoAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger(); //Prepara la doc
                app.UseSwaggerUI(); //Genera la doc
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(e =>
            {
                e.MapControllers();
            });

            app.Run();
        }
    }
}