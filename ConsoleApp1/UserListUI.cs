namespace ConsoleApp1;

static class UserListUI
{
    static public int MainOptions()
    {
        Console.Write("1- Add User\n2- Update User\n3- Delete User\n4- Print Users\nYour Chose: ");
        int chose;
        if (!int.TryParse(Console.ReadLine(), out chose) || chose > 4 || chose < 1)
            return -1;
        Console.WriteLine("===========================================================");
        return chose;
    }

    static private int UpdateOptions()
    {
        Console.Write("1- Update Name\n2- Update Email\n3- Update Phone Number\nYour Chose: ");
        int chose;
        if (!int.TryParse(Console.ReadLine(), out chose) || chose > 3 || chose < 1 )
            return -1;
        return chose;
    }

   
    static public Boolean AddUser(Users list)
    {
        string name, email, ph;
        Console.Write("User Name:");
        name = Console.ReadLine();
        Console.Write("User Email:");
        email = Console.ReadLine();
        Console.Write("User Phone Number:");
        ph = Console.ReadLine();
        Console.WriteLine("===========================================================");
        return list.AddUser(new User { Name = name, Email = email, Ph = ph });
    }

    static public Boolean DeleteUser(Users list)
    {
        Console.Write("Enter Your Phone number: ");
        string? PhoneNumber = Console.ReadLine();
        Console.WriteLine("===========================================================");
       return list.Deleteuser(PhoneNumber);
    }

    static public Boolean UpdateUser(Users list)
    {
        int updateOption = UpdateOptions();
        if (updateOption == -1)
            return false;
        Console.Write("Enter Your Phone number: ");
        string? PhoneNumber = Console.ReadLine();
        User NewUser = list.FindUser(PhoneNumber);
        if (NewUser == null)
            return false;
        switch (updateOption)
        {
            case 1 :
                Console.Write("Enter new name: ");
                NewUser.Name = Console.ReadLine();
                break;
            case 2 :
                Console.Write("Enter new email: ");
                NewUser.Email = Console.ReadLine();
                break;
            case 3 :
                Console.Write("Enter new phone number: ");
                NewUser.Ph = Console.ReadLine();
                break;
                
        }
        Console.WriteLine("===========================================================");
        return  list.UpdateUser(NewUser);
    }

    public static char AnotherOperation()
    {
        Console.Write("Make Another Operation (Y/N): ");
        char selection;
        if (!char.TryParse(Console.ReadLine()?.ToUpper(), out selection))
            return 'N';
        return selection;
    }

}