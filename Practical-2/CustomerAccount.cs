namespace BankAccount;

class CustomerAccount
{
    public static string? bank_name;
    public long customer_accountNo;
    public string customer_name;

    public CustomerAccount(long accountNo, string customerName)
    {
        customer_accountNo = accountNo;
        customer_name = customerName;
    }

    /// <summary>
    /// Purpose: Displays all details of the customer account including bank name, account number, and customer name.
    /// Return Type: void (does not return any value)
    /// </summary>
    /// 
    public void printInfo()
    {
        Console.WriteLine("Customer Account Details");
        Console.WriteLine("Bank Name: " + bank_name);
        Console.WriteLine("Account Number: " + customer_accountNo);
        Console.WriteLine("Customer Name: " + customer_name);
    }
}
