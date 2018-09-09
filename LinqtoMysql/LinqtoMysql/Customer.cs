using System;
using System.Collections.Generic;

namespace LinqtoMysql
{
    public struct CustInfo
    {
        public string RegNum;
        public string FirstName;
        public string LastName;
    }

    static public class Customer
    {
        public static List<CustInfo> CustomerList = new List<CustInfo>();
       static Customer()
        {
            CustomerList.Add(new CustInfo() {RegNum ="A100",FirstName="Rakesh",LastName="Sharma" });
            CustomerList.Add(new CustInfo() { RegNum = "A101", FirstName = "Mahesh", LastName = "Ganapathi" });
            CustomerList.Add(new CustInfo() { RegNum = "A102", FirstName = "Kumar", LastName = "Shanmugam" });
            CustomerList.Add(new CustInfo() { RegNum = "A103", FirstName = "Latha", LastName = "Devi" });
            CustomerList.Add(new CustInfo() { RegNum = "A104", FirstName = "Radha", LastName = "Kumari" });
            CustomerList.Add(new CustInfo() { RegNum = "A105", FirstName = "Kreethi", LastName = "Mohini" });
            CustomerList.Add(new CustInfo() { RegNum = "A106", FirstName = "Sudha", LastName = "Rani" });
        }


    }
}
