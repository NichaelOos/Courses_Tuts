using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BudgetingConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Budgeting App";
            Dictionary<string, double> expense = new Dictionary<string, double>();
            
            DictionaryBuilder(expense);
            Console.WriteLine();

            // Console.WriteLine(IncomeOrExpense(input));
            KeyWordCheck(expense);
            //Stores the sorted(by descending values) dictionary in a variable
            var sortedDict = from entry in expense orderby entry.Value descending select entry;
            PrintFull(sortedDict.ToDictionary(pair => pair.Key, pair => pair.Value));
            Console.WriteLine();
            Console.WriteLine("Balance:");
            //retrieve different currency formats depending on a given country code
            Console.WriteLine(Calculation(expense).ToString("C", CultureInfo.CurrentCulture));
            Console.Read();
        }
        //Method prints the categories contained in the dictionary
        static void PrintCat(Dictionary<string, double> expense) 
        {
            Console.WriteLine("Here are the loaded categories");
            foreach (var item in expense)
            {
                Console.WriteLine(item.Key);
            }
        }

        //Method prints the whole dictionary both key's and values
        static void PrintFull(Dictionary<string, double> expense)
        {
            Console.WriteLine("Here is a full scope of expenses and income");
            Console.WriteLine("Expenses report: ");
            foreach (var item in expense)
            {
                //Helps to format the printed text, places the semicolon after n spaces for a ll items when printed. 
                //This aligns the income/expense amounts
                int catLength = item.Key.Length;
                int space = 30-catLength;
                string Space = string.Concat(Enumerable.Repeat(" ", space));
                Console.WriteLine($"{item.Key}{Space}: {item.Value}");
            }
        }
        static void DictionaryBuilder(Dictionary<string,double> expense)
        {
            bool specialNum = false;
            string cat = "";
                // Loop executes to add categories to dictionary, and exits when user inputs any variation of exit
                while (cat != "exit")
                {
                    Console.Write("Please add an expense/income category: ");
                    cat = Console.ReadLine();
                    /* Check the input category for numbers by tring to convert each character to a number in order to prevent the input of
                    of a number in the category variable.
                    Checks for the input of special characters.
                    */
                    for (int i = 0; i < cat.Length; i++) 
                    {
                        specialNum = false;
                        if (int.TryParse((cat[i].ToString()), out int num) == true)
                        {
                            Console.WriteLine("Please enter a vallid category");
                            specialNum= true;
                            break;
                            
                        }

                        var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
                        if (!regexItem.IsMatch(cat[i].ToString())) 
                        {
                            Console.WriteLine("Please enter a vallid category");
                        break;
                        }   
                    }
                if (specialNum == false) 
                {
                    /*Executed when input is not null or empty and when the dictionary does not contain any variables hence no loop is needed*/
                    if (!String.IsNullOrEmpty(cat) && expense.Count == 0)
                    {
                        expense.Add(cat, 0.00);
                        Console.WriteLine();

                    }
                    /* Verifies that the input is not empty or null and that the expense count is >0 in order to execute a foreach loop
                    to verify that the category does not already exist*/
                    else if (!String.IsNullOrEmpty(cat) && expense.Count != 0)
                    {
                        bool contains = false;
                        foreach (var item in expense.Keys.ToList())
                        {
                            if (cat.Equals(item))
                            {
                                contains = true;
                                Console.WriteLine("No duplicate expenses allowed");
                            }
                        }
                        /*Adds the input category to dictionary if it contains is false and prohibits the input of exit and it's variances when
                        exiting the while loop*/
                        if (!contains && cat.ToLower() != "exit")
                        {
                            expense.Add(cat, 0.00);
                            Console.WriteLine();
                        }
                        else
                        {
                            //Do nothing, loop through till the item is found or not
                        }
                    }
                    else
                    {
                        // Do nothing, prohibits empty key value from being entered into dictionary
                    }
                }
                    
                }
            PrintCat(expense);
        }

                

                

      
        /* Method prompts user for input according to a specific criteria , which the input should align with. The method verify's the
         the input accordingly:
        *Input criteria: CAT:AMOUNT
        *Valid Category
        *If Category not found provides the option to add it
        *Prohibits placement of letters in the AMOUNT section and the use of \\
        *Checks wether the Category is null or empry
        *
        *
        *
        */
        static void KeyWordCheck(Dictionary<string, double> expense)
        {
            bool status = true;
            string KeyWord="";
            string amount="";
            Console.WriteLine("For expenses:  CATEGORY:-####,####");
            Console.WriteLine("For income:    Income:####,##");
            Console.WriteLine();
            while (status)
            {
                bool contains = false;
                
                Console.Write("Please enter expense or income: ");
                string input = Console.ReadLine();
                if (input != "exit")
                {
                    Console.WriteLine();
                    try
                    {
                        input.Contains(":");
                        int semiColon = input.IndexOf(':');
                        KeyWord = input.Substring(0, semiColon);
                        amount = input.Substring(semiColon + 1);
                        foreach (var item in expense)
                        {
                            if (KeyWord == item.Key && String.IsNullOrEmpty(input) == false)
                            {
                                contains = true;

                            }

                        }

                        if (contains == true)
                        {
                            //Prevents leter inputs and the use of fullstops in place of commas.
                            if (double.TryParse(amount, out double amountD))
                            {
                                //Formats the input to two decimal places removing any extra decimals
                                amountD = Math.Truncate(100 * amountD) / 100;
                                expense[KeyWord] = amountD;
                            }
                            else
                            {
                                Console.WriteLine("Please enter valid input. No letters in the amount section, use a comma to separate the decimals ");
                                Console.WriteLine();
                            }


                        }
                        //User is asked if they would like to add the category, a while loop is initiated until the necessary input is provided
                        //If "Y" the dictionary builder function is called to validate and add the category and after this the loop stops
                        //If "N" nothing is done and the exit parameter is met. The program returns to the KeyWordCheck() function.
                        else
                        {
                            Console.WriteLine($"Category \"{KeyWord}\" not found");
                            string Decision="";

                            while ((Decision != "Y" && Decision !=  "N"))
                            {
                                Console.WriteLine($"Would you like to add \"{KeyWord}\" to the category dictionary?(Y/N): ");
                                Decision = Console.ReadLine();
                                if (Decision == "Y")

                                {
                                    Console.WriteLine("Enter \"exit\" after adding the category.");
                                    DictionaryBuilder(expense);
                                }
                                if (Decision == "N")
                                {
                                    //Do nothing runs loop
                                }
                            }
                            

                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Please enter the correct format");
                    }

                    
                }
                else
                {
                    //Status changes to false when exit is entered
                    status = false;
                }


            }

            PrintFull(expense);
            Console.WriteLine();
        }

        //Preforms the neccessary calculation to output the balance
        static double Calculation(Dictionary<string, double> expense) 
        {
            // list of the values are created inorder to use the sum operation
            List<double> valueList = new List<double>();
            valueList= expense.Values.ToList();
            double Balance = valueList.Sum();
            return Balance;
        }

    }
}
