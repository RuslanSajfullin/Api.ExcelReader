using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class MyDbContext : DbContext
    { 
   public MyDbContext(DbContextOptions<MyDbContext> options)
           : base(options)
    { }

    public DbSet<MunicipalMovableEstate> MunicipalMovableEstate { get; set; }
    public DbSet<MunicipalImmovableEstate> MunicipalImmovableEstate { get; set; }

        public static MyDbContext Create(IConfiguration configuration)
    {
        var connectionstring = configuration.GetConnectionString("connectionstring");

        if (connectionstring == null)
        {
            throw new ArgumentException("Отсутствует строка подключения к базе данных");
        }

        var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
        try
        {
                //optionsBuilder.UseSqlServer(connectionstring);
                optionsBuilder.UseNpgsql(connectionstring);
            }
            catch (Exception exc)
        {
            throw new Exception(exc.Message);
        }
        return new MyDbContext(optionsBuilder.Options);
    }
}
}