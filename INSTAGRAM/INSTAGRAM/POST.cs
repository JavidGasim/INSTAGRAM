namespace INSTAGRAM;

internal class POST
{
    //id,Content,CreationDateTime,LikeCount,ViewCount
    public Guid Id { get; set; }
    public string Content { get; set; }
    public DateTime CreationDateTime { get; set; }
    public int LikeCount { get; set; }
    public int ViewCount { get; set; }

    public POST()
    {

    }

    public POST(string Content, DateTime CreationDateTime, int LikeCount, int ViewCount)
    {
        this.Id = Guid.NewGuid();
        this.Content = Content;
        this.CreationDateTime = CreationDateTime;
        this.LikeCount = LikeCount;
        this.ViewCount = ViewCount;
    }

    public void showAllPost()
    {
        Console.WriteLine("Id: " + Id);
        Console.WriteLine();
        Console.WriteLine(Content + "   { " + CreationDateTime + " }");
        Console.WriteLine("Likes: " + LikeCount);
        Console.WriteLine("Views: " + ViewCount);
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();
        Thread.Sleep(1000 * 3);
    }
}