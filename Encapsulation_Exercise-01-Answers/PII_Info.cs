using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_Exercise_01_Answers
{
    class PII_Info
    {
        // TODO: Create 4 private fields
        private int _userID;
        private string _privateKey;
        private decimal _walletBalance;
        private bool _isAuthenicated;

        // TODO: Create 4 public methods to get (read) those fields
        public int GetUserID()
        {
            return _userID;
        }
        public string GetPrivatKey()
        {
            return _privateKey;
        }
        public decimal GetWalletBalance()
        {
            return _walletBalance;
        }
        public bool GetIsAuthenticated()
        {
            return _isAuthenicated;
        }


        // TODO: Create 4 public methods to set (write) those fields
        public void SetUserID(int userID)
        {
            _userID= userID;
        }
        public void SetPrivateKey(string privateKey)
        {
            _privateKey= privateKey;
        }
        public void SetWalletBalance(decimal walletBalance)
        {
            _walletBalance= walletBalance;
        }
        public void SetIsAuthenticated(bool isAuthenticated)
        {
            _isAuthenicated= isAuthenticated;
        }

        // TODO: Create 2 private auto-implemented properties 
        private string UserName { get; set; }
        private string Password { get; set; }

        // TODO: Create 1 method called SetInfo() which sets the private properties
        public void SetInfo(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
        // TODO: Create 1 method called InformationReport() which creatively displays the 2 private properties 
        public void InformationReport()
        {
            Console.WriteLine($"Username: {UserName}\n" +
                                $"Password: {Password}\n" +
                                $"User ID: {_userID}\n" +
                                $"Private Key: {_privateKey}/n" +
                                $"Wallet Balance: {string.Format(_walletBalance.ToString())}\n" +
                                $"Is Authenticated: {_isAuthenicated}\n\n" +
                                $"SECRET: {_secret}");
            Console.WriteLine();
            Console.WriteLine();

        }

        // BONUS
        // TODO: Create 1 private readonly field called _secret of type string
        private readonly string _secret;
        // TODO: Assign a value to the _secret field
        public PII_Info(string secret)
        {
            _secret = secret;
        }
    }
}
