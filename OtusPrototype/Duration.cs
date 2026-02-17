using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusPrototype
{
    public class Duration
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Duration(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Duration(Duration duration)
        {
            Id = duration.Id;
            Name = duration.Name;           
        }
    }
}
