using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GenericRepository.Data;
using GenericRepository.Entities;
using GenericRepository.Repo;

namespace GenericRepository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : Genericontroller<Movie, MovieRepository>
    {
        public MoviesController(GenericRepositoryContext context) : base(context)
        {
        }
    }
}
