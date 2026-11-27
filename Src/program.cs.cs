using System;

class HelloWorld
{
    // SCREEN HELPERS (each one clears the screen first, then redraws the step)

    static void ShowHeader(int customerNo)
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("==============================================");
        Console.WriteLine("       WELCOME TO BIANACEL RESTAURANT");
        Console.WriteLine("==============================================");
        Console.WriteLine("Customer No. " + customerNo);
        Console.WriteLine();
    }

    static void ShowMenu()
    {
        Console.WriteLine();
        Console.WriteLine("==============================================");
        Console.WriteLine("               BIANACEL MENU");
        Console.WriteLine("==============================================");

        // 1 Biancheese Burger
        Console.WriteLine("   .-''''-.");
        Console.WriteLine("  /  o  o  \\");
        Console.WriteLine(" (==========)");
        Console.WriteLine("  ~~~~~~~~");
        Console.WriteLine("  \\________/");
        Console.WriteLine("[1] Biancheese Burger - PHP 89.00");
        Console.WriteLine("----------------------------------------------");

        // 2 Khrypperoni Pizza
        Console.WriteLine("  ================");
        Console.WriteLine("  \\ o    o    o  /");
        Console.WriteLine("   \\  o    o    /");
        Console.WriteLine("    \\ o    o   /");
        Console.WriteLine("     \\   o    /");
        Console.WriteLine("      \\  o   /");
        Console.WriteLine("       \\    /");
        Console.WriteLine("        \\  /");
        Console.WriteLine("         \\/");
        Console.WriteLine("[2] Khrypperoni Pizza - PHP 149.00");
        Console.WriteLine("----------------------------------------------");

        // 3 Jilli-Ghetti
        Console.WriteLine("     ~@@@~");
        Console.WriteLine("    @@@@@@@");
        Console.WriteLine("   (~~~~~~~)");
        Console.WriteLine("    \\_______/");
        Console.WriteLine("     (___)");
        Console.WriteLine("[3] Jilli-Ghetti - PHP 79.00");
        Console.WriteLine("----------------------------------------------");

        // 4 Khryspy Noela Chicken
        Console.WriteLine("     .-~~~~-.");
        Console.WriteLine("    /  o  o  \\");
        Console.WriteLine("    \\   o   _/");
        Console.WriteLine("     '-.___/");
        Console.WriteLine("        //");
        Console.WriteLine("       ()()");
        Console.WriteLine("[4] Khryspy Noela Chicken - PHP 109.00");
        Console.WriteLine("----------------------------------------------");

        // 5 Mae-Fries
        Console.WriteLine("    | | | | |");
        Console.WriteLine("    | | | | |");
        Console.WriteLine("  _|_|_|_|_|_");
        Console.WriteLine("  \\    MAE   /");
        Console.WriteLine("   \\  FRIES  /");
        Console.WriteLine("    \\_______/");
        Console.WriteLine("[5] Mae-Fries - PHP 49.00");
        Console.WriteLine("----------------------------------------------");

        Console.WriteLine();
        Console.WriteLine("* BIANACEL'S SPECIAL *");

        // 6 Bianacel Halo-Halo
        Console.WriteLine("       (@)");
        Console.WriteLine("    .~~~~~~~~~.");
        Console.WriteLine("    | * o * o |");
        Console.WriteLine("    | o * o * |");
        Console.WriteLine("    \\  ~~~  /");
        Console.WriteLine("     \\_______/");
        Console.WriteLine("        | |");
        Console.WriteLine("      _|_|_");
        Console.WriteLine("[6] Bianacel Halo-Halo - PHP 89.00");
        Console.WriteLine("----------------------------------------------");

        // 7 Miel Milk Tea
        Console.WriteLine("          //");
        Console.WriteLine("    .-----------.");
        Console.WriteLine("    | o  o  o   |");
        Console.WriteLine("    |  o  o  o  |");
        Console.WriteLine("    |___________|");
        Console.WriteLine("     \\_________/");
        Console.WriteLine("[7] Miel Milk Tea - PHP 65.00");
        Console.WriteLine("----------------------------------------------");

        // 8 Khrycel Iced Tea
        Console.WriteLine("          //");
        Console.WriteLine("    .-----------.");
        Console.WriteLine("    |~~~~~~~~~~~|");
        Console.WriteLine("    |  #     #  |");
        Console.WriteLine("    |    #   #  |");
        Console.WriteLine("    '-----------'");
        Console.WriteLine("[8] Khrycel Iced Tea - PHP 35.00");
        Console.WriteLine("----------------------------------------------");

        // 9 Jillidog
        Console.WriteLine("   .---------------.");
        Console.WriteLine("  (  ~~~~~~~~~~~  )");
        Console.WriteLine("  (=================)");
        Console.WriteLine("   '---------------'");
        Console.WriteLine("[9] Jillidog - PHP 59.00");
        Console.WriteLine("----------------------------------------------");

        // 10 Miel Shake
        Console.WriteLine("        //");
        Console.WriteLine("    .~~@@@@~~.");
        Console.WriteLine("    |~~~~~~~~|");
        Console.WriteLine("    | m i e l|");
        Console.WriteLine("    |  shake |");
        Console.WriteLine("     \\______/");
        Console.WriteLine("[10] Miel Shake - PHP 75.00");
        Console.WriteLine("----------------------------------------------");

        // 11 Maewich
        Console.WriteLine("    .-~~~~~~~~-.");
        Console.WriteLine("   (  o  o  o   )");
        Console.WriteLine("    '-.______.-'");
        Console.WriteLine("    ~~~~~~~~~~");
        Console.WriteLine("    ============");
        Console.WriteLine("    ############");
        Console.WriteLine("    (________)");
        Console.WriteLine("[11] Maewich - PHP 69.00");
        Console.WriteLine("----------------------------------------------");

        // 12 Khrynoela Fried Rice
        Console.WriteLine("      o   .  o");
        Console.WriteLine("    .:*:*:*:*:.");
        Console.WriteLine("   (:.:.:.:.:.:)");
        Console.WriteLine("    \\_________/");
        Console.WriteLine("     '-------'");
        Console.WriteLine("[12] Khrynoela Fried Rice - PHP 99.00");
        Console.WriteLine("----------------------------------------------");
    }

    static void ShowOrderSoFar(string orderList, decimal total)
    {
        Console.WriteLine();
        Console.WriteLine("==============================================");
        Console.WriteLine("              YOUR ORDER SO FAR");
        Console.WriteLine("==============================================");
        Console.WriteLine("{0,-22}{1,4}{2,10}{3,11}", "Item", "Qty", "Price", "Amount");
        Console.WriteLine("----------------------------------------------");
        Console.Write(orderList);
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("{0,-36}{1,11:N2}", "SUBTOTAL (PHP)", total);
        Console.WriteLine("==============================================");
    }

    static void ShowOrderScreen(string orderList, decimal total, string message)
    {
        Console.Clear();
        ShowMenu();
        if (orderList != "")
        {
            ShowOrderSoFar(orderList, total);
        }
        Console.WriteLine();
        if (message != "")
        {
            Console.WriteLine(message);
        }
    }

    static void ShowBill(string orderList, decimal total, string discountLabel, decimal discountAmount, decimal amountDue)
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("==============================================");
        Console.WriteLine("              YOUR ORDER AND BILL");
        Console.WriteLine("==============================================");
        Console.WriteLine("{0,-22}{1,4}{2,10}{3,11}", "Item", "Qty", "Price", "Amount");
        Console.WriteLine("----------------------------------------------");
        Console.Write(orderList);
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("{0,-36}{1,11:N2}", "SUBTOTAL (PHP)", total);
        Console.WriteLine("{0,-36}{1,11:N2}", discountLabel, -discountAmount);
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("{0,-36}{1,11:N2}", "TOTAL TO PAY (PHP)", amountDue);
        Console.WriteLine("==============================================");
    }

    // PHILIPPINE TIME (UTC+8, no daylight saving) - correct even if the computer's time zone setting is wrong
    static DateTime GetPhTime()
    {
        return DateTime.UtcNow.AddHours(8);
    }

    // CANCEL CONFIRMATION: returns true if the customer answers Y
    static bool ConfirmCancel()
    {
        string answer;
        string message = "";
        do
        {
            Console.Clear();
            Console.WriteLine();
            if (message != "")
            {
                Console.WriteLine(message);
                message = "";
            }
            Console.Write("Are you sure you want to cancel your order? (Y/N): ");
            answer = (Console.ReadLine() ?? "").Trim().ToUpper();

            if (answer != "Y" & answer != "N")
            {
                message = "Invalid input. Please enter Y or N.";
            }
        }
        while (answer != "Y" & answer != "N");

        return answer == "Y";
    }

    static void Main()
    {
        // COUNTERS (customer number and order number shown on the screen and the receipt)
        int customerCount = 0;
        int orderCount = 0;

        string another;
        do
        {
            customerCount = customerCount + 1;
            string message = "";

            // CUSTOMER NAME
            string name;
            do
            {
                ShowHeader(customerCount);
                if (message != "")
                {
                    Console.WriteLine(message);
                    message = "";
                }
                Console.Write("Dear customer, please enter your name: ");
                name = (Console.ReadLine() ?? "").Trim();

                if (name == "")
                {
                    message = "Name cannot be empty.";
                }
            }
            while (name == "");

            // START AN ORDER
            string start;
            do
            {
                ShowHeader(customerCount);
                if (message != "")
                {
                    Console.WriteLine(message);
                    message = "";
                }
                Console.Write("Good day, " + name + "! Would you like to start an order? (Y/N): ");
                start = (Console.ReadLine() ?? "").Trim().ToUpper();

                if (start != "Y" & start != "N")
                {
                    message = "Invalid input. Please enter Y or N.";
                }
            }
            while (start != "Y" & start != "N");

            if (start == "Y")
            {
                // ORDER TYPE
                string orderType;
                do
                {
                    ShowHeader(customerCount);
                    if (message != "")
                    {
                        Console.WriteLine(message);
                        message = "";
                    }
                    Console.WriteLine("Select your order type:");
                    Console.WriteLine("[1] Dine In");
                    Console.WriteLine("[2] Take Out");
                    Console.Write("Enter your choice: ");
                    orderType = (Console.ReadLine() ?? "").Trim();

                    if (orderType != "1" & orderType != "2")
                    {
                        message = "Invalid choice. Please select 1 or 2.";
                    }
                }
                while (orderType != "1" & orderType != "2");

                string orderTypeName = "Take Out";
                if (orderType == "1")
                {
                    orderTypeName = "Dine In";
                }

                // ORDER (menu is redrawn with the order so far every time)
                string orderList = "";
                decimal total = 0;
                int itemNo = -1;
                bool cancelled = false;
                message = "You selected " + orderTypeName + ".";

                do
                {
                    ShowOrderScreen(orderList, total, message);
                    message = "";
                    Console.Write("Enter item number (0 = done, C = cancel order): ");
                    string itemInput = (Console.ReadLine() ?? "").Trim().ToUpper();

                    if (itemInput == "C")
                    {
                        if (ConfirmCancel())
                        {
                            cancelled = true;
                            itemNo = 0;
                        }
                        else
                        {
                            message = "Your order was not cancelled. You may continue.";
                            itemNo = -1;
                        }
                    }
                    else if (!int.TryParse(itemInput, out itemNo) || itemNo < 0 || itemNo > 12)
                    {
                        message = "Invalid item number. Please enter 0 to 12.";
                        itemNo = -1;
                    }
                    else if (itemNo > 0)
                    {
                        string itemName = "";
                        decimal itemPrice = 0;

                        switch (itemNo)
                        {
                            case 1:
                                itemName = "Biancheese Burger";
                                itemPrice = 89;
                                break;
                            case 2:
                                itemName = "Khrypperoni Pizza";
                                itemPrice = 149;
                                break;
                            case 3:
                                itemName = "Jilli-Ghetti";
                                itemPrice = 79;
                                break;
                            case 4:
                                itemName = "Khryspy Noela Chicken";
                                itemPrice = 109;
                                break;
                            case 5:
                                itemName = "Mae-Fries";
                                itemPrice = 49;
                                break;
                            case 6:
                                itemName = "Bianacel Halo-Halo";
                                itemPrice = 89;
                                break;
                            case 7:
                                itemName = "Miel Milk Tea";
                                itemPrice = 65;
                                break;
                            case 8:
                                itemName = "Khrycel Iced Tea";
                                itemPrice = 35;
                                break;
                            case 9:
                                itemName = "Jillidog";
                                itemPrice = 59;
                                break;
                            case 10:
                                itemName = "Miel Shake";
                                itemPrice = 75;
                                break;
                            case 11:
                                itemName = "Maewich";
                                itemPrice = 69;
                                break;
                            case 12:
                                itemName = "Khrynoela Fried Rice";
                                itemPrice = 99;
                                break;
                            default:
                                itemName = "Unknown item";
                                itemPrice = 0;
                                break;
                        }

                        // QUANTITY
                        int quantity = 0;
                        ShowOrderScreen(orderList, total, "You chose " + itemName + " - PHP " + itemPrice.ToString("N2") + ".");
                        Console.Write("Enter quantity: ");

                        while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
                        {
                            ShowOrderScreen(orderList, total, "Invalid quantity. Please enter a whole number greater than 0.");
                            Console.Write("Enter quantity: ");
                        }

                        // COMPUTE AMOUNT
                        decimal amount = itemPrice * quantity;
                        total = total + amount;

                        orderList = orderList +
                            string.Format("{0,-22}{1,4}{2,10:N2}{3,11:N2}",
                            itemName, quantity, itemPrice, amount) + "\n";

                        message = "Added " + quantity + " x " + itemName + ".";
                    }
                }
                while (itemNo != 0);

                if (cancelled)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Your order has been cancelled.");
                }
                else if (total == 0)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("No items ordered.");
                }
                else
                {
                    // DISCOUNT
                    decimal discountRate = 0;
                    string discountName = "None";
                    string discountCode = "-";
                    string discountId = "";
                    string hasDiscount;
                    message = "";

                    do
                    {
                        Console.Clear();
                        ShowOrderSoFar(orderList, total);
                        Console.WriteLine();
                        if (message != "")
                        {
                            Console.WriteLine(message);
                            message = "";
                        }
                        Console.Write("Do you have a discount (Senior Citizen, PWD, Student, etc.)? (Y/N): ");
                        hasDiscount = (Console.ReadLine() ?? "").Trim().ToUpper();

                        if (hasDiscount != "Y" & hasDiscount != "N")
                        {
                            message = "Invalid input. Please enter Y or N.";
                        }
                    }
                    while (hasDiscount != "Y" & hasDiscount != "N");

                    if (hasDiscount == "Y")
                    {
                        string discountChoice;
                        do
                        {
                            Console.Clear();
                            ShowOrderSoFar(orderList, total);
                            Console.WriteLine();
                            if (message != "")
                            {
                                Console.WriteLine(message);
                                message = "";
                            }
                            Console.WriteLine("Select your discount type:");
                            Console.WriteLine("[1] Senior Citizen - 20%");
                            Console.WriteLine("[2] PWD            - 20%");
                            Console.WriteLine("[3] Student        - 10%");
                            Console.WriteLine("[4] Others (Promo/Member Card) - 5%");
                            Console.Write("Enter your choice: ");
                            discountChoice = (Console.ReadLine() ?? "").Trim();

                            if (discountChoice != "1" & discountChoice != "2" & discountChoice != "3" & discountChoice != "4")
                            {
                                message = "Invalid choice. Please select 1, 2, 3, or 4.";
                            }
                        }
                        while (discountChoice != "1" & discountChoice != "2" & discountChoice != "3" & discountChoice != "4");

                        switch (discountChoice)
                        {
                            case "1":
                                discountName = "Senior Citizen";
                                discountCode = "SC";
                                discountRate = 0.20m;
                                break;
                            case "2":
                                discountName = "PWD";
                                discountCode = "PWD";
                                discountRate = 0.20m;
                                break;
                            case "3":
                                discountName = "Student";
                                discountCode = "STU";
                                discountRate = 0.10m;
                                break;
                            case "4":
                                discountName = "Others";
                                discountCode = "OTH";
                                discountRate = 0.05m;
                                break;
                            default:
                                discountName = "None";
                                discountCode = "-";
                                discountRate = 0;
                                break;
                        }

                        do
                        {
                            Console.Clear();
                            ShowOrderSoFar(orderList, total);
                            Console.WriteLine();
                            Console.WriteLine("Discount: " + discountName + " (" + (discountRate * 100).ToString("0") + "%)");
                            if (message != "")
                            {
                                Console.WriteLine(message);
                                message = "";
                            }
                            Console.Write("Enter your ID number for the " + discountName + " discount: ");
                            discountId = (Console.ReadLine() ?? "").Trim();

                            if (discountId == "")
                            {
                                message = "ID number cannot be empty.";
                            }
                        }
                        while (discountId == "");
                    }

                    decimal discountAmount = Math.Round(total * discountRate, 2);
                    decimal amountDue = total - discountAmount;
                    string discountLabel = "DISCOUNT (" + discountName + " " + (discountRate * 100).ToString("0") + "%)";
                    if (discountRate == 0)
                    {
                        discountLabel = "DISCOUNT (None)";
                    }

                    // CASHIER-ASSISTED CASH PAYMENT
                    decimal cash = 0;
                    bool paid = false;
                    string payMessage = "";

                    do
                    {
                        ShowBill(orderList, total, discountLabel, discountAmount, amountDue);
                        Console.WriteLine();
                        Console.WriteLine("Please proceed to the cashier for cash payment.");
                        Console.WriteLine("The cashier will receive the physical cash.");
                        Console.WriteLine();
                        Console.WriteLine("Press Enter when the cashier is ready to enter the payment.");
                        Console.ReadLine();

                        ShowBill(orderList, total, discountLabel, discountAmount, amountDue);
                        Console.WriteLine();
                        Console.WriteLine("========== CASHIER PAYMENT ==========");
                        if (payMessage != "")
                        {
                            Console.WriteLine(payMessage);
                            payMessage = "";
                        }
                        Console.Write("Cashier: Enter cash received from customer (PHP): ");
                        string cashInput = (Console.ReadLine() ?? "").Trim();

                        if (!decimal.TryParse(cashInput, out cash) || cash < amountDue)
                        {
                            payMessage = "Invalid or insufficient cash amount. Please enter an amount equal to or greater than the total to pay.";
                            paid = false;
                        }
                        else
                        {
                            paid = true;
                        }
                    }
                    while (!paid);

                    {
                        decimal change = cash - amountDue;

                        // ORDER NUMBER
                        orderCount = orderCount + 1;

                        // RECEIPT
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("==============================================");
                        Console.WriteLine("           BIANACEL RESTAURANT");
                        Console.WriteLine("                  RECEIPT");
                        Console.WriteLine("==============================================");
                        Console.WriteLine("Order No.: " + orderCount);
                        Console.WriteLine("Date: " + GetPhTime().ToString("MMM dd, yyyy  hh:mm tt"));
                        Console.WriteLine("Customer Name: " + name);
                        Console.WriteLine("Order Type: " + orderTypeName);
                        if (discountRate > 0)
                        {
                            Console.WriteLine("Discount Type: " + discountName);
                            Console.WriteLine("ID Number: " + discountId);
                        }
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("{0,-22}{1,4}{2,10}{3,11}", "Item", "Qty", "Price", "Amount");
                        Console.WriteLine("----------------------------------------------");
                        Console.Write(orderList);
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("{0,-36}{1,11:N2}", "SUBTOTAL (PHP)", total);
                        Console.WriteLine("{0,-36}{1,11:N2}", discountLabel, -discountAmount);
                        Console.WriteLine("{0,-36}{1,11:N2}", "TOTAL TO PAY (PHP)", amountDue);
                        Console.WriteLine("{0,-36}{1,11:N2}", "CASH (PHP)", cash);
                        Console.WriteLine("{0,-36}{1,11:N2}", "CHANGE (PHP)", change);
                        Console.WriteLine("==============================================");
                        Console.WriteLine("Thank you, " + name + "!");
                        Console.WriteLine("Please come again to Bianacel Restaurant!");
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"Thank you for visiting Bianacel Restaurant, {name}!");
                Console.WriteLine("Please come again!");
            }

            // PAUSE SO THE RECEIPT / MESSAGE CAN BE READ BEFORE THE SCREEN IS CLEARED
            Console.WriteLine();
            Console.Write("Another customer?");
            Console.ReadLine();

            // ANOTHER CUSTOMER
            message = "";
            do
            {
                Console.Clear();
                Console.WriteLine();
                if (message != "")
                {
                    Console.WriteLine(message);
                    message = "";
                }
                Console.Write("Is there another customer? (Y/N): ");
                another = (Console.ReadLine() ?? "").Trim().ToUpper();

                if (another != "Y" & another != "N")
                {
                    message = "Invalid input. Please enter Y or N.";
                }
            }
            while (another != "Y" & another != "N");
        }
        while (another == "Y");

        // GOODBYE
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Goodbye!");
    }
}
