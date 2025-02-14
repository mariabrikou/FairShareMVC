namespace FairShare.Models;

public class Payment 
{
    public int PaymentID {get;set;}
    public string PaymentType {get;set;}
    public double Amount {get;set;}
    public DateTime Date {get;set;}
    public bool SplitType {get;set;}
    public string UsernamePayer {get;set;}

    public Payment(string PaymentType, double Amount, DateTime Date, bool SplitType, string UsernamePayer)
    {
        this.PaymentType = PaymentType;
        this.Amount = Amount;
        this.Date = Date;
        this.SplitType = SplitType;
        this.UsernamePayer = UsernamePayer;
    }

    public Payment(string usernamePayer, double amount, DateTime date, int paymentID) {
        this.UsernamePayer = usernamePayer;
        this.Amount = amount;
        this.Date = date;
        this.PaymentID = paymentID;

        this.PaymentType = "Null"; 
        this.SplitType = false;
    }

}