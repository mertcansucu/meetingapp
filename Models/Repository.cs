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
            _users.Add(new UserInfo() {Id=1, Name = "Kotan", Email = "kotan@gmail.com", Phone = "12121112" , WillAttend = true});
            _users.Add(new UserInfo() {Id=2, Name = "Selamet", Email = "selamet@gmail.com", Phone = "12121112" , WillAttend = true});
            _users.Add(new UserInfo() {Id=3, Name = "Atahan", Email = "atahan@gmail.com", Phone = "12121112" , WillAttend = false});
        }
        
        //bilgilerin gönderilmesi
        public static List<UserInfo> Users{
            get{
                return _users;
            }
        }

        //yeni kayıtları ekleme
        public static void CreatUser(UserInfo user){
            user.Id = Users.Count + 1 ;
            _users.Add(user);
        }

        //listeleme bölümünde detay kısmında o kişinin bilgileri görünmesi lazım bunuda o kişinin idsi ile tutabilirim
        public static UserInfo? GetById(int id){
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}