using GenericRepository.Controllers;
using GenericRepository.Data;
using GenericRepository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.Repo
{
    public class MovieRepository : CoreRepository<Movie, GenericRepositoryContext>
    {
        public MovieRepository(GenericRepositoryContext context) : base(context)
        {
        }
    }
}
