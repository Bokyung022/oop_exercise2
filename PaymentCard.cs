﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentPractice
{
    public class PaymentCard
    {
        // Payment Card
        private double balance;
        public PaymentCard(double openingBalance)
        {
            this.balance = openingBalance;
        }

        // Using Card & Checking Balance
        public void EatLunch()
        {
            if (this.balance >= 10.60)
            {
                this.balance -= 10.60;
            }
        }

        public void DrinkCoffee()
        {
            if (this.balance >= 2.0)
            {
                this.balance -= 2.0;
            }
        }

        // Charging Card
        public void AddMoney(double amount)
        {
            if (amount > 0)
            {
                this.balance += amount;
                if (this.balance > 150)
                {
                    this.balance = 150;
                }
            }
        }

        public override string ToString()
        {
            return $"The card has a balance of {this.balance} euros";
        }
    }
}
