﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    //扩展 DbContext 基类
    public class MusicStoreEntities : DbContext
    {
        public MusicStoreEntities() : base("name=MusicStoreEntities")
        {
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }
    }
}