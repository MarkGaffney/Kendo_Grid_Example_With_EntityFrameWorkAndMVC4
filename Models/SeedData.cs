using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace KendoUI.Models
{
    public class SeedData : DropCreateDatabaseIfModelChanges<MicropowerMembersEntities>
    //public class SeedData : DropCreateDatabaseAlways<MicropowerMembersEntities>
    {

        protected override void Seed(MicropowerMembersEntities context)
        {


            new List<ContactModel>
            {
               new ContactModel {   LastName = "Gaffney", FirstName = "Mark",  OverEighteen=true,  Salary=20000 , DOB = new System.DateTime(1976,12,25)},
               new ContactModel {   LastName = "Blow", FirstName = "Joe" ,  OverEighteen=true , Salary=30000, DOB = new System.DateTime(1976,12,25) },
               new ContactModel {   LastName = "Tam", FirstName = "Tim" ,  OverEighteen=true , Salary=40000, DOB = new System.DateTime(1976,12,25) },
               new ContactModel {   LastName = "Jones", FirstName = "Tom" ,  OverEighteen=false, Salary=60 , DOB = new System.DateTime(1976,12,25)},
               new ContactModel {   LastName = "Mickey", FirstName = "Mouse",  OverEighteen=true , Salary=80, DOB = new System.DateTime(1976,12,25)  },
               new ContactModel {   LastName = "Mandy", FirstName = "Jones" ,  OverEighteen=true, Salary=0, DOB = new System.DateTime(1976,12,25) },
               new ContactModel {   LastName = "Sarah", FirstName = "Wason" ,  OverEighteen=true, Salary=0 , DOB = new System.DateTime(1976,12,25) },
               new ContactModel {   LastName = "Bill", FirstName = "Smith" ,  OverEighteen=false, Salary=0 , DOB = new System.DateTime(1976,12,25)},
               new ContactModel {   LastName = "Karen", FirstName = "Smith",  OverEighteen=false, Salary=0 , DOB = new System.DateTime(1976,12,25)  },
               new ContactModel {   LastName = "Bob", FirstName = "Marley",  OverEighteen=true, Salary=0  , DOB = new System.DateTime(1976,12,25) },
               new ContactModel {   LastName = "Tom", FirstName = "Preston",  OverEighteen=true, Salary=0 , DOB = new System.DateTime(1976,12,25) },
               new ContactModel {   LastName = "Tony", FirstName = "Jones" ,  OverEighteen=true, Salary=0 , DOB = new System.DateTime(1976,12,25) },
               new ContactModel {   LastName = "Watson", FirstName = "Hulie" ,  OverEighteen=true, Salary=0, DOB = new System.DateTime(1976,12,25)  },
              
              }.ForEach(a => context.Contacts.Add(a));






        }





    }
}