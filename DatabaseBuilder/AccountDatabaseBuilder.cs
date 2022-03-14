public static class AccountDatabaseBuilder
{
    static void SetDataToDB(ModelBuilder modelBuilder)
    { 
        
    }
    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity <User>( entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e =>e.FirstName).IsRequired();
            entity.Property(e =>e.LastName).IsRequired();
            entity.Property(e =>e.Email).IsRequired();
            entity.Property(e =>e.Password).IsRequired();
            entity.HasOne(e => e.role).WithMany(e =>e.Users).HasForeignKey(e =>e.RoleId);
            entity.HasMany(e =>e.meal).WithOne(e =>e.user).HasForeignKey(e =>e.UserId);

        });
        modelBuilder.Entity <Role>(entity =>
        {
            entity.HasKey(e =>e.Id);
            entity.Property(e =>e.RoleType).IsRequired();
            
        });

    }

}