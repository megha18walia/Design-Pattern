using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class ProxySpaceBook: ISpaceBook

    {
    SpaceBook objSpace = new SpaceBook();

    private string userName;
    private string password;
    private bool isAuthenticated = false;

    public void RegisterUser()
    {
        isAuthenticated = false;
        userName = "";
        password = "";
        Console.WriteLine("Following rae the steps to register User");
        Console.WriteLine("Enter User Name");
        userName = Console.ReadLine();
        do
        {
            Console.WriteLine("Please Enter Password");
            string pass = Console.ReadLine();
            Console.WriteLine("Please Confirm Password");
            string passConfirm = Console.ReadLine();

            if (pass == passConfirm)
                password = pass;
            else
            {
                password = "";
                Console.WriteLine("Password and Confirm Password does not match, Try again");
            }
        } while (password == "");

    }

    public bool AuthenticateUser()
    {
        Console.WriteLine("Enter User Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Password");
        string pass = Console.ReadLine();

        if (name == userName && pass == password)
        {
            isAuthenticated = true;
        }
        else
        {
            isAuthenticated = false;
            Console.WriteLine("Try Login Again");
        }

        return isAuthenticated;
    }

    public void AddUser(User user)
    {
        if (!isAuthenticated)
        {
            RegisterUser();
            AuthenticateUser();
        }
        if (isAuthenticated)
        {
            objSpace.Add(user);
        }
    }

    public void UpdateUser(User user)
    {
        if (!isAuthenticated)
        {
            RegisterUser();
            AuthenticateUser();
        }
            if (isAuthenticated)
        {
            objSpace.Update(user);
        }
    }

    public void DeleteUser(string user)
    {
        if (!isAuthenticated)
        {
            RegisterUser();
            AuthenticateUser();
        }
            if (isAuthenticated)
        {
            objSpace.Delete(user);
        }
    }

    }
}
