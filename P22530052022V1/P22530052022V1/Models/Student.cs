using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P22530052022V1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public byte Age { get; set; }

        //Foreign Key
        public int GroupId { get; set; }
        //reference object
        public Group Group { get; set; }
    }
}
