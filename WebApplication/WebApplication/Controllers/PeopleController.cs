using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    /// <summary>
    /// People Information
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();
        PeopleController()
        {
            people.Add(new Person { Id = 1, FirstName = "Uzumaki", LastName = "Naruto" });
            people.Add(new Person { Id = 2, FirstName = "Monkey D.", LastName = "Luffy" });
            people.Add(new Person { Id = 3, FirstName = "Light", LastName = "Yagami" });
        }

        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// List of FirstName of all Users
        /// </summary>
        /// <param name="userid">a unique identifier</param>
        /// <param name="age">age of the user</param>
        /// <returns>firstname of users</returns>
        [Route("api/People/GetFirstNames/{userid:int}/{age:int}")]      //override default route
        [HttpGet]
        public List<string> GetPeopleByFirstName(int userid, int age)
        {
            List<string> output = new List<string>();
            foreach (var p in people)
                output.Add(p.FirstName);

            return output;
        }

        // POST: api/People
        public void Post(Person person)
        {
            people.Add(person);
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
