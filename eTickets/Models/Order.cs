using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
	public class Order
	{
		[Key]
		public int Id { get; set; }

       		public List<OrderItem> OrderItems { get; set; }
    	}
}
