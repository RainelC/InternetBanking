﻿
using Microsoft.EntityFrameworkCore;

namespace InternetBanking.Infrastructure.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    }
}
