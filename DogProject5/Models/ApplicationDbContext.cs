﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DogProject5.Models;

namespace infinite.mvc.dogstore.test.Models
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext() : base("MyCon")
        {

        }
        //table mapping
        public DbSet<DogStore> DogStores { get; set; }

        public DbSet<Breed> Breeds { get; set; }

        //public DbSet<PetBreedMapping> PetBreedMappings {get;set;}

    }
}