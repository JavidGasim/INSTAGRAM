namespace INSTAGRAM;

internal class ADMIN
{
    //id,username,email,password,Posts,Notifications
    public Guid Id { get; set; }
    public string Adminname { get; set; }
    public string Password { get; set; }
    public POST[] posts;
    public USER[] users;

    public ADMIN()
    {
        
    }

    public ADMIN(string Adminname, string Password, POST[] posts, USER[] users)
    {
        Guid Id = Guid.NewGuid();
        this.Adminname = Adminname;
        this.Password = Password;
        this.posts = posts;
        this.users = users;
    }
}