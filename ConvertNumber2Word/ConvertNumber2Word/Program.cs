using System;

namespace ConvertNumber2Word
{
    class MainClass
    {
       
        public static void Main(string[] args)
        {
           string newNumber;
            do
            {
                newNumber = "";
            try
            {
                    Console.Write("Please Enter a number ");
                    newNumber = Console.ReadLine();
                    Console.WriteLine(ConvertNumber.ToWord(Convert.ToInt32(newNumber)));
                      
                }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occered while converting " + ex.Message);
            }
        

            } while (newNumber != "");

        }
    }
}
