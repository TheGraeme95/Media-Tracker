using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace MediaTrackerLibrary
{
    [Serializable]
    public class User
    {
        public string Name { get; set; }
        public List<Film> FilmCollection { get; set; }
        public List<Game> GameCollection { get; set; }
        public DateTime LastUpdated { get; set; }

        public User()
        {
            FilmCollection = new List<Film>();
            GameCollection = new List<Game>();
        }

        public User(string _name)
        {
            Name = _name;
            FilmCollection = new List<Film>();
            GameCollection = new List<Game>();

            Console.WriteLine("User {0} initiated", Name);
        }

        public void Load()
        {
            string filePath = Directory.GetCurrentDirectory();

            try
            {
                string filmFile = "\\" + Name + " Film.bin";
                string finalInput = filePath + filmFile;

                using (Stream stream = File.Open(finalInput, FileMode.Open))
                {
                    BinaryFormatter input = new BinaryFormatter();
                    FilmCollection = (List<Film>)input.Deserialize(stream);

                }
                Console.WriteLine("Successfully loaded films");
            }

            catch (IOException e)
            {
                Console.WriteLine("Cannot load film file : {0}", e);
            }

            try
            {
                string gameFile = Name + " Game.bin";
                string finalInput = filePath + gameFile;

                using (Stream stream = File.Open(finalInput, FileMode.Open))
                {
                    BinaryFormatter input = new BinaryFormatter();
                    GameCollection = (List<Game>)input.Deserialize(stream);

                }
                Console.WriteLine("Successfully loaded games");
            }

            catch (IOException e)
            {
                Console.WriteLine("Cannot load game file : {0}", e);
            }
        }

        public void Save()
        {
            string filePath = Directory.GetCurrentDirectory();

            try
            {
                
                string filmFile = "\\" + Name + " Film.bin";

                string finalOutput = filePath + filmFile;

                using (Stream stream = File.Open(finalOutput, FileMode.Create))
                {
                    BinaryFormatter output = new BinaryFormatter();
                    output.Serialize(stream, FilmCollection);
                }
                Console.WriteLine("Successfully saved films");
            }

            catch (IOException e)
            {
                Console.WriteLine("Cannot save film file : {0}", e);
            }
            
            try
            {

                string gameFile = "\\" + Name + " Game.bin";
                string finalOutput = filePath + gameFile;

                using (Stream stream = File.Open(finalOutput, FileMode.Create))
                {
                    BinaryFormatter output = new BinaryFormatter();
                    output.Serialize(stream, FilmCollection);
                }
                Console.WriteLine("Successfully saved games");
            }

            catch (IOException e)
            {
                Console.WriteLine("Cannot save game file : {0}", e);
            }
            
        }

        public void Add(Film film)
        {
            film.ID = FilmCollection.Count;
            FilmCollection.Add(film);
        }

        public void Add(Game game)
        {
            game.ID = GameCollection.Count;
            GameCollection.Add(game);
        }

        public void RemoveFilm(int filmID)
        {
            FilmCollection.RemoveAll(s => s.ID == filmID);

            foreach (var film in this.FilmCollection)
            {
                film.ID = FilmCollection.IndexOf(film);
            }
        }

        public void RemoveGame(int gameID)
        {
            GameCollection.RemoveAll(s => s.ID == gameID);

            foreach (var game in this.GameCollection)
            {
                game.ID = GameCollection.IndexOf(game);
            }
        }

        public void printFilms()
        {
            foreach (var film in this.FilmCollection)
            {
                Console.WriteLine(film.ID);
                Console.WriteLine(film.Title);
                Console.WriteLine(film.Rating);
            }
        }

        public void printGames()
        {
            foreach (var game in GameCollection)
            {
                Console.WriteLine(game.ID);
                Console.WriteLine(game.Title);
                Console.WriteLine(game.Rating);
            }
        }
    }

}




