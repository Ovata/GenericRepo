using GenericRepository.Data;
using GenericRepository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.Repo
{
    public class ActorsRepository : CoreRepository<Actors, GenericRepositoryContext>
    {
        public ActorsRepository(GenericRepositoryContext context) : base(context)
        {
        }
    }
}
