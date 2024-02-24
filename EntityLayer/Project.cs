using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }

        public string ProjectName { get; set; }

        public int StatusID { get; set; }

        public DateTime CreatedDate { get; set; }


        public List<Personel> Personels { get; set; }
    }
}
