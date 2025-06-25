using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poocket.Models
{
    public class App
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public App(
            int id,
            string name
        )
        {
            Id = id;
            Name = name;

        }
    }
}