using System;
using System.Collections.Generic;

namespace ConvertNumber2Word
{
    public class ConvertNumber
    {
        
        private static  List<string> ones = new List<string>()      
        {   "Zero",
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten",
            "Eleven",
            "Twelve",
            "Thirteen",
            "Fourteen",
            "Fifteen",
            "Sixteen",
            "Seventeen",
            "Eighteen",
            "Nineteen"
        };

        private static List<string> tens = new List<string>()
        {
            "Zero",
            "Ten",
            "Twenty",
            "Thirty",
            "Fourty",
            "Fifty",
            "Sixty",
            "Seventy",
            "Eighty",
            "Ninty"
        };
      
       
        public static string ToWord(long inputNumber)
        {
            string textValue = "";
            int localNumber;
          
            if (inputNumber == 0) return "Zero";  
            if (inputNumber < 0) return "minus " + ToWord(Math.Abs(inputNumber)); 

            if ((inputNumber / 1000000) > 0)   
                {  
                textValue += ToWord(inputNumber / 100000) + " Lakes ";  
                inputNumber %= 1000000;  
                } 

            if ((inputNumber / 1000) > 0)   
                {  
                textValue += ToWord(inputNumber / 1000) + " Thousand ";  
                inputNumber %= 1000;  
                } 

            if ((inputNumber / 100) > 0)   
                {  
                textValue += ToWord(inputNumber / 100) + " Hundrad ";  
                inputNumber %= 100;  
                }

            localNumber = (int)inputNumber;
            if (localNumber < 20)
            {
                textValue += ones[localNumber];  
            }
            else   
             {  
                textValue += tens[localNumber / 10];  
                if ((localNumber % 10) > 0) textValue += " " + ones[localNumber % 10];  
             } 

            return textValue;   
        }



    }
}