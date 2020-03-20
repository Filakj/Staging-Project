using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_DataAccess.Entities
{
    public class DEVDbContext : DbContext
    {
        public DEVDbContext(){} 
        public DEVDbContext(DbContextOptions<DEVDbContext> options)
         : base(options)
        {
        }
    }
}
