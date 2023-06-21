using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class OtherParamUser : ParamUser
    {
        public string UserName { get; set; }
        //public bool SeniorManager { get; set; } = false;
        [Required]
        public enumRole Role { get; set; }
    }
}
