﻿namespace BooksAndAuthors.api.ContextFactory
{
    using Microsoft.EntityFrameworkCore.Design;
    using Microsoft.EntityFrameworkCore;
    using Repository;

    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
            var builder = new DbContextOptionsBuilder<RepositoryContext>()
            .UseSqlServer(configuration.GetConnectionString("sqlConnection"),
                b => b.MigrationsAssembly("BooksAndAuthors.api"));
            return new RepositoryContext(builder.Options);
        }
    }
}
