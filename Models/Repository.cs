using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        //el ile bazı kayıtları yaptım
        static Repository(){
            _users.Add(new UserInfo() {Name = "Kotan", Email = "kotan@gmail.com", Phone = "12121112" , WillAttend = true});
            _users.Add(new UserInfo() {Name = "Selamet", Email = "selamet@gmail.com", Phone = "12121112" , WillAttend = true});
            _users.Add(new UserInfo() {Name = "Atahan", Email = "atahan@gmail.com", Phone = "12121112" , WillAttend = false});
        }
        
        //bilgilerin gönderilmesi
        public static List<UserInfo> Users{
            get{
                return _users;
            }
        }

        //yeni kayıtları ekleme
        public static void CreatUser(UserInfo user){
            _users.Add(user);
        }
    }
}