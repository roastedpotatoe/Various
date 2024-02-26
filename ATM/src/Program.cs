using System;
using System.Linq.Expressions;
using System.Net.NetworkInformation;

//simple ATM application to get familiar with C# syntax once again.
public class cardHolder
{
    string cardNum, firstName, lastName;
    int pin;
    double balance;

    //Constructor
    public cardHolder(string cardNum, string firstName, string lastName, int pin, double balance)
    {
        this.cardNum = cardNum;
        this.firstName = firstName;
        this.lastName = lastName;
        this.pin = pin;
        this.balance = balance;
    }

    public string getCardNum()
    {
        return cardNum;
    }

    public int getPin()
    {
        return pin;
    }

    public string getFirstName()
    {
        return firstName;
    }

    public string getLastName()
    {
        return lastName;
    }

    public double getBalance()
    {
        return balance;
    }

    public void setCardNum(string setCardNum)
    {
        cardNum = setCardNum;
    }

    public void setPin(int setPin)
    {
        pin = setPin;
    }

    public void setFirstName(string setFirstName)
    {
        firstName = setFirstName;
    }

    public void setLastName(string setLastName)
    {
        lastName = setLastName;
    }

    public void setBalance(double setBalance)
    {
        balance = setBalance;
    }

    private void printOptions()
        {
            Console.WriteLine("You have the following options to choose from.");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Balance");
            Console.WriteLine("4. Exit");
        }

    private void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much € would you like to deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            double newBalance = currentUser.getBalance() + deposit;
            currentUser.setBalance(newBalance);
            Console.WriteLine("You sucessfully deposited: {0}. Your new balance is: {1}", deposit, currentUser.getBalance());
        }

        private void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much € would you like to withdraw: ");
            double withdrawal = Double.Parse(Console.ReadLine());
            if(currentUser.getBalance()>withdrawal)
            {
                Console.WriteLine("Insufficient balance your withdrawal cannot outnumber your balance.");
            }
            else
            {
                double newBalance = currentUser.getBalance() - withdrawal;
                currentUser.setBalance(newBalance);
                Console.WriteLine("You sucessfully withdraw: {0}. Your new balance is: {1}", withdrawal, currentUser.getBalance());
            }

        }

        private void displayBalance(cardHolder currentUser)
        {
            Console.WriteLine("Your current balance is: {0}", currentUser.getBalance());
        }


    
    public static void Main(String[] args)
    {
        List<cardHolder> cardHolders = new();
            cardHolders.Add(new cardHolder("123456789", "Peter", "Griffin", 1234, 0.0));
            cardHolders.Add(new cardHolder("123123123", "Luke", "Himmelslaeufer", 1234, 123.45));
            cardHolders.Add(new cardHolder("456456456", "Obi", "Wahn", 1234, 4567.89));
            cardHolders.Add(new cardHolder("789789789", "Duesterer", "Vader", 1234, 12345.67));
 	
        //Promt user
        Console.WriteLine("Welcome to this ATM Console Application!");
        Console.WriteLine("Please insert your debit card: ");
        string debitCardNum = "";
        cardHolder currentUser;

        while(true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                currentUser=cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if(currentUser!= null) 
                { 
                    break; 
                }
                else
                {
                    Console.WriteLine("Card not recognized. Please try again.");
                }
            }
            catch 
            {                   
                Console.WriteLine("Card not recognized. Please try again."); 
            }
        }

        Console.WriteLine("Please enter your pin: ");
        int userPin =0;
        while(true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if(currentUser.getPin() == userPin)
                {                        
                    break;
                }
                else 
                {
                    Console.WriteLine("Incorrect pin. Please try again.");
                }                }
            catch
            {
                Console.WriteLine("Incorrect pin. Please try again.");
            }
        }

        Console.WriteLine("Welcome " + currentUser.getFirstName());
        currentUser.displayBalance(currentUser);
        int option = 0;
        do
        {
            currentUser.printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch {}
            switch (option)
            {
                case 1: currentUser.deposit(currentUser); break;
                case 2: currentUser.withdraw(currentUser); break;
                case 3: currentUser.displayBalance(currentUser); break;
                case 4: break;
                default: option=0; break;
            }
        }  
        while (option != 4);
        Console.WriteLine("Your entry has been recognised. The Console App will now close.");
        
    }
}