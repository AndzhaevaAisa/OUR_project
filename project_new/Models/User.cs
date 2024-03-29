﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

//модель пользователя - класс User
namespace project_new.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }
        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
        public virtual ICollection<IdentityUserToken<string>> Tokens { get; set; }
        public virtual ICollection<IdentityUserRole<string>> UserRoles { get; set; }
    }
}
