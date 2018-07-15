-- Switch to the system (aka master) database
USE master;
GO

-- Delete the GoBlog Database (IF EXISTS)
IF EXISTS(select * from sys.databases where name='GoBlog')
DROP DATABASE GoBlog
GO

-- Create a new GoBlog Database
CREATE DATABASE GoBlog
GO

-- Switch to the GoBlog Database
USE GoBlog
GO

create table users
(
	username varchar(30) not null,
	date_joined datetime DEFAULT(getdate()),

	constraint pk_username PRIMARY KEY (username)
)

create table tags
(
	tag_id int identity(1,1),
	tag varchar(15) not null,

	constraint pk_tag_id PRIMARY KEY (tag_id),
	UNIQUE (tag)
)

create table posts
(
	post_id int identity(1,1),
	username varchar(30),
	post_title varchar(200) not null,
	post_body text not null,
	post_date datetime DEFAULT(getdate()),
	
	constraint pk_post_id PRIMARY KEY (post_id),
	constraint fk_user_id FOREIGN KEY (username) REFERENCES users (username)
)

create table post_tags
(
	post_id int,
	tag_id int,

	CONSTRAINT fk_tag_id FOREIGN KEY(tag_id) REFERENCES tags (tag_id),
	CONSTRAINT fk_post_id FOREIGN KEY(post_id) REFERENCES posts (post_id)
			
);


INSERT INTO users (username) VALUES ('user');
INSERT INTO tags (tag) VALUES ('development');
INSERT INTO tags (tag) VALUES ('blog');
INSERT INTO tags (tag) VALUES ('asp.net core');
INSERT INTO tags (tag) VALUES ('tech elevator');
INSERT INTO posts (username, post_title, post_body) VALUES ('user', 'First Post!', 'This is your first post. It is a test. If you can see this, you''ve succeeded!');
INSERT INTO posts (username, post_title, post_body) VALUES ('user', 'Second Post?', 'This second post is meant to test tag application. You should see two tags associated with it.');
INSERT INTO posts (username, post_title, post_body) VALUES ('user', 'Third Post :)', 'This post is meant to test that long posts are properly truncated. You should see "..." at the end. It also tests that posts with no associated tags are given a tag of "none" when queried (if it didn''t work, this page would not load). Nonsense text follows: The gorb is in the high place where the fountain swims abreast the unknown blanket of time and the carrots live in harmony with cheeses.');
INSERT INTO post_tags VALUES (1, 1);
INSERT INTO post_tags VALUES (1, 2);
INSERT INTO post_tags VALUES (1, 3);
INSERT INTO post_tags VALUES (1, 4);
INSERT INTO post_tags VALUES (2, 1);
INSERT INTO post_tags VALUES (2, 2);

