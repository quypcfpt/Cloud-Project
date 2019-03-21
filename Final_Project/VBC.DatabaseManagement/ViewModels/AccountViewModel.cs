using System;
using System.Collections.Generic;
using System.Text;

namespace VBC.DatabaseManagement.ViewModels
{
    public class AccountViewModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public string AvartarUrl { get; set; }
        public int? Status { get; set; }

    }

    public class AccountEditViewModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string RoleId { get; set; }
        public string AvartarUrl { get; set; }
    }

    public class ChangePasswordViewModel
    {
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmNewPassword { get; set; }
    }
}
