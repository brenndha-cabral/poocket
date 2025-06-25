using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poocket.Models
{
    public class ModulesApp
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public ModulesApp(
            string id,
            string name
        )
        {
            Id = id;
            Name = name;

        }
    }
}