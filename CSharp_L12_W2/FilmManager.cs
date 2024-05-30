using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_L12_W2
{
    internal class FilmManager
    {
        public List<Film> films = new List<Film>(); 
        public void AddFilm(Film film) {  films.Add(film); }
        public void RemoveFilm(string name) 
        { 
            films.RemoveAll(p => p.Name == name);
        }
        public void UpdateFilm(Film film)
        {
            var ext = films.FirstOrDefault(p => p.Name == film.Name);
            if(ext != null)
            {
                ext.Name = film.Name;
                ext.Author = film.Author;
                ext.Year = film.Year;
                ext.Genre = film.Genre;
            }
        }

        public void SaveToJson(string path)
        {
            string json = JsonConvert.SerializeObject(films);
            File.WriteAllText(path, json);
        }
        public void LoadFromJson(string path)
        {
            string json = File.ReadAllText(path);
            films = JsonConvert.DeserializeObject<List<Film>>(json);
        }
        public void SaveToXml(string path)
        {
            //XElement xml = new XElement()
        }


    }
}
