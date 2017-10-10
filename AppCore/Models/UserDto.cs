using System;

namespace AppCore.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public int Role { get; set; }
        public bool IsActive { get; set; }
    }
}