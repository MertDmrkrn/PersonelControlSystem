 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }

        public string LocationName { get; set; }

        public int StatusID { get; set; }

        public DateTime CreatedDate { get; set; }

        public List<Personel> Personels { get; set; }
    }
}
