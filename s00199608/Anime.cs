using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s00199608
{
    public class Anime
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string ReleaseDate{ get; set; }
        public string Genre { get; set; }
        public int Count { get; set; }



        public Anime(string name, string description, DateTime releaseDate, string image, string genre, int count)
        {
            Name = name;
            Description = description;
            ReleaseDate = releaseDate.ToString("d");
            Image = image;
            Genre = genre;
            Count = count;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
