using System.ComponentModel.DataAnnotations;

namespace ECommerceBackend.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public DateTime memberSince { get; set; }
    }
}
