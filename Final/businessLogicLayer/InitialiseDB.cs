using System.Data.Entity;
using databaseAccessLayer;

namespace businessLogicLayer
{
    class InitialiseDB : DropCreateDatabaseIfModelChanges<pointOfInterestContext>
    {
        protected override void Seed(pointOfInterestContext context)
        {
            context.pointsOfInterest.Add(new pointOfInterest { Name = "First POI", Description = "First POI from a list of POIs" });
            context.pointsOfInterest.Add(new pointOfInterest { Name = "Second POI", Description = "Second POI from a list of POIs" });
            context.pointsOfInterest.Add(new pointOfInterest { Name = "Third POI", Description = "Third POI from a list of POIs" });
            context.pointsOfInterest.Add(new pointOfInterest { Name = "Forth POI", Description = "Forth POI from a list of POIs" });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
