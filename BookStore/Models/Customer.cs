using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}