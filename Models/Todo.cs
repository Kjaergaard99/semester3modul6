using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace semester3modul6.Models
{
    public class Todo
    {
        public Todo (User user, string titel)
        {
            this.User = user;
            this.Titel = titel;
        }
        public Todo(string titel)
        {
            this.Titel = titel;
        }   
        public User? User { get; set; }
        public long TodoId { get; set; }
        public string? Titel { get; set; }
    }
}
