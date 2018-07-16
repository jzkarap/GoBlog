# GoBlog

CURRENTLY
GoBlog includes a script that will build an initial database, using sql.

Users can view posts (most to least recent), in an index view which truncates posts over 300 characters in length,
or view full-length posts in a single-post view. Posts include a title, a date created, a creator, a body of text, and a number of associated tags.

Users can view all current accounts in database, along with post counts, and can view all posts by user.

Users can create new posts (if using an existing username), which will be added correctly to database and included in all future queries.


FUTURE ADDITIONS:
- search by tag
- create new tags (implicitly/explicitly)
- search by date created
  > day, month, year
- create new account
  > add password field to database, salted password hashing
- allow user to remain logged in while in session
- dependency injection
- data validation
- previous/next button when viewing single post
  > appropriate posts shown if in main index or viewing specific user, specific tag, etc.
- allow comments on post
  > post creator can toggle comments on/off
- allow theme selection
