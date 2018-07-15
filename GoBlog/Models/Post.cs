using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoBlog.Models
{
    public class Post
    {
		public int ID { get; set; }
		public string Username { get; set; }
		public string Title { get; set; }
		public string[] DatePosted { get; set; }
		public string Body { get; set; }
		public List<string> Tags { get; set; }
    }
}
