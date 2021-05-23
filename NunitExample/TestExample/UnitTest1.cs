//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NunitExample;

namespace TestExample
{
    [TestFixture]
    public class UnitTest1
    {
        Banking obj = new Banking();
        double bal;
        [Test]
        public void TestDepositAmtPass()
        {
            obj.DepositAmount(60);
            bal = obj.Balance;
            Assert.AreEqual(60, bal);
        }
        [Test]
        public void TestWithdrawAmtNotEnoughBalace()
        {
            obj.WithDrawAmount(60000);
            Assert.AreEqual("Sorry! not enough Balance ", obj.msg);
        }
        [Test]
        public void TestWithDrawAmtEnoughBalance()
        {
            obj.WithDrawAmount(60);
            Assert.AreEqual("success", obj.msg);
        }
        [Test]
        public void TestDepositAmtNegativeValue()
        {
            obj.DepositAmount(-90);
            double balance = 0;
            bal = obj.Balance;
            Assert.AreEqual(balance, bal);
        }
    }
}
