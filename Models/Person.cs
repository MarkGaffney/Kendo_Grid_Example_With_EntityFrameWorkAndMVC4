using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace KendoUI.Models
{
    public class ContactModel
    {
        public Int32? ID { get; set; }
        [DisplayName("First Name")]
        public String FirstName { get; set; } 
        [DisplayName("Surname")]
        public String LastName { get; set; }

        [DisplayName("Gender")]
        public Boolean Gender { get; set; }

        [DisplayName("IsCitizen")]
        public Boolean IsCitizen { get; set; }

         public virtual int donkey { get; set; }

        [DisplayName("DOB")]
        public DateTime DOB { get; set; }

        public Boolean OverEighteen { get; set; }
        [DisplayName("Salary")]
        public int Salary { get; set; }
        //[DisplayName("Joined")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:d}")]
        //public DateTime Joined { get; set; }
    }
}