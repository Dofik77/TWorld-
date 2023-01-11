using System.ComponentModel.DataAnnotations;

namespace TWorld_Project.Model
{
    public class UserInfo
    {
        //Display don't work on view
      
        public string User_Name { get; set; }

        
        public string User_Email { get; set; }

    
        public string Phone_Number { get; set; }

   
        public string User_City { get; set; }


        public string About_User { get; set; }
    }
}
