var dataBase= new Dictionary<string, Dictionary<string, double>>();
var PasBal= new Dictionary<string, double>();
string action;
bool myBool=true;
bool actionB = true;
var users = new Dictionary<string, Dictionary<string, double>>
{
    { "John", new Dictionary<string, double>
    {
        { "password", 1000000.99d }
    } }
};
while (actionB)
{
    Console.WriteLine("What action do you want to do:\n1-Sign-in\n2-Log-in");
    action = Console.ReadLine();
    var actionI = Convert.ToInt32(action);
    switch (actionI)
    {
        case 1:


            Console.WriteLine("If you want to create a new account, please enter username:");
            string username = Console.ReadLine();

            if (dataBase.ContainsKey(username))
            {
                Console.WriteLine("This username already exist!");

            }
            else
            {
                Console.WriteLine("Please enter password:");
                string password = Console.ReadLine();
                double BalanceNew = 0.00d;
                dataBase.Add(username, PasBal);
                PasBal.Add(password, BalanceNew);
            }

            Console.WriteLine("Please, Lon-in!\nEnter username:");
            string userNameL = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string passwordL = Console.ReadLine();
            if (dataBase.ContainsKey(userNameL))
            {
                if (PasBal.ContainsKey(passwordL))
                {
                    Console.WriteLine("Log-in is successful!");
                    while (myBool)
                    {
                        Console.WriteLine("Options:\n1-Check Balance\n2-Deposit\n3-Withdraw\n4-Log-out");
                        var option = Console.ReadLine();
                        int optionI = Convert.ToInt32(option);
                        switch (optionI)
                        {
                            case 1:
                                Console.WriteLine($"Current balance:{PasBal[passwordL]}");
                                break;
                            case 2:
                                Console.WriteLine("Enter the amount to top up the balance: ");
                                var amount = Console.ReadLine();
                                double amountD = Convert.ToDouble(amount);
                                PasBal[passwordL] = PasBal[passwordL] + amountD;
                                Console.WriteLine("Balance is updated");
                                break;
                            case 3:
                                Console.WriteLine("How much do you want to withdraw:");
                                var withdraw = Console.ReadLine();
                                double withdrawD = Convert.ToDouble(withdraw);
                                if (withdrawD <= PasBal[passwordL])
                                {
                                    PasBal[passwordL] = PasBal[passwordL] - withdrawD;
                                    Console.WriteLine("Balance is updated");
                                }
                                else
                                {
                                    Console.WriteLine("Impossible operation! Your Balance is lower(");
                                }
                                break;
                            case 4:
                                myBool = false;
                                break;
                            case > 4:
                                Console.WriteLine($"Current balance:{PasBal[passwordL]}");
                                break;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Incorrect password!");
                }
            }
            else
            {
                Console.WriteLine("This username is not exist! Please Sign-in.");
            }
            break;

        case 2:
            myBool = true;
            Console.WriteLine("Please, Lon-in!\nEnter username:");
            string userNameL2 = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string passwordL2 = Console.ReadLine();
            if (dataBase.ContainsKey(userNameL2))
            {
                if (PasBal.ContainsKey(passwordL2))
                {
                    Console.WriteLine("Log-in is successful!");
                    while (myBool)
                    {
                        Console.WriteLine("Options:\n1-Check Balance\n2-Deposit\n3-Withdraw\n4-Log-out");
                        var option = Console.ReadLine();
                        int optionI = Convert.ToInt32(option);
                        switch (optionI)
                        {
                            case 1:
                                Console.WriteLine($"Current balance:{PasBal[passwordL2]}");
                                break;
                            case 2:
                                Console.WriteLine("Enter the amount to top up the balance: ");
                                var amount = Console.ReadLine();
                                double amountD = Convert.ToDouble(amount);
                                PasBal[passwordL2] = PasBal[passwordL2] + amountD;
                                Console.WriteLine("Balance is updated");
                                break;
                            case 3:
                                Console.WriteLine("How much do you want to withdraw:");
                                var withdraw = Console.ReadLine();
                                double withdrawD = Convert.ToDouble(withdraw);
                                if (withdrawD <= PasBal[passwordL2])
                                {
                                    PasBal[passwordL2] = PasBal[passwordL2] - withdrawD;
                                    Console.WriteLine("Balance is updated");
                                }
                                else
                                {
                                    Console.WriteLine("Impossible operation! Your Balance is lower(");
                                }
                                break;
                            case 4:
                                myBool = false;
                                break;
                            case > 4:
                                Console.WriteLine($"Current balance:{PasBal[passwordL2]}");
                                break;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Incorrect password!");
                }
            }
            else
            {
                Console.WriteLine("This username is not exist! Please Sign-in.");
            }


            break;

        case > 2:break;
        case < 1:break;
    }
}