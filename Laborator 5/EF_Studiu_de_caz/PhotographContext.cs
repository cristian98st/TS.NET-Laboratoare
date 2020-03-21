namespace EF_Studiu_de_caz
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PhotographContext : DbContext
    {
        public virtual DbSet<Photograph> Photographs { get; set; }
        public virtual DbSet<PhotographFullImage> PhotographFullImages { get; set; }

        public PhotographContext()
            : base("name=PhotographContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Photograph>()
            .HasRequired(p => p.PhotographFullImage)
            .WithRequiredPrincipal(p => p.Photograph);
            modelBuilder.Entity<Photograph>()
            .ToTable("Photograph", "BazaDeDate");
            modelBuilder.Entity<PhotographFullImage>()
            .ToTable("Photograph", "BazaDeDate");
        }

    }
}