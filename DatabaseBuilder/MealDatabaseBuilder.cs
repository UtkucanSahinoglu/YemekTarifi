public static class MealDatabaseBuilder
{
    static void SetDataToDB(ModelBuilder modelBuilder)
    { 
        
    }

    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity <Category>( entity =>
        {
            entity.HasKey(e =>e.Id);
            entity.Property(e =>e.Name).IsRequired();
            entity.Property(e =>e.Image);
            entity.HasMany(e =>e.Meals).WithOne(e =>e.category).HasForeignKey(e =>e.CategoryId);
        });
        modelBuilder.Entity <Meal>(entity =>
        {
            entity.HasKey(e =>e.Id);
            entity.Property(e =>e.Name).IsRequired();
            entity.Property(e =>e.Description);
            entity.Property(e =>e.CookTime);
            entity.Property(e =>e.PersonQuantity);
            entity.Property(e =>e.PreperationTime);
            entity.Property(e =>e.Point);
            entity.Property(e =>e.Image);
        });

    }

}