using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfPersonelDal : GenericRepository<Personel>, IPersonelDal
    {
        public List<Personel> GetListWithLocation()
        {
            using (var c = new Context())
            {
                return c.Personels.Include(x => x.Location).Include(y => y.User).Include(z => z.Project).Include(a => a.Shift).ToList();
                //Include methodu kullanarak include edeceğimiz entityleri yazdık.
            }

        }
    }
}
