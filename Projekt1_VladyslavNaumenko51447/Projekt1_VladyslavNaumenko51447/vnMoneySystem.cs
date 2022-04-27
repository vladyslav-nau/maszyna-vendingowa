using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1_VladyslavNaumenko51447
{
    public class vnMoneySystem
    {
        public abstract class vnMoney
        {
            // statements
            private static double vnCurrPaymentValue = 0;
            private static double vnCurrAmountToPay = 0;
            private string vnCode = "NoMoney";
            private double vnValue;
            private double[] vnBanknotes = { 1, 5, 10, 100, 500, 1000, 5000, 10000 };
            private double[] vnCoins = { 0.5, 1, 5 };
            public static vnMoney vnCurrValute = null;
            // properties
            public static double vnCurrentPaymentValue { get { return vnCurrPaymentValue; } set { vnCurrPaymentValue = value; } }
            public static double vnCurrentAmountToPay { get { return vnCurrAmountToPay; } set { vnCurrAmountToPay = value; } }
            public string vnValuteCode { get { return vnCode; } set { this.vnCode = value; } }
            public double vnValuteValue { get { return vnValue; } set { this.vnValue = value; } }
            public double[] vnBanknotesInfo { get { return vnBanknotes; } set { this.vnBanknotes = value; } }
            public double[] vnCoinsInfo { get { return vnCoins; } set { this.vnCoins = value; } }
            public static vnMoney vnCurrentValute { get { return vnCurrValute; } set { vnCurrValute = value; } }
        }
        public class vnPLN : vnMoney
        {
            public vnPLN()
            {
                vnValuteCode = "PLN";
                vnValuteValue = 1; // pln is main value
                vnBanknotesInfo = new double[] { 10, 20, 50, 100, 200, 500 };
                vnCoinsInfo = new double[] { 1, 2, 5, 10, 20, 50, 0.01, 0.02, 0.05 };
            }
        }
        public class vnUAH : vnMoney
        {
            public vnUAH()
            {
                vnValuteCode = "UAH";
                vnValuteValue = 7.41;
                vnBanknotesInfo = new double[] { 1, 2, 5, 10, 20, 50, 100, 200, 500, 1000 };
                vnCoinsInfo = new double[] { 0.10, 0.50, 1, 2, 5, 10 };
            }
        }
        public class vnBYN : vnMoney
        {
            public vnBYN()
            {
                vnValuteCode = "BYN";
                vnValuteValue = 0.67;
                vnBanknotesInfo = new double[] { 5, 10, 20, 50, 100, 200, 500 };
                vnCoinsInfo = new double[] { 0.01, 0.02, 0.05, 0.10, 0.20, 0.50, 1, 2 };
            }
        }
        public class vnRUB : vnMoney
        {
            public vnRUB()
            {
                vnValuteCode = "RUB";
                vnValuteValue = 20.25;
                vnBanknotesInfo = new double[] { 5, 10, 50, 100, 200, 500, 1000, 2000, 5000 };
                vnCoinsInfo = new double[] { 0.01, 0.05, 0.1, 0.5, 1, 2, 5, 10 };
            }
        }
        public class vnEUR : vnMoney
        {
            public vnEUR()
            {
                vnValuteCode = "EUR";
                vnValuteValue = 0.22;
                vnBanknotesInfo = new double[] { 5, 10, 20, 50, 100, 200, 500 };
                vnCoinsInfo = new double[] { 0.01, 0.02, 0.05, 0.1, 0.2, 0.5, 1, 2 };
            }
        }
        public class vnUSD : vnMoney
        {
            public vnUSD()
            {
                vnValuteCode = "USD";
                vnValuteValue = 0.26;
                vnBanknotesInfo = new double[] { 1, 2, 5, 10, 20, 50, 100 };
                vnCoinsInfo = new double[] { 0.01, 0.05, 0.1, 0.25 };
            }
        }
    }
}
