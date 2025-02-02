﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GenericRepository.Entities;

namespace GenericRepository.Data
{
    public class GenericRepositoryContext : DbContext
    {
        public GenericRepositoryContext (DbContextOptions<GenericRepositoryContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Actors> Actors { get; set; }
    }
}
