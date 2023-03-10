// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Review_Site_Sok_Michael;

#nullable disable

namespace Review_Site_Sok_Michael.Migrations
{
    [DbContext(typeof(ShoesContext))]
    [Migration("20230223155157_First")]
    partial class First
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Review_Site_Sok_Michael.Models.JordansModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ShoeType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Jordans");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "White/Gray",
                            Name = "Cement 4's",
                            ShoeType = "MidTop"
                        },
                        new
                        {
                            Id = 2,
                            Color = "Black/Gray",
                            Name = "Cement 3's",
                            ShoeType = " MidTop"
                        },
                        new
                        {
                            Id = 3,
                            Color = "Green/Blue",
                            Name = "Team Jordans",
                            ShoeType = "HighTop"
                        });
                });

            modelBuilder.Entity("Review_Site_Sok_Michael.Models.ReviewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("JordansId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("JordansId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Like the color and unique design 8/10",
                            JordansId = 1,
                            Name = "Cement 4's Review"
                        },
                        new
                        {
                            Id = 2,
                            Description = "True to size, durable but laces to short 6/10",
                            JordansId = 2,
                            Name = "Cement 3's Review"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Discolored, not durable, cheap material 3/10",
                            JordansId = 3,
                            Name = "Team Jordans Review"
                        });
                });

            modelBuilder.Entity("Review_Site_Sok_Michael.Models.ReviewModel", b =>
                {
                    b.HasOne("Review_Site_Sok_Michael.Models.JordansModel", "Jordans")
                        .WithMany("Reviews")
                        .HasForeignKey("JordansId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jordans");
                });

            modelBuilder.Entity("Review_Site_Sok_Michael.Models.JordansModel", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
