namespace EF_Studiu_de_caz
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BusinessContext : DbContext
    {

        public virtual DbSet<Business> Businesses { get; set; }
        public BusinessContext()
            : base("name=BusinessContext")
        {
        }
    }

}