﻿using DemoWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoWebAPI.Controllers
{
    /// <summary>
    /// This is where I give you all the information aboyt my peeps. 
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Enriquez", Id = 2 });
            people.Add(new Person { FirstName = "Adan", LastName = "Y", Id = 3 });
            people.Add(new Person { FirstName = "Efrain", LastName = "Z", Id = 4 });
            people.Add(new Person { FirstName = "Franck", LastName = "A", Id = 5 });
            people.Add(new Person { FirstName = "Melvin", LastName = "B", Id = 6 });
        }

        /// <summary>
        /// Gets a list of the first names of all users.
        /// </summary>
        /// <param name="userId">The unique identifier for this persona.</param>
        /// <param name="age">We want to know how old they are.</param>
        /// <returns>A list of first names...</returns>
        [Route("api/People/GetFirstNames/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstNames(int userId, int age)
        {
            List<string> output = new List<string>();

            foreach (var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
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

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
            
        }
    }
}
