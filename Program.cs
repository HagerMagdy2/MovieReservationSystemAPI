
using MovieReservationSystemAPI.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;


using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
namespace MovieReservationSystemAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

           
           
         

            builder.Services.AddControllers();
            #region Connection DB
            builder.Services.AddDbContext<MovieSystemContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefautCon"));
            });
            #endregion

            builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<MovieSystemContext>();

            #region Authantication 
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(op =>
            {
                op.SaveToken = true;
                #region generate Secret Key
                string key = "hello it is a new security key to generate token using JWT";
                var securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key));
                #endregion
                op.TokenValidationParameters = new TokenValidationParameters()
                {
                    IssuerSigningKey = securityKey,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                };

            });
            #endregion

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
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
