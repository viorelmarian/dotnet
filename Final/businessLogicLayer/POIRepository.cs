using System;
using System.Collections;
using databaseAccessLayer;
using databaseAccessLayer.Interfaces;

namespace businessLogicLayer
{
    class POIRepository : IPOIRepository
    {
        pointOfInterestContext context = new pointOfInterestContext();

        public void AddPOI(pointOfInterest poi)
        {
            context.pointsOfInterest.Add(poi);
            context.SaveChanges();
        }

        public void DeletePOI(Guid Id)
        {
            pointOfInterest poi = (pointOfInterest)context.pointsOfInterest.Find(Id);
            context.pointsOfInterest.Remove(poi);
            context.SaveChanges();
        }

        public void EditPOI(pointOfInterest poi)
        {
            context.Entry(poi).State = System.Data.Entity.EntityState.Modified;
        }

        public pointOfInterest GetById(Guid Id)
        {
            return (pointOfInterest)context.pointsOfInterest.Find(Id);
        }

        public IEnumerable GetPOIs()
        {
            return context.pointsOfInterest;
        }
    }
}
