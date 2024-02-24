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
    public class PersonelManager : IPersonelService
    {
        IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)//constructor
        {
            _personelDal = personelDal;
        }

        public List<Personel> GetPersonelListWithLocation()//yeni implement ettik
        {
            return _personelDal.GetListWithLocation();//yeni ekledik
        }

        public void TAdd(Personel t)
        {
            _personelDal.Insert(t);
        }

        public void TDelete(Personel t)
        {
            _personelDal.Delete(t);
        }

        public Personel TGetByID(int id)
        {
            return _personelDal.GetByID(id);
        }

        public List<Personel> TGetList()
        {
            return _personelDal.GetList();
        }

        public void TUpdate(Personel t)
        {
            _personelDal.Update(t);
        }
    }
}
