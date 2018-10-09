using Coworking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coworking.Api.DataAccess.EntityConfig
{
    public class OfficeEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<OfficeEntity> entityBuilder)
        {
            //The database table name is 'Offices'
            entityBuilder.ToTable("Offices");

            //Id property is the primary key and it´s required
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            //A booking have an admin
            entityBuilder.HasOne(x => x.Booking).WithOne(x => x.Office);
        }
    }
}
