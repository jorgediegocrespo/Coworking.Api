using Coworking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coworking.Api.DataAccess.EntityConfig
{
    public class BookingEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<BookingEntity> entityBuilder)
        {
            //The database table name is 'Bookings'
            entityBuilder.ToTable("Bookings");

            //Id property is the primary key and it´s required
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            //An office and a user have a booking
            entityBuilder.HasOne(x => x.Office).WithOne(x => x.Booking);
            entityBuilder.HasOne(x => x.User).WithOne(x => x.Booking);
        }
    }
}
