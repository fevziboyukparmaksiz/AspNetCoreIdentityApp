﻿namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class UserViewModel
    {
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string? PictureUrl { get; set; }
    }
}
