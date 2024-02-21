
Post post1 = new Post();
post1.SetPost("#MyNewCar");

post1.AddLike();
post1.AddLike();
post1.AddLike();
post1.AddLike();
post1.AddLike();
post1.AddLike();

post1.AddComment("Its soo cool");
post1.AddComment("🔥🔥");
post1.AddComment($"Congratulations");

System.Console.WriteLine(post1.GetInfo());

System.Console.WriteLine($"\nComments: {post1.Comments.Count}");
int i = 1;
foreach (var comment in post1.Comments)
{
    System.Console.WriteLine(comment);
    i ++;
}

class Post
{
    public string Text;
    public int Likes;
    public List<string> Comments = new List<string>();

    public void SetPost(string text)
    {
        Text = text;
    }    

    public void AddLike()
    {
        Likes ++;
    }

    public void AddComment(string comment)
    {
        Comments.Add(comment);
    }

    public string GetInfo()
    {
        return $"Title: {Text}   \nLikes: {Likes}";
    }
}
