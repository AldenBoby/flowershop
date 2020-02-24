using NUnit.Framework;
using FlowerShop;
using NSubstitute;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {   
            //ARRANGE
            IClient c = Substitute.For<IClient>();
            IOrderDAO b = Substitute.For<IOrderDAO>();
            Order a = Substitute.For<Order>(b,c);
            //ACT
            a.Deliver();
            //ASSERT
            b.Received().SetDelivered(a);
        }
    }
}