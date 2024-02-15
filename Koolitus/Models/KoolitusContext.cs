﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace Koolitus.Models
{
    public class KoolitusContext : DbContext
    {
        public DbSet<koolitused> Koolituss { get; set; }
        public DbSet <Laps> Lapss { get; set; }
        public DbSet<Opetaja> Opetajas { get; set; }
    }
}