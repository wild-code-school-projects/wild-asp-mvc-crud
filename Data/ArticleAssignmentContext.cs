using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ArticleAssignment.Models;

namespace ArticleAssignment.Data
{
    public class ArticleAssignmentContext : DbContext
    {
        public ArticleAssignmentContext (DbContextOptions<ArticleAssignmentContext> options)
            : base(options)
        {
        }

        public DbSet<ArticleAssignment.Models.Article> Article { get; set; } = default!;
    }
}
