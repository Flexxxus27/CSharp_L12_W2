using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_L12_W2
{
    public interface IFilm
    {
        string Name { get; set; }
        int Year { get; set; }
        string Author { get; set; }
        string Genre { get; set; }
    }
}
