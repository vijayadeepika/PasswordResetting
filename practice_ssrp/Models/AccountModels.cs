using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace practice_ssrp.Models
{
    public class LoginModel
    {
        [Key]
        public int LoginId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Rememberme { get; set; }
    }
    public class usercontext:DbContext
    {
     public usercontext() : base("str") { }
    public    DbSet<LoginModel> logins { get; set; }

        //public System.Data.Entity.DbSet<practice_ssrp.Models.LoginModel> LoginModels { get; set; }
    }
}