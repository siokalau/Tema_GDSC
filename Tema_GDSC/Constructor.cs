namespace Tema_GDSC;

public class Constructor
{
    public Admin BuildAdmin()
    {
        string nume;
        Console.WriteLine("Administrator: ");
        nume = Console.ReadLine();

        Admin adm = new Admin(nume);
        return adm;
    }
    
    public User BuildUser()
    {
        string nume;
        string password;
        string email;
        
        Console.WriteLine("Login: ");
        nume = Console.ReadLine();
        
        Console.WriteLine("Parola: ");
        password = Console.ReadLine();
        
        Console.WriteLine("Email");
        email = Console.ReadLine();

        return new User(nume, password, email);
    }
}