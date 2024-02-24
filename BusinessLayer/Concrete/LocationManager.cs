using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class LocationManager : ILocationService
    {
        ILocationDal _locationDal;

        public LocationManager(ILocationDal locationDal) //constructor
        {
            _locationDal = locationDal;
        }

        public void TAdd(Location t)
        {
            _locationDal.Insert(t);
        }

        public void TDelete(Location t)
        {
            _locationDal.Delete(t);
        }

        public Location TGetByID(int id)
        {
            return _locationDal.GetByID(id);
        }

        public List<Location> TGetList()
        {
            return _locationDal.GetList();
            
        }

        public void TUpdate(Location t)
        {
            _locationDal.Update(t);
        }
    }
}
