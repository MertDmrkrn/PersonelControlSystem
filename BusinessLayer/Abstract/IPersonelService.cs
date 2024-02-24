using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPersonelService : IGenericService<Personel>
    {
        List<Personel> GetPersonelListWithLocation();//yeni ekledim
    }
}
