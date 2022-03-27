using CloudCoustomers.API.Models;
using System.Collections.Generic;

namespace CloudCoustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() => new()
        {
            new User
            {
                Name = "Leandro",
                Email = "leandromtr@hotmail.com",
                Address = new Address()
                {
                    Street = "Rua, 123",
                    City = "Bordeaux",
                    ZipCode = "43600",
                }
            },
            new User
            {
                Name = "Lucas",
                Email = "lucas@gmail.com",
                Address = new Address()
                {
                    Street = "Rua, da Bahia 321",
                    City = "Prado",
                    ZipCode = "9876",
                }
            },
            new User
            {
                Name = "Teteus",
                Email = "teteus@gmail.com",
                Address = new Address()
                {
                    Street = "Rua, da Selma 123",
                    City = "Indaiatuba",
                    ZipCode = "5678",
                },
            }
        };
    }
}
