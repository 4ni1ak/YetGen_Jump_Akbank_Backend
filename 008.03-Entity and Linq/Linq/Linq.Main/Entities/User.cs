using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Main.Entities
{
    internal class User
    {
        public User(string nickname, int follower)
        {
            Nickname = nickname;
            Follower = follower;
        }

        public string Nickname { get; set; }
        public int Follower { get; set; }
    }
}
