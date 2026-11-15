#  Food Restaurant Menu Ordering System with Bill Calculation and Receipt Display
Course: ITEC 102 – Fundamentals of Programming
Institution: Laguna State Polytechnic University – College of Computer Studies

# Project Description

In small restaurants, taking orders, computing bills, and writing receipts are often done by hand with pen, paper, and a calculator. This can lead to calculation errors, slow transactions, and disorganized records of orders and payments. This project digitizes that process into a lightweight, interactive C# Console Application for Bianacel Restaurant. It greets the customer, records the order type, displays a menu with ASCII-art drawings of each food item, accepts multiple items and quantities, automatically computes the bill, processes cash payment, and prints a formatted receipt with the customer's change.

Objectives
General Objective
To develop a simple console-based application using C# that helps users manage food orders, calculate bills accurately, and display receipts efficiently, minimizing manual calculation errors and improving the organization of restaurant transactions.
Specific Objectives
To develop a simple C# console application that addresses the problem of manual order taking and bill computation in a restaurant.
To accept and process user inputs (name, Y/N answer, order type, item number, quantity, and cash amount) using variables and appropriate data types (string, int, decimal).
To greet the customer, record the customer's name, and record the order type (Dine In or Take Out).
To display the list of food items with their prices and a text-based (ASCII) drawing of each item.
To implement conditional statements (if-else and switch) and looping structures (while and do-while) to control the ordering flow and repeat invalid inputs.
To compute the amount per item, the total bill, and the customer's change using arithmetic operations.
To generate and display a receipt containing the customer's name, order type, items ordered, quantities, prices, total bill, cash, and change.
To test the program using valid and invalid inputs and verify that its features work reliably without crashing.
Group Members
Jaraplasan, Khrycel Noela E.
Palmero, Jilliana Miel A.
Villaflores, Bianca Mae G.
Technologies & Programming Language Used
Language: C#
Platform / Compiler: Console Application (.NET / OnlineGDB)
Core Concepts: Variables & Data Types, Console.Write / Console.WriteLine / Console.ReadLine(), if-else and switch Conditionals, while and do-while Loops, Arithmetic Operators, int.TryParse / decimal.TryParse, Trim() / ToUpper(), string.Format
System Features
Customer Greeting & Name Entry: Displays the "WELCOME TO BIANACEL RESTAURANT" banner and greets the customer by name.
Order Confirmation (Y/N): Accepts uppercase or lowercase answers. If the customer answers N, the system thanks them and exits without showing the menu.
Order Type Selection: Customer chooses [1] Dine In or [2] Take Out; invalid entries are rejected and asked again.
Menu with ASCII Art: Displays 12 fixed menu items with prices in PHP, each with a small text-based drawing. Bianacel Halo-Halo is labeled "Bianacel's Special."
Multiple-Item Ordering: Enter an item number (1–12) and a quantity, repeat as many times as needed, and enter 0 to finish. A confirmation such as Added 2 x Mae-Fries appears after each item.
Input Validation: Item numbers must be whole numbers from 0 to 12, quantities must be whole numbers greater than 0, and cash must be numeric and not less than the total bill.
Automatic Bill Computation: Calculates each item's amount (price × quantity) and the total bill, then displays the bill for review before payment.
Payment & Change: Accepts the cash amount and computes the change.
Formatted Receipt: Prints the restaurant name, customer name, order type, ordered items, quantities, prices, amounts, total, cash, and change, followed by a personalized thank-you message.
No-Order Handling: If no item was ordered, the system displays "No items ordered." and skips the bill, payment, and receipt.
