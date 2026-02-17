using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace OtusPrototype
{
    public class Composition : IMyCloneable<Composition>, ICloneable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Duration Duration { get; set; }
        public Composition(int id, string title, Duration duration)
        {
            Id = id;
            Title = title;
            Duration = duration;
        }
        public Composition ShallowCopy()
        {
            return (Composition)this.MemberwiseClone();
        }

        public Composition DeepClone()
        {
            var clone = new Composition(Id, Title, new Duration(Duration));

            return clone;
        }

        public object Clone()
        { 
            return DeepClone();
        }
    }
}
