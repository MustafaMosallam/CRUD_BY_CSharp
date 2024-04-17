// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Users list = new Users();
char Continue = 'N';
do
{
    switch (UserListUI.MainOptions())
    {
        case 1:
            if(!UserListUI.AddUser(list))
                Console.WriteLine("User Already Existed");
            Continue = UserListUI.AnotherOperation();
            break;
        case 2:
           if(!UserListUI.UpdateUser(list))
               Console.WriteLine("User Not Existed");
            Continue = UserListUI.AnotherOperation();
            break;
        case 3:
            if(UserListUI.DeleteUser(list))
                Console.WriteLine("Invalid Phone number");
            Continue = UserListUI.AnotherOperation();
            break;
        case 4:
            list.PrintAll();
            Continue = UserListUI.AnotherOperation();
            break;
    }
} while (Continue == 'Y');
