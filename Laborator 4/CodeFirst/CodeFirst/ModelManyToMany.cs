namespace CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class ModelManyToMany : DbContext
    {
        public ModelManyToMany()
            : base("name=ModelManyToMany")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Album>()
                .HasMany(a => a.Artists)
                .WithMany(a => a.Albums)
                .Map(m =>
                {
                    m.ToTable("AlbumArtist");
                    m.MapLeftKey("AlbumId");
                    m.MapRightKey("ArtistId");
                });
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
    }

    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public ICollection<Artist> Artists { get; set; }
    }

    public class Artist
    {
        public int ArtistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}