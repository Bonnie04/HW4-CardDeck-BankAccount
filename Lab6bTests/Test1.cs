namespace Lab6bTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void TestConstructor()
        {
            var account = new BankAccount("John Doe", 100.00m);
            Assert.AreEqual("John Doe", account.CustomerName);
            Assert.AreEqual(100.00m, account.Balance);
        }

        [TestMethod]
        public void TestDeposit()
        {
            var account = new BankAccount("Jane Smith", 50.00m);
            bool result = account.Deposit(25.00m);
            Assert.IsTrue(result);
            Assert.AreEqual(75.00m, account.Balance);
        }

        [TestMethod]
        public void TestWithdraw()
        {
            var account = new BankAccount("Bob Johnson", 100.00m);
            bool result = account.Withdraw(30.00m);
            Assert.IsTrue(result);
            Assert.AreEqual(70.00m, account.Balance);
        }

        [TestMethod]
        public void TestInsufficientFunds()
        {
            var account = new BankAccount("Alice Brown", 10.00m);
            bool result = account.Withdraw(20.00m);
            Assert.IsFalse(result);
            Assert.AreEqual(10.00m, account.Balance);
        }
    }
}