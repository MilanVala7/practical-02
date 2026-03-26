namespace BankAccount;

class Program
{
    static void Main()
    {
        CustomerAccount c = new CustomerAccount(9876543210, "Milan Vala");

        //Initializing static variable using the class name
        CustomerAccount.bank_name = "Bank of Baroda";

        //prints the info of Customer account 
        c.printInfo();
    }
}