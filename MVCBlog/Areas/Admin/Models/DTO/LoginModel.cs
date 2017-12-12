using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBlog.Areas.Admin.Models.DTO
{
    public class LoginModel
    {
        [Required(ErrorMessage = "EMail girilmek zorundadır")]
        [DataType(DataType.EmailAddress,ErrorMessage ="EMail formatı hatalı!")]
        public string EMail { get; set; }
        [Required(ErrorMessage ="Parola girilmek zorundadır")]
        public string Password { get; set; }
    }
}