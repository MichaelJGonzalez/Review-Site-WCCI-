using Microsoft.EntityFrameworkCore;
using Review_Site_Sok_Michael.Models;


namespace Review_Site_Sok_Michael
{
    public class ShoesContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database = ShoesTest1; Trusted_Connection =True";
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JordansModel>().HasData(
new JordansModel() { Id = 1, Name = "Cement 4's", Color = "White/Gray", ShoeType = "MidTop", ImageURL = "https://images.51microshop.com/11489/product/20220211/OG_Jordan_4_Retro_White_Cement_2016_840606_192_1644575350130_0.jpg" },
new JordansModel() { Id = 2, Name = "Cement 3's", Color = "Black/Gray", ShoeType = " MidTop", ImageURL = "https://sneakernews.com/wp-content/uploads/2018/01/jordan-3-black-cement-official-images-2.jpg" },
new JordansModel() { Id = 3, Name = "Team Jordans", Color = "Green/Black", ShoeType = "HighTop", ImageURL = "https://images.jordansdaily.com/wp-content/uploads/2014/02/jordan-flight-45-high-black-venom-green-02.jpg" });
            modelBuilder.Entity<ReviewModel>().HasData(
            new ReviewModel() { Id = 1, Name = "Cement 4's Review", Description = "Like the color and unique design 8/10", JordansId = 1 },
            new ReviewModel() { Id = 2, Name = "Cement 3's Review", Description = "True to size, durable but laces to short 6/10", JordansId = 2 },
            new ReviewModel() { Id = 3, Name = "Team Jordans Review", Description = "Discolored, not durable, cheap material 3/10", JordansId = 3 });
        }
        public DbSet<JordansModel> Jordans { get; set; }
        public DbSet<ReviewModel> Reviews { get; set; }
    }
}
