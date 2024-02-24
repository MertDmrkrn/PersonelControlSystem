using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Adress { get; set; }

        public DateTime LastSignInDate { get; set; }

        public DateTime LastSignOutDate { get; set; }

        public int UserCreationTypeID { get; set; }

        public int UserTypeID { get; set; }

        public int Supervisor { get; set; }

        public int StatusID { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public Byte isLogin { get; set; }

        public int CompanyID { get; set; }

        public string IdentificationNumber { get; set; }


        public List<Personel> Personels { get; set; }
    }
}
