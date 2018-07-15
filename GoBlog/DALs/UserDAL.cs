using GoBlog.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GoBlog.DALs
{
	public class UserDAL
	{
		private readonly string connectionString = @"Data Source=.\SqlExpress;Initial Catalog = GoBlog; Integrated Security = True";

		public UserDAL()
		{ }

		public IList<User> GetAllUsers()
		{
			List<User> allUsers = new List<User>();

			try
			{
				// Create a new connection object
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					// Open the connection
					conn.Open();

					// Select all posts
					string sql = "SELECT * FROM users " +
									"ORDER BY username Desc;";

					SqlCommand cmd = new SqlCommand(sql, conn);

					// Execute the command
					SqlDataReader reader = cmd.ExecuteReader();

					// Loop through each row
					while (reader.Read())
					{
						// Create a post
						User user = new User();
						user.Username = Convert.ToString(reader["username"]);
						// Gets only date from database;
						// discards time
						user.AccountCreatedDate = Convert.ToString(reader["date_joined"]).Split(' ')[0];


						allUsers.Add(user);
					}

					reader.Close();

					PostDAL postDAL = new PostDAL();
					IList<Post> posts = postDAL.GetAllPosts();

					foreach (var user in allUsers)
					{
						user.PostsByUser = new List<Post>();

						foreach (var post in posts)
						{
							if (post.Username == user.Username)
							{
								user.PostsByUser.Add(post);
							}
						}
					}
				}
			}
			catch (SqlException ex)
			{
				throw;
			}

			return allUsers;
		}

		public User GetUser(string username)
		{
			if (username == null)
			{
				username = "notFound";
			}

			User user = new User();

			try
			{
				// Create a new connection object
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					// Open the connection
					conn.Open();

					// Select all posts
					string sql = "SELECT * FROM users " +
									"WHERE username = @username;";

					SqlCommand cmd = new SqlCommand(sql, conn);
					cmd.Parameters.AddWithValue("@username", username);

					// Execute the command
					SqlDataReader reader = cmd.ExecuteReader();

					// Loop through each row
					while (reader.Read())
					{
						user.Username = Convert.ToString(reader["username"]);
						// Gets only date from database;
						// discards time
						user.AccountCreatedDate = Convert.ToString(reader["date_joined"]).Split(' ')[0];
					}

					reader.Close();

					PostDAL postDAL = new PostDAL();
					IList<Post> posts = postDAL.GetAllPosts();

					user.PostsByUser = new List<Post>();

					foreach (var post in posts)
					{
						if (post.Username == user.Username)
						{
							user.PostsByUser.Add(post);
						}
					}

				}
			}
			catch (SqlException ex)
			{
				throw;
			}

			return user;
		}
	}
}
