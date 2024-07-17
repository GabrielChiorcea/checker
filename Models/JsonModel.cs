using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checker.Models
{
    public class JsonModel {public string? message { get; set; }}
    public class EmailModel {public string? email { get; set; }}
    public class UserNameModel {public string? username { get; set; }}
    
    public class UserAndEmailModel {
        public string Email { get; set; } = "";
        public string Username { get; set; } = "";
    
    }

    public class SignUpResponseModel { 
        public string Code { get; set; }
        public string Message { get; set; }
    }
}