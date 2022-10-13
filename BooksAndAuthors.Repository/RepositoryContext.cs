namespace BooksAndAuthors.Repository
{
    using Entities.Models;
    using Microsoft.EntityFrameworkCore;

    public class RepositoryContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryContext"/> class.
        /// </summary>
        /// <param name="options">The options for this context.</param>
        /// <remarks>
        /// See <see href="https://aka.ms/efcore-docs-dbcontext">DbContext lifetime, configuration, and initialization</see> and
        /// <see href="https://aka.ms/efcore-docs-dbcontext-options">Using DbContextOptions</see> for more information.
        /// </remarks>
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {

        }

        /// <summary>
        /// Gets or sets the books.
        /// </summary>
        /// <value>
        /// The books.
        /// </value>
        public DbSet<Book>? Books { get; set; }

        /// <summary>
        /// Gets or sets the authors.
        /// </summary>
        /// <value>
        /// The authors.
        /// </value>
        public DbSet<Author>? Authors { get; set; }
    }
}
