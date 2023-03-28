using Newtonsoft.Json;
using PedjaTutorial.Models;

namespace PedjaTutorial.Services
{
    public class AuthorService
    {
        public List<Author> GetAllAuthorsFromJson()
        {
            List<Author> items;

            using (StreamReader r = new StreamReader("file.json"))
            {
                string json = r.ReadToEnd();
                 items = JsonConvert.DeserializeObject<List<Author>>(json);
            }

            return items;
        }

        public List<Author> GetAll()
        {
            List<Author> authors = new List<Author>();
            authors.Add(new Author
            {
                Name = "Predrag Arsic",
                UniqueIndentifier = "123123132"
            });

            return authors;
        }
    }
}