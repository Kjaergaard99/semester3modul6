using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace semester3modul6.Models
{
    public class User
    {
        public User(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public long UserId { get; set; }
    }
}
