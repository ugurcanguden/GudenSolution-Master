using System;

namespace Guden.Core.Entities.Concrete.Core
{
    public class Core_User : IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GSM { get; set; }
        public int Status { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }        
        public DateTime? BirthDate { get; set; }        
        public DateTime? RegDate { get; set; }
        public DateTime ? UpdateDate { get; set; }
        

    }
}
