using System;
using System.Collections;

namespace databaseAccessLayer.Interfaces
{
    public interface IPOIRepository
    {
        void AddPOI(pointOfInterest poi);
        void EditPOI(pointOfInterest poi);
        void DeletePOI(Guid Id);
        IEnumerable GetPOIs();
        pointOfInterest GetById(Guid Id);

    }
}
