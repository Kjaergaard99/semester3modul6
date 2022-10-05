using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semester3modul6.Models
{
    public class Board
    {
        public Board()
        {
            todos = new List<Todo>();
        }
        public List<Todo> todos { get; set; }
        public long BoardId { get; set; }
    }
}
