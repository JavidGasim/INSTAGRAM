namespace INSTAGRAM;

internal class USER
{
    //id,name,surname,age,email,password
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public USER()
    {
        
    }

    public USER(string Name, string Surname, int Age, string Email, string Password)
    {
        this.Id = Guid.NewGuid();
        this.Name = Name;
        this.Surname = Surname;
        this.Age = Age;
        this.Email = Email;
        this.Password = Password;
    }

    public void showAllUser()
    {
        Console.WriteLine("Id: " + Id);
        Console.WriteLine();
        Console.WriteLine("Name of User: " + Name);
        Console.WriteLine("Surname of User: " + Surname);
        Console.WriteLine("Age of User: " + Age);
        Console.WriteLine("Email: " +  Email);
        Console.WriteLine("Password: " +  Password);
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();
        Thread.Sleep(1000 * 3);
    }
}