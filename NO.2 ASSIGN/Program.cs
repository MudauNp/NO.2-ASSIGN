using System;

class Program
{
    static string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
    static string[] teens = { "", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
    static string[] tens = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

    static string ConvertToWords(int number)
    {
        if (number < 0 || number > 9999)
        {
            return "Number out of range";
        }

        if (number == 0)
        {
            return "Zero";
        }

        string result = "";

        if (number / 1000 > 0)
        {
            result += ones[number / 1000] + " Thousand";
            number %= 1000;
        }

        if (number / 100 > 0)
        {
            if (result != "")
                result += " ";
            result += ones[number / 100] + " Hundred";
            number %= 100;
        }

        if (number > 0)
        {
            if (result != "")
                result += " ";

            if (number < 10)
            {
                result += ones[number];
            }
            else if (number < 20)
            {
                result += teens[number - 10];
            }
            else
            {
                result += tens[number / 10];
                if (number % 10 > 0)
                {
                    result += " " + ones[number % 10];
                }
            }
        }

        return result;
    }

    static void Main()
    {
        // Test cases
        int[] numbers = { 149, 1149, 42, 890 };

        foreach (int number in numbers)
        {
            string words = ConvertToWords(number);
            Console.WriteLine($"{number} -> {words}");
        }
    }
}
