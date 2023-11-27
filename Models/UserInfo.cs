using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        /*
            bu kısmı formdan gelen bilgileri taghelper ile alıp kullanmak 
        */
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public bool? WillAttend { get; set; }
    }
}