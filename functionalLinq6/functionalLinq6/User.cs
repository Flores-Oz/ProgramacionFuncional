using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionalLinq6
{
    internal class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public int age { get; set; }
        public string gender { get; set; }

        public User(int id, string username, int age, string gender)
        {
            this.id = id;
            this.username = username;
            this.age = age;
            this.gender = gender;
        }

        public static List<User> Users()
        {
            return new List<User>
            {
                new User(1, "britney", 5, "female"),
                new User(2, "sylvio", 42, "male"),
                new User(3, "lucht", 30, "male"),
                new User(4, "thomsen", 48, "male"),
                new User(5, "diego", 30, "male"),
                new User(6, "jargensen", 55, "female"),
                new User(7, "travis", 27, "male"),
                new User(8, "gerald", 30, "male"),
                new User(9, "eduardo", 22, "male"),
                new User(10, "renata", 13, "female"),
                new User(11, "sther", 50, "female"),
            };
        }
    }
}
