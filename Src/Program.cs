using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine();
        Console.WriteLine("==============================================");
        Console.WriteLine("       WELCOME TO BIANACEL RESTAURANT");
        Console.WriteLine("==============================================");

        Console.Write("Dear customer, please enter your name: ");
        string name = Console.ReadLine() ?? "";

        // ---------- START AN ORDER ----------
        string start;
        do
        {
            Console.WriteLine();
            Console.Write("Good day, " + name + "! Would you like to start an order? (Y/N): ");
            start = (Console.ReadLine() ?? "").Trim().ToUpper();

            if (start != "Y" && start != "N")
            {
                Console.WriteLine("Invalid input. Please enter Y or N.");
            }
        }
        while (start != "Y" && start != "N");

        if (start == "Y")
        {
            //  ORDER TYPE 
            string orderType;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Select your order type:");
                Console.WriteLine("[1] Dine In");
                Console.WriteLine("[2] Take Out");
                Console.Write("Enter your choice: ");
                orderType = (Console.ReadLine() ?? "").Trim();

                if (orderType != "1" && orderType != "2")
                {
                    Console.WriteLine("Invalid choice. Please select 1 or 2.");
                }
            }
            while (orderType != "1" && orderType != "2");

            string orderTypeName = "Take Out";
            if (orderType == "1")
            {
                orderTypeName = "Dine In";
            }
            Console.WriteLine("You selected " + orderTypeName + ".");

            // ---------- MENU WITH ASCII ART ----------
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
            Console.WriteLine("   \\_______/");
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

            // ---------- ORDER ----------
            string orderList = "";
            decimal total = 0;
            int itemNo = -1;

            do
            {
                Console.WriteLine();
                Console.Write("Enter item number (0 = done): ");

                if (!int.TryParse(Console.ReadLine(), out itemNo) || itemNo < 0 || itemNo > 12)
                {
                    Console.WriteLine("Invalid item number.");
                    itemNo = -1;
                }
                else if (itemNo > 0)
                {
                    string itemName = "";
                    decimal itemPrice = 0;

                    switch (itemNo)
                    {
                        case 1: itemName = "Biancheese Burger"; itemPrice = 89; break;
                        case 2: itemName = "Khrypperoni Pizza"; itemPrice = 149; break;
                        case 3: itemName = "Jilli-Ghetti"; itemPrice = 79; break;
                        case 4: itemName = "Khryspy Noela Chicken"; itemPrice = 109; break;
                        case 5: itemName = "Mae-Fries"; itemPrice = 49; break;
                        case 6: itemName = "Bianacel Halo-Halo"; itemPrice = 89; break;
                        case 7: itemName = "Miel Milk Tea"; itemPrice = 65; break;
                        case 8: itemName = "Khrycel Iced Tea"; itemPrice = 35; break;
                        case 9: itemName = "Jillidog"; itemPrice = 59; break;
                        case 10: itemName = "Miel Shake"; itemPrice = 75; break;
                        case 11: itemName = "Maewich"; itemPrice = 69; break;
                        case 12: itemName = "Khrynoela Fried Rice"; itemPrice = 99; break;
                    }

                    // ---------- QUANTITY ----------
                    int quantity = 0;
                    Console.Write("Enter quantity: ");

                    while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
                    {
                        Console.Write("Invalid quantity. Try again: ");
                    }

                    //  COMPUTE AMOUNT 
                    decimal amount = itemPrice * quantity;
                    total = total + amount;

                    orderList = orderList +
                        string.Format("{0,-22}{1,4}{2,10:N2}{3,11:N2}",
                        itemName, quantity, itemPrice, amount) + "\n";

                    Console.WriteLine("Added " + quantity + " x " + itemName);
                }
            }
            while (itemNo != 0);

            // ---------- BILL ----------
            if (total == 0)
            {
                Console.WriteLine();
                Console.WriteLine("No items ordered.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("==============================================");
                Console.WriteLine("              YOUR ORDER AND BILL");
                Console.WriteLine("==============================================");
                Console.WriteLine("{0,-22}{1,4}{2,10}{3,11}", "Item", "Qty", "Price", "Amount");
                Console.WriteLine("----------------------------------------------");
                Console.Write(orderList);
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("{0,-36}{1,11:N2}", "TOTAL BILL (PHP)", total);
                Console.WriteLine("==============================================");

                // ---------- PAYMENT ----------
                decimal cash = 0;
                Console.Write("Enter cash amount: ");

                while (!decimal.TryParse(Console.ReadLine(), out cash) || cash < total)
                {
                    Console.Write("Insufficient or invalid amount. Try again: ");
                }

                decimal change = cash - total;

                // ---------- RECEIPT ----------
                Console.WriteLine();
                Console.WriteLine("==============================================");
                Console.WriteLine("           BIANACEL RESTAURANT");
                Console.WriteLine("                  RECEIPT");
                Console.WriteLine("==============================================");
                Console.WriteLine("Customer Name: " + name);
                Console.WriteLine("Order Type: " + orderTypeName);
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("{0,-22}{1,4}{2,10}{3,11}", "Item", "Qty", "Price", "Amount");
                Console.WriteLine("----------------------------------------------");
                Console.Write(orderList);
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("{0,-36}{1,11:N2}", "TOTAL BILL (PHP)", total);
                Console.WriteLine("{0,-36}{1,11:N2}", "CASH (PHP)", cash);
                Console.WriteLine("{0,-36}{1,11:N2}", "CHANGE (PHP)", change);
                Console.WriteLine("==============================================");
                Console.WriteLine("Thank you, " + name + "!");
                Console.WriteLine("Please come again to Bianacel Restaurant!");
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"Thank you for visiting Bianacel Restaurant, {name}!");
            Console.WriteLine("Please come again!");
        }
        // ---------- GOODBYE ----------
        Console.WriteLine();
        Console.WriteLine("Goodbye!");
    }
}
