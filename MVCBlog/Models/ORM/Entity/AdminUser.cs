using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBlog.Models.ORM.Entity
{
    public class AdminUser : BaseEntity
    {
        [Required(ErrorMessage ="E-mail boş geçilemez")]
        [DataType(DataType.EmailAddress,ErrorMessage ="E-mail adresi uygun değildir")]
        public string EMail { get; set; }

        [Required(ErrorMessage = "E-mail boş geçilemez")]
        public string Password { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
    }
}