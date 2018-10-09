using Coworking.Api.DataAccess.Contracts;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.EntityConfig;
using Microsoft.EntityFrameworkCore;

namespace Coworking.Api.DataAccess
{
    public class CoworkingDbContext : DbContext, ICoworkingDbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<AdminEntity> Admins { get; set; }
        public DbSet<BookingEntity> Bookings { get; set; }
        public DbSet<OfficeEntity> Offices { get; set; }
        public DbSet<Office2RoomsEntity> Offices2Rooms { get; set; }
        public DbSet<Room2ServicesEntity> Rooms2Services { get; set; }
        public DbSet<RoomEntity> Rooms { get; set; }
        public DbSet<ServiceEntity> Services { get; set; }

        public CoworkingDbContext(DbContextOptions options) : base(options) { }

        public CoworkingDbContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AdminEntityConfig.SetEntityBuilder(modelBuilder.Entity<AdminEntity>());
            BookingEntityConfig.SetEntityBuilder(modelBuilder.Entity<BookingEntity>());
            Office2RoomsEntityConfig.SetEntityBuilder(modelBuilder.Entity<Office2RoomsEntity>());
            OfficeEntityConfig.SetEntityBuilder(modelBuilder.Entity<OfficeEntity>());
            Room2ServicesEntityConfig.SetEntityBuilder(modelBuilder.Entity<Room2ServicesEntity>());
            RoomEntityConfig.SetEntityBuilder(modelBuilder.Entity<RoomEntity>());
            ServiceEntityConfig.SetEntityBuilder(modelBuilder.Entity<ServiceEntity>());
            UserEntityConfig.SetEntityBuilder(modelBuilder.Entity<UserEntity>());

            base.OnModelCreating(modelBuilder);
        }
    }
}
