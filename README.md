#  Food Restaurant Menu Ordering System with Bill Calculation and Receipt Display

**Course:** ITEC 102 – Fundamentals of Programming  
**Institution:** Laguna State Polytechnic University – College of Computer Studies

## Group Members

- **Jaraplasan, Khrycel Noela E.**
- **Palmero, Jilliana Miel A.**
- **Villaflores, Bianca Mae G.**

## Project Description

Traditional restaurant ordering requires writing down orders by hand, computing totals with a calculator, and preparing receipts manually, which can lead to calculation errors, delays, and disorganized records. This project digitizes the process into a lightweight, interactive **C# Console Application** for **Bianacel Restaurant** featuring a customer greeting, order type selection, a menu with ASCII-art food drawings, multi-item ordering, automated bill computation, cash payment with change, and a formatted receipt.

## Objectives

### General Objective

- To develop a functional, interactive C# console-based food restaurant menu ordering system that automates order taking, bill calculation, payment processing, and receipt display using basic programming constructs.

### Specific Objectives

- To develop a simple C# console application that addresses the problem of manual order taking and bill computation in a restaurant.
- To accept and process user inputs (customer name, Y/N answer, order type, item number, quantity, and cash amount) using variables and appropriate data types (`string`, `int`, `decimal`).
- To implement conditional statements (`if-else` and `switch`) and looping structures (`while` and `do-while`) to control the ordering flow and repeat invalid inputs.
- To perform necessary computations, such as the amount per item (price × quantity), the total bill, and the customer's change.
- To display accurate and organized results through the console interface, including the menu with ASCII-art drawings, the bill, and the receipt.
- To test the program and verify that its features—including input validation and the no-order option—work reliably without crashing.

## Technologies & Programming Language Used

- **Language:** C#
- **Platform / Compiler:** Console Application (.NET / OnlineGDB)
- **Core Concepts:** Variables & Data Types, `Console.ReadLine()`, `int.TryParse()`, `decimal.TryParse()`, `if-else` Conditionals, `switch`, `while` and `do-while` Loops, `string.Format()`

## System Features

- **Customer Greeting & Order Type:** Welcomes the customer, records their name, and lets them choose **Dine In (`[1]`)** or **Take Out (`[2]`)**.
- **Order Confirmation:** Accepts `Y` or `N` in uppercase or lowercase; answering `N` thanks the customer and skips the menu.
- **Menu with ASCII Art:** Displays 12 fixed items with prices in PHP and a text-based drawing of each, with **Bianacel Halo-Halo** labeled as *Bianacel's Special*.
- **Multiple-Item Ordering:** Enter an item number (`1–12`) and a quantity, repeat as needed, and enter `0` to finish; each item is confirmed (e.g., `Added 2 x Mae-Fries`).
- **Input & Payment Validation:** Rejects invalid item numbers, non-positive quantities, and cash amounts that are non-numeric or less than the total bill.
- **Automatic Billing & Receipt:** Computes each item's amount, the total bill, and the change, then prints a receipt with the customer name, order type, items, quantities, prices, total, cash, and change.

## Repository Structure

```text
ITEC102-Final-Project/
├── README.md
├── Proposal/
│   └── Finalproject-Proposal-Form.pdf
├── src/
│   └── Program.cs
├── flowcharts/
│   └── Flowchart_Bianacel_ITEC102_Final_Project.pdf
├── pseudocode/
│   └── pseudocode.pdf
├── screenshots/
│   ├── Screenshot1.png
│   ├── Screenshot2.png
│   ├── Screenshot3.png
│   ├── Screenshot4.png
│   └── Screenshot5.png
└── documentation/
    └── User-Manual.pdf
```

## How to Run the Code

1. Open the source file located at `src/Program.cs`.
2. Copy the code into **OnlineGDB** ([onlinegdb.com](https://onlinegdb.com/)) with the language set to **C#**, or open it in **Visual Studio** / **.NET CLI**.
3. Click **Run** (or run `dotnet run` in your terminal).
4. Enter your name, answer `Y` to start an order, choose the order type, then type item numbers (`1–12`) with quantities. Enter `0` when done, then type the cash amount to get your receipt.
