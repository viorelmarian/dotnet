using System.Data.Entity;

namespace businessLogicLayer
{
    public class pointOfInterestContext : DbContext
    {
        public DbSet pointsOfInterest { get; set; }

        public System.Data.Entity.DbSet<databaseAccessLayer.pointOfInterest> pointOfInterests { get; set; }
    }
}
