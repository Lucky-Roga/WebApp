using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class ParamUser
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}


/* {
  "email": "admin@gmail.com",
  "password": "123!Admin",
  "userName": "ADMIN",
  "role": 0
}


 {
  "email": "user@gmail.com",
  "password": "123!User",
  "userName": "USER",
  "role": 1
}

 {
  "email": "user1@gmail.com",
  "password": "123!User1",
  "userName": "USER_1",
  "role": 1
}

 */