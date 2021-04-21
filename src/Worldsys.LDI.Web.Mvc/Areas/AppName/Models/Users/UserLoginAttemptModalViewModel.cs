using System.Collections.Generic;
using Worldsys.LDI.Authorization.Users.Dto;

namespace Worldsys.LDI.Web.Areas.AppName.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}