﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationExercise
{
    class BankAccount
    {
        private double _balance;

        public void Deposit(double amount)
        {
            Console.WriteLine($"Similating a deposit of {amount, 0:c} to your account!!");
            _balance = amount;
        }
       
        public double GetBalance()
        {
            return _balance;
        }









    }
}
