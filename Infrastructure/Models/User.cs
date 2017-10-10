using System;

namespace Infrastructure.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public int Role { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
