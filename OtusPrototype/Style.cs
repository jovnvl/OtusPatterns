using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusPrototype
{
    public class Style
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Style(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Style(Style style)
        {
            Id = style.Id;
            Name = style.Name;
        }
    }
}
