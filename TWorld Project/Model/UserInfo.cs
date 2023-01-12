using System.ComponentModel.DataAnnotations;

namespace TWorld_Project.Model
{
    public class UserInfo
    {
        //Display don't work on view
        //Validation will be added later


        public string UserName { get; set; }

        
        public string UserMail { get; set; }

    
        public string PhoneNumber { get; set; }

   
        public string UserCity { get; set; }


        public string AboutUser { get; set; }
    }
}
