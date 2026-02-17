using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusPrototype
{
    public class MusicComposition : Composition //, IMyCloneable<MusicComposition>
    {        
        public int Mark { get; set; }
        public Genre Genre { get; set; }
        public DateTime BeginDate { get; set; }

        public MusicComposition(int id, string title, Duration duration,
                                int mark, DateTime beginDate, Genre genre) 
            : base(id, title, duration)
        {
            this.Mark = mark;
            this.BeginDate = beginDate;
            this.Genre = genre;
        }

        public new MusicComposition ShallowCopy()
        {
            return (MusicComposition)this.MemberwiseClone();
        }

        public new MusicComposition DeepClone()
        {
            var clone = new MusicComposition(Id, Title, new Duration(Duration), Mark, BeginDate, new Genre(Genre));

            return clone;
        }
        public new object Clone()
        {
            return DeepClone();
        }
    }

}
