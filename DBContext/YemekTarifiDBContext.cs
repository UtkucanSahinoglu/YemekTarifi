public class YemekTarifiDBContext : DbContext
{
    public DbSet <User>? users { get; set; }
    public DbSet <Role>? roles { get; set; }
    public DbSet <Category>? categories { get; set; }
    public DbSet <Meal>? meals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
        optionsBuilder.UseMySql("server=localhost;database=YemekTarifi;user=root;port=3306;password=toortoor", serverVersion);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        AccountDatabaseBuilder.TableBuilder(modelBuilder);
        MealDatabaseBuilder.TableBuilder(modelBuilder);

    } 
}