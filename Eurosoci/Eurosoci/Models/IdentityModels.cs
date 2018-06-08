using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Eurosoci.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("EuroSociDbConnectionString", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        // definir as 'tabelas' da minha base de dados
        public virtual DbSet<Jogadores> Jogadores { get; set; }
        public virtual DbSet<Sociedades> Sociedades { get; set; }
        public virtual DbSet<Pagamentos> Pagamentos { get; set; }
        public virtual DbSet<Apostas> Apostas { get; set; }
        public virtual DbSet<Concursos> Concursos { get; set; }
        public virtual DbSet<Chaves> Chaves { get; set; }
        public virtual DbSet<Numeros> Numeros { get; set; }
        public virtual DbSet<Jog_Soc> Jog_Socs { get; set; }
        public virtual DbSet<TipoChaves> TipoChaves { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}