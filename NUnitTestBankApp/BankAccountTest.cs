using NUnit.Framework;
using BankApp;
using BankApp.Model;

namespace NUnitTestBankApp
{
    [TestFixture]
    public class BankAccountTest
    {
        private BankAccount _bankAccount;
        double baseBalance;
        [SetUp]
        public void Setup()
        {
            // arrange
            baseBalance = 10000;
            _bankAccount = new BankAccount(baseBalance); // starting balance is 10,000
        }       
        
        [TestCase(0.0005)]        
        public void DepositMoney_IncreaseMoney(double value)
        {
            // act
            _bankAccount.Deposit(value);

            // assert
            Assert.AreEqual(baseBalance + value, _bankAccount.GetBalance());
        }

        [TestCase(-500)]
        public void DepositNegativeBalance_ShouldNotIncreaseAmount(double value)
        {
            // act
            _bankAccount.Deposit(value);

            //assert
            Assert.AreEqual(baseBalance, _bankAccount.GetBalance());
        }

        [TestCase(1000)]
        public void WithdrawMoney_DecreaseMoney(double value)
        {
            // act
            _bankAccount.Withdraw(value);

            //assert
            Assert.AreEqual(baseBalance - value, _bankAccount.GetBalance());
        }

        [TestCase(-500)]
        public void WithdrawalOfNegativeBalance_ShouldNotWithdraw(double value)
        {
            // act
            _bankAccount.Withdraw(value);

            // assert
            Assert.AreEqual(baseBalance, _bankAccount.GetBalance());

        }

        [TestCase(50)]
        public void WithdrawalAmountShouldNotGreaterThanBalance(double value)
        {
            // act
            _bankAccount.Withdraw(value);

            // assert
            Assert.Greater(_bankAccount.GetBalance(),value);
        }


    }
}