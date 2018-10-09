using Coworking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coworking.Api.DataAccess.EntityConfig
{
    public class Room2ServicesEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Room2ServicesEntity> entityBuilder)
        {
            //The database table name is 'Room2Service'
            entityBuilder.ToTable("Room2Service");

            //A room may have many services
            entityBuilder.HasOne(x => x.Service).WithMany(x => x.Room2Service).HasForeignKey(x => x.ServiceId);

            //A service may be in many rooms
            entityBuilder.HasOne(x => x.Room).WithMany(x => x.Room2Service).HasForeignKey(x => x.RoomId);

            //ServiceId and RoomId are requiered and they´re the primary key
            entityBuilder.HasKey(x => new { x.ServiceId, x.RoomId });
            entityBuilder.Property(x => x.ServiceId).IsRequired();
            entityBuilder.Property(x => x.RoomId).IsRequired();
        }
    }
}
