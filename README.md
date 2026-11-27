# Food Restaurant Menu Ordering System with Bill Calculation and Receipt Display

**Course:** ITEC 102 – Fundamentals of Programming  
**Institution:** Laguna State Polytechnic University – College of Computer Studies

## Group Members

- **Jaraplasan, Khrycel Noela E.**
- **Palmero, Jilliana Miel A.**
- **Villaflores, Bianca Mae G.**

## Project Description

Some restaurant ordering requires writing down orders by hand, computing totals with a calculator, and preparing receipts manually, which can lead to calculation errors, delays, and disorganized records. This project digitizes the process into a lightweight, interactive C# Console Application for Bianacel Restaurant. It works like a **self-service ordering kiosk with cashier-assisted cash payment**: customers enter their name, choose an order type, order from a menu with ASCII-art food drawings, and apply a discount if they qualify. The system computes the bill automatically, then the customer proceeds to the cashier, who receives the physical cash and types the amount into the same console application. The program then computes the change and prints an organized receipt.

The system is made for customers and cashiers only. It has no sales records, daily reports, or staff and administrator functions.

## Objectives

### General Objective

- To develop a functional, interactive C# console-based food restaurant menu ordering system that automates order taking, discount computation, bill calculation, cashier-assisted payment processing, and receipt display using basic programming constructs.

### Specific Objectives

- To develop a simple C# console application that addresses the problem of manual order taking and bill computation in a restaurant.
- To accept and process customer inputs (name, Y/N answers, order type, item number, quantity, discount type, and ID number) and cashier input (cash amount) using variables and appropriate data types (string, int, decimal).
- To implement conditional statements (if-else and switch) and looping structures (while and do-while) to control the ordering flow and repeat invalid inputs.
- To perform necessary computations, such as the amount per item (price × quantity), the subtotal, the discount, the total to pay, and the customer's change.
- To ask whether the customer has a discount (Senior Citizen, PWD, Student, or Others) and apply the discount rate after the customer enters an ID number.
- To display accurate and organized results through the console interface, including the menu with ASCII-art drawings, the order so far, the bill, and the receipt.
- To keep the screen clean by clearing the console after every invalid entry and before each next step.
- To allow the customer to cancel an order, after a Y/N confirmation, while choosing items, and to serve another customer without restarting the program.
- To test the program and verify that its features, including input validation, the no-order option, and the cancel option, work reliably without crashing.

## Technologies & Programming Language Used

- **Language:** C#
- **Platform / Compiler:** Console Application (Visual Studio Code/.NET / OnlineGDB)
- **Core Concepts:** Variables & Data Types, `Console.ReadLine()`, `Console.Clear()`, `int.TryParse()`, `decimal.TryParse()`, `if-else` Conditionals, `switch` (with `default`), `while` and `do-while` Loops, bitwise `&` and logical `||` in validation, `Trim()` and `ToUpper()`, `string.Format()`, static methods, `DateTime.UtcNow` (for Philippine time)

## System Features

- **Customer Greeting & Order Type:** Welcomes the customer with a customer number, records their name (it cannot be empty), and lets them choose **Dine In (`[1]`)** or **Take Out (`[2]`)**.
- **Order Confirmation:** Accepts `Y` or `N` in uppercase or lowercase; answering `N` thanks the customer and skips the menu.
- **Menu with ASCII Art:** Displays 12 fixed items with prices in PHP and a text-based drawing of each, with **Bianacel Halo-Halo** labeled as *Bianacel's Special*.
- **Multiple-Item Ordering:** Enter an item number (`1–12`) and a quantity, repeat as needed, and enter `0` to finish. Each item is confirmed (e.g., `Added 2 x Mae-Fries`), and the menu is shown again with **Your Order So Far** and the running subtotal.
- **Cancel Order:** Enter `C` while choosing items. The system asks **"Are you sure you want to cancel your order? (Y/N)"**. `Y` cancels the order (no bill, payment, or receipt) and `N` goes back to the menu. An order can no longer be cancelled after the customer proceeds to the cashier.
- **Discounts:** Asks if the customer has a discount. Types: **Senior Citizen (20%)**, **PWD (20%)**, **Student (10%)**, and **Others (5%)**. An ID number is required, and only one discount type is allowed per customer.
- **Cashier-Assisted Payment:** The bill shows the subtotal, discount, and total to pay, and tells the customer to proceed to the cashier. The cashier receives the physical cash, presses `Enter`, and types the cash received.
- **Input & Payment Validation:** Rejects an empty name, invalid Y/N answers, invalid order types, invalid item numbers, non-positive quantities, invalid discount choices, an empty ID number, and cash amounts that are non-numeric or less than the total to pay. After each error, the screen is cleared and the same step is shown again with an error message.
- **Clean Screen Navigation:** Uses `Console.Clear()` after every invalid entry and before each next step, so only the current step is shown.
- **Automatic Billing & Receipt:** Computes each item's amount, the subtotal, the discount, the total to pay, and the change, then prints a receipt with the order number, date and time (Philippine time, UTC+8), customer name, order type, discount type and ID number (if any), items, quantities, prices, subtotal, discount, total to pay, cash, and change.
- **Next Customer:** After each receipt, the program asks **"Is there another customer? (Y/N)"** and starts a new transaction for `Y`, or ends with *Goodbye!* for `N`.

## How to Run the Code

1. Open the source file located at `src/Program.cs`.
2. Copy the code into **OnlineGDB** ([onlinegdb.com](https://onlinegdb.com/)) with the language set to **C#**, or open it in **Visual Studio Code** / **.NET**.
3. Click **Run** (or run `dotnet run` in your terminal).
4. Enter your name, answer `Y` to start an order, and choose the order type. Type item numbers (`1–12`) with quantities, then enter `0` when done (or `C` to cancel the order).
5. Answer the discount question. If you have a discount, choose the type and enter your ID number.
6. When the bill appears, go to the cashier. The cashier presses `Enter` and types the cash amount to get the receipt.
7. Press `Enter` at **"Another customer?"**, then answer `Y` for another customer or `N` to end the program.
