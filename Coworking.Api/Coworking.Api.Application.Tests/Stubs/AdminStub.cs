using Coworking.Api.DataAccess.Contracts.Entities;
using System.Collections.Generic;

namespace Coworking.Api.Application.Tests.Stubs
{
    public static class AdminStub
    {
        public static AdminEntity Admin_1 = new AdminEntity()
        {
            Id = 1,
            Email = "email1@prueba",
            Name = "prueba1",
            Phone = "111111111"
        };

        public static AdminEntity Admin_2 = new AdminEntity()
        {
            Id = 2,
            Email = "email2@prueba",
            Name = "prueba2",
            Phone = "222222222"
        };

        public static List<AdminEntity> AdminList = new List<AdminEntity>() { Admin_1, Admin_2 };
    }
}
