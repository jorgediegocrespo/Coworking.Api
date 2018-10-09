using Coworking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coworking.Api.DataAccess.EntityConfig
{
    public class RoomEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<RoomEntity> entityBuilder)
        {
            //The database table name is 'Rooms'
            entityBuilder.ToTable("Rooms");

            //Id property is the primary key and it´s required
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

        }
    }
}
