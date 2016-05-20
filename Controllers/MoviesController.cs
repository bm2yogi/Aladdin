using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aladdin.Models;

namespace Aladdin.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        // GET api/movies
        [HttpGet]
        public ObjectResult Get()
        {
            return Ok(
            new [] {
                new Movie {Id = 42, Name="Ghostbusters", Rating="PG-13"},
                new Movie {Id = 43, Name="Star Wars: A New Hope", Rating="PG"},
                new Movie {Id = 44, Name="Raiders of the Lost Ark", Rating="PG"}
            });
        }
        
        // GET api/movies
        [HttpGet]
        [Route("{id:int}")]
        public ObjectResult Get(int id)
        {
            return Ok(new Movie {Id = id, Name="Ghostbusters", Rating="PG-13"});
        }
    }
}
