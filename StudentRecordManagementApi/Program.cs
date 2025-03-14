namespace StudentRecordManagementApi
{
    using Microsoft.EntityFrameworkCore;
    using StudentRecordManagementApi.Data;

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

            builder.Services.AddDbContext<StudentContext>(options =>
    options.UseSqlite("Data Source=Students.db"));

            var app = builder.Build();

            if (app.Environment.IsDevelopment())  // Configure the HTTP request pipeline.
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
