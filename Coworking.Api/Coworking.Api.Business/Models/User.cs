using Dicres.RepositoryService.Business.Models;
using System;

namespace Coworking.Api.Business.Models
{
    public class User : BaseBusinessModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
