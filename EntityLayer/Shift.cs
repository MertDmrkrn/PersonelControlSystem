using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Shift
    {
        [Key]
        public int ShiftID { get; set; }

        public string ShiftName { get; set; }

        public int StatusID { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ShiftTime { get; set; }


        public List<Personel> Personels { get; set; }
    }
}
