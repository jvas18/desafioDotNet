using Microsoft.EntityFrameworkCore;
using Desafio.API.Model;
namespace Desafio.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Doctor> Doctors {get; set;} 
        public DbSet<Patient> Patients {get; set;}
    }
}