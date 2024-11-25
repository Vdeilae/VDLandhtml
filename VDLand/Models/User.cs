﻿using Microsoft.AspNetCore.Identity;
namespace VDLand.Models
{
    public class User:IdentityUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
    }
}
