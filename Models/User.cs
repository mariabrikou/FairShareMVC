namespace FairShare.Models;

public class User
{
    int userID {get;set;}
    string? username {get;set;}
    string? password {get;set;}
    string? email {get;set;}
    

    public User(string username, string password, string email)
    {
        this.username = username;
        this.password = password;
        this.email = email;
    }

}
