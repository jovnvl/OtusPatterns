using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OtusPrototype
{
    public class PopularComposition : MusicComposition //, IMyCloneable<PopularComposition>
    {
        public string Author { get; set; }
        public DateTime CreateDate { get; set; }
        public Style Style { get; set; }

        public PopularComposition(int id, string title, Duration duration, 
                                  int mark, DateTime beginDate, Genre genre,
                                  string author, DateTime createDate, Style style)
            : base(id, title, duration,
                  mark, beginDate, genre)
        {
            Author = author;
            CreateDate = createDate;
            Style = style;
        }

        public new PopularComposition ShallowCopy()
        {
            return (PopularComposition)this.MemberwiseClone();
        }

        public new PopularComposition DeepClone()
        {
            var clone = new PopularComposition(Id, Title, new Duration(Duration), Mark, BeginDate, new Genre(Genre), Author, CreateDate, new Style(Style));         

            return clone;
        }

        public new object Clone()
        {
            return DeepClone();
        }
    }

}
