using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoBlog.Models
{
    public class User
    {
		public string Username { get; set; }
		public string AccountCreatedDate { get; set; }
		public IList<Post> PostsByUser { get; set; }
		 
    }
}
