using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICore.Models
{
    public class MemoryContext : DbContext
    {
        /// <summary>
        /// Inaccessible constructor
        /// </summary>
        /// <param name="options">Context options</param>
        private MemoryContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>
        /// The only way to obtain a MemoryContext.
        /// Initialize the properties needed to create a DB in memory.
        /// </summary>
        public static MemoryContext Instance
        {
            get
            {
                var builder = new DbContextOptionsBuilder<MemoryContext>();
                builder.UseInMemoryDatabase("MemoryContext");
                var options = builder.Options;
                return new MemoryContext(options);
            }
        }

        /// <summary>
        /// User table
        /// </summary>
        public DbSet<User> Users { get; set; }
    }
}
