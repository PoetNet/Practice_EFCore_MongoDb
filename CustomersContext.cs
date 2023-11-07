using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using MongoDB.EntityFrameworkCore;
using Testcontainers.MongoDb;

public class CustomersContext : DbContext
{
    private readonly MongoClient _client;

    public CustomersContext(MongoClient client)
    {
        _client = client;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMongoDB(_client, "efsample");

    public DbSet<Customer> Customers => Set<Customer>();
}