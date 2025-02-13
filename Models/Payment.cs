namespace FairShare.Models;

public class Payment 
{
    int paymentID {get;set;}
    string paymentType {get;set;}
    double amount {get;set;}
    DateTime date {get;set;}
    bool splitType {get;set;}
    string usernamePayer {get;set;}

    public Payment(string paymentType, double amount, DateTime date, bool splitType, string usernamePayer)
    {
        this.paymentType = paymentType;
        this.amount = amount;
        this.date = date;
        this.splitType = splitType;
        this.usernamePayer = usernamePayer;
    }

    public Payment(string usernamePayer, double amount, DateTime date, int paymentID) {
        this.usernamePayer = usernamePayer;
        this.amount = amount;
        this.date = date;
        this.paymentID = paymentID;
    }

}