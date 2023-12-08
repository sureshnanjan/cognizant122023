using NUnit.Framework;
using Application;
namespace ApplicationScenarios
{
    [TestFixture]
    class TestBankApp
    {


        [Test]
        public void TransferFunds()
        {
            /// AAA
            Account source = new Account();
            source.Deposit(200m);

            Account destination = new Account();
            destination.Deposit(150m);
            /// Act
            /// Assert
            source.TransferFunds(destination, 100m);

            //Assert.Are(250m, destination.Balance);
            Assert.That(250m, Is.EqualTo(destination.Balance));
            
        }

        [Test]
        public void DepositFunds()
        {
            /// AAA
            Account source = new Account();
            source.Deposit(200m);

            //Assert.Are(250m, destination.Balance);
            Assert.That(200m, Is.EqualTo(source.Balance));

        }
    }
}
