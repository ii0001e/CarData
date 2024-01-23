﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarData.Core.Domain;

namespace Car.Data
{
    public class CarContext : DbContext
    {
        public CarContext
            (
            DbContextOptions<CarContext> options
            ) : base(options) { }

        public DbSet<CarData> Cars { get; set; }

    }
}
