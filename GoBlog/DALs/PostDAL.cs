using GoBlog.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GoBlog.DALs
{
	public class PostDAL
	{
		private readonly string connectionString = @"Data Source=.\SqlExpress;Initial Catalog = GoBlog; Integrated Security = True";

		public PostDAL()
		{ }

		/// <summary>
		/// Gets all posts in our database
		/// </summary>
		/// <returns>A list of posts</returns>
		public IList<Post> GetAllPosts()
		{
			List<Post> allPosts = new List<Post>();

			try
			{
				// Create a new connection object
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					// Open the connection
					conn.Open();

					// Select all posts
					string sql = "SELECT * FROM posts " +
									"ORDER BY post_id Desc;";

					SqlCommand cmd = new SqlCommand(sql, conn);

					// Execute the command
					SqlDataReader reader = cmd.ExecuteReader();

					// Loop through each row
					while (reader.Read())
					{
						// Create a post
						Post post = new Post();
						post.ID = Convert.ToInt32(reader["post_id"]);
						post.Title = Convert.ToString(reader["post_title"]);
						post.Username = Convert.ToString(reader["username"]);
						// Split date and time into array DatePosted;
						// allows both to be posted as distinct parts in View
						post.DatePosted = (Convert.ToString(reader["post_date"]).ToLower()).Split(' ');
						post.Body = Convert.ToString(reader["post_body"]);

						allPosts.Add(post);
					}

					reader.Close();

					// For each post in our list of posts,
					// get all tags associated with that post and add it to post object
					for (int i = 0; i < allPosts.Count; i++)
					{
						sql = "SELECT tag FROM tags " +
									   "INNER JOIN post_tags ON post_tags.tag_id = tags.tag_id " +
									   "INNER JOIN posts ON posts.post_id = post_tags.post_id " +
									   "WHERE posts.post_id = @id;";

						cmd = new SqlCommand(sql, conn);
						cmd.Parameters.AddWithValue("@id", allPosts[i].ID);
						reader = cmd.ExecuteReader();

						// Initialize the list of strings that will represent our post tags
						allPosts[i].Tags = new List<string>();

						// Add all tags associated with a post to that post
						while (reader.Read())
						{
							string tag = Convert.ToString(reader["tag"]);
							allPosts[i].Tags.Add(tag);
						}

						if (allPosts[i].Tags.Count == 0)
						{
							allPosts[i].Tags.Add("none");
						}

						reader.Close();
					}
				}
			}
			catch (SqlException ex)
			{
				throw;
			}
			return allPosts;
		}

		public Post GetPost(int id)
		{

			Post post = new Post();

			try
			{
				// Create a new connection object
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					// Open the connection
					conn.Open();

					// Select all posts
					string sql = "SELECT * FROM posts " +
									"WHERE post_id = @id;";

					SqlCommand cmd = new SqlCommand(sql, conn);
					cmd.Parameters.AddWithValue("@id", id);

					// Execute the command
					SqlDataReader reader = cmd.ExecuteReader();

					// Loop through each row
					while (reader.Read())
					{
						// Create a post
						post.ID = Convert.ToInt32(reader["post_id"]);
						post.Title = Convert.ToString(reader["post_title"]);
						post.Username = Convert.ToString(reader["username"]);
						// Split date and time into array DatePosted;
						// allows both to be posted as distinct parts in View
						post.DatePosted = (Convert.ToString(reader["post_date"]).ToLower()).Split(' ');
						post.Body = Convert.ToString(reader["post_body"]);
					}

					reader.Close();

					sql = "SELECT tag FROM tags " +
								   "INNER JOIN post_tags ON post_tags.tag_id = tags.tag_id " +
								   "INNER JOIN posts ON posts.post_id = post_tags.post_id " +
								   "WHERE posts.post_id = @id;";

					cmd = new SqlCommand(sql, conn);
					cmd.Parameters.AddWithValue("@id", id);
					reader = cmd.ExecuteReader();

					post.Tags = new List<string>();

					// Add all tags associated with a post to that post
					while (reader.Read())
					{
						string tag = Convert.ToString(reader["tag"]);
						post.Tags.Add(tag);
					}

					if (post.Tags.Count == 0)
					{
						post.Tags.Add("none");
					}

					reader.Close();
				}
			}
			catch (SqlException ex)
			{
				throw;
			}
			//return GetAllPosts().FirstOrDefault(p => p.ID == id);
			return post;

		}

		public void CreatePost(Post post)
		{
			try
			{
				// Create a new connection object
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					// Open the connection
					conn.Open();

					// Select all posts
					string sql = "INSERT INTO posts (username, post_title, post_body) " +
								"VALUES (@username, @title, @body);";

					SqlCommand cmd = new SqlCommand(sql, conn);
					cmd.Parameters.AddWithValue("@username", post.Username);
					cmd.Parameters.AddWithValue("@title", post.Title);
					cmd.Parameters.AddWithValue("@body", post.Body);

					// Execute the command
					cmd.ExecuteNonQuery();
				}
			}
			catch (SqlException ex)
			{
				throw;
			}
		}
	}
}