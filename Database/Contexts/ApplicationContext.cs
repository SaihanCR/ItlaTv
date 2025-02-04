using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Series> Series { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Producer> Producers { get; set; }


        //Configurar La Creacion de la BD
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region tables
            modelBuilder.Entity<Series>().ToTable("Series");
            modelBuilder.Entity<Producer>().ToTable("Productoras");
            modelBuilder.Entity<Category>().ToTable("Categorias");
            #endregion

            #region "Primary Keys"
            modelBuilder.Entity<Entities.Series>().HasKey(s => s.Id);
            modelBuilder.Entity<Category>().HasKey(c => c.Id);
            modelBuilder.Entity<Producer>().HasKey(p => p.Id);
            #endregion

            #region Relationships
            //Configurar la FK de la Categoria Principal
            modelBuilder.Entity<Entities.Series>()
                .HasOne<Category>(s => s.MainCategory)
                .WithMany(c => c.SeriesMainlist)
                .HasForeignKey(s => s.MainCategoryId)
                .IsRequired();

            //Configurar la FK Para la Categoria Secundaria
            modelBuilder.Entity<Entities.Series>()
                .HasOne<Category>(s => s.SecondaryCategory)
                .WithMany(c => c.SeriesSecondaryList)
                .HasForeignKey(s => s.SecondaryCategoryId)
                .IsRequired(false);


            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}
