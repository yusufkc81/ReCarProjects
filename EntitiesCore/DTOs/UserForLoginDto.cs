using Core.Entities;

namespace Entities.DTOs
{
    public class UserForloginDto:IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
