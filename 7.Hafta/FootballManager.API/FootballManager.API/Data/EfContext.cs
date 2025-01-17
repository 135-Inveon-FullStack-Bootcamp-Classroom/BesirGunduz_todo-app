﻿using FootballManager.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootballManager.API.Data
{
    public class EfContext : DbContext
    {
        public EfContext(DbContextOptions<EfContext> options) : base(options)
        {

        }

        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Footballer> Footballers { get; set; }
        public DbSet<ManagementPosition> ManagementPositions { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<NationalTeam> NationalTeams { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Tactic> Tactics { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
