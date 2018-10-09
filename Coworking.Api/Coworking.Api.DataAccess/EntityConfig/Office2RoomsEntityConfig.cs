using Coworking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coworking.Api.DataAccess.EntityConfig
{
    public class Office2RoomsEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Office2RoomsEntity> entityBuilder)
        {
            //The database table name is 'Office2Room'
            entityBuilder.ToTable("Office2Room");

            //An office may have many rooms
            entityBuilder.HasOne(x => x.Office).WithMany(x => x.Office2Room).HasForeignKey(x => x.OfficeId);

            //A room may be in many offices
            entityBuilder.HasOne(x => x.Room).WithMany(x => x.Office2Room).HasForeignKey(x => x.RoomId);

            //OfficeId and RoomId are requiered and they´re the primary key
            entityBuilder.HasKey(x => new { x.OfficeId, x.RoomId });
            entityBuilder.Property(x => x.OfficeId).IsRequired();
            entityBuilder.Property(x => x.RoomId).IsRequired();
        }
    }
}
