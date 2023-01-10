using System.ComponentModel.DataAnnotations;

namespace TWorld_Project.Model
{
    public class UserInfo
    {
        //Display don't work on view

        public UserInfo()
        {
            User_Name = "Stas";
            About_User = "Stats120120";
        }

        [Display(Name = "Ваше Имя")]
        [Required(ErrorMessage = "Необходимо ввести имя")]
        public string User_Name { get; set; }

        [Required(ErrorMessage = "Необходимо ввести почту")]
        [Display(Name = "Почта")]
        public string User_Email { get; set; }

        [Required(ErrorMessage = "Необходимо ввести номер телефона")]
        public string Phone_Number { get; set; }

        [Required(ErrorMessage = "Необходимо ввести город")]
        public string User_City { get; set; }

        [Required(ErrorMessage = "Необходимо ввести информацию о себе")]
        public string About_User { get; set; }
    }
}
