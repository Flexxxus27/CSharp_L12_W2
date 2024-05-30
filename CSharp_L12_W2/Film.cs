using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_L12_W2
{
    public class Film : IFilm
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
    }
}
