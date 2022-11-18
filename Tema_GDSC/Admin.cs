namespace Tema_GDSC;

public class Admin
{
    public string Name { get; private set; }

    private List<IApplication> apps;

    public Admin(string name)
    {
        Name = name;
        apps = new List<IApplication>();
    }

    public void AddApplications(IApplication app)
    {
        if (!apps.Contains(app)) apps.Add(app);
        else
        {
            Console.WriteLine("Deja admin");
        }
    }

    public void AddUser(User user, IApplication app)
    {
        if (apps.Contains(app))
        {
            app.AddUser(user);
        }
        else
        {
            Console.WriteLine("nu este permis");
        }

    }

    public void RemoveUser(User user, IApplication app)
    {
        if (apps.Contains(app))
        {
            app.RemoveUser(user);
        }
        else
        {
            Console.WriteLine("nu este permis");
        }
    }
}