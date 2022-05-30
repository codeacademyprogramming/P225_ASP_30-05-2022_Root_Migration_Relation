using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P22530052022V1.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Student> Students { get; set; }
    }
}
