namespace ConsoleApp1;
using System.Collections.Generic;
public class Users
{
    private List<User> users;

    public Users()
    {
        users = new List<User>();
    }

    public User FindUser(string? PhoneNumber)
    {
        User user = this.users.Find(user => user.Ph == PhoneNumber);
        return user;
    }
    public Boolean AddUser(User NewUser)
    {
        if (this.FindUser(NewUser.Ph) != null)
            return false;
        users.Add(NewUser);
        return true;
    }

    public Boolean Deleteuser(string? PhoneNumber)
    {
        return users.Remove(FindUser(PhoneNumber));
    }

    public Boolean UpdateUser(User UpdatedUser )
    {
        User temp = new User { Name = UpdatedUser.Name, Email = UpdatedUser.Email, Ph = UpdatedUser.Ph };
        Deleteuser(UpdatedUser.Ph);
        return AddUser(temp);
    }

    public void PrintAll()
    {
        foreach (User user in users)
        {
        Console.WriteLine(user);
        }
    }
}