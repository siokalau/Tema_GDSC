namespace Tema_GDSC;
public interface IApplication
{
    string GetName();
    int GetNumberOfUsers();
    string ToString();
    void AddUser(User user);
    void RemoveUser(User user);
}
