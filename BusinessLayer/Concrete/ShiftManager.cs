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
    public class ShiftManager : IShiftService
    {
        IShiftDal _shiftDal;

        public ShiftManager(IShiftDal shiftDal)//constructor
        {
            _shiftDal = shiftDal;
        }

        public void TAdd(Shift t)
        {
            _shiftDal.Insert(t);
        }

        public void TDelete(Shift t)
        {
            _shiftDal.Delete(t);
        }

        public Shift TGetByID(int id)
        {
            return _shiftDal.GetByID(id);
        }

        public List<Shift> TGetList()
        {
            return _shiftDal.GetList();
        }

        public void TUpdate(Shift t)
        {
            _shiftDal.Update(t);
        }
    }
}
