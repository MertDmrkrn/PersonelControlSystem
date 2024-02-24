using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }

        public string JobDescription { get; set; }

        public int StatusID { get; set; }

        public DateTime Date { get; set; }

        public DateTime CreatedDate { get; set; }


        //Konum ilişkisi
        public int LocationID { get; set; }

        public Location Location { get; set; }


        //Kullanıcı ilişkisi
        public int UserID { get; set; }

        public User User { get; set; }


        //Vardiya ilişkisi
        public int ShiftID { get; set; }

        public Shift Shift { get; set; }


        //Proje ilişkisi
        public int ProjectID { get; set; }

        public Project Project { get; set; }
    }
}
