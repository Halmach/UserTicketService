using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserTicketService.Tests
{
    [TestFixture]
    public class TicketServiceTests
    {
        [Test]
        public void GeTicketPriceMustReturnNotNullableTicket()
        {
            var ticketServiceTest = new TicketService();
            Assert.IsNotNull(ticketServiceTest.GetTicketPrice(1));
        }

        [Test]
        public void GeTicketPriceMustThrowException()
        {
            var ticketServiceTest = new TicketService();
            Assert.Throws<TicketNotFoundException>(() => ticketServiceTest.GetTicketPrice(100));
        }

        [Test]
        public void TicketPriceMustReturnNotNullableTicket()
        {
            var mockTicketService = new Mock<ITicketService>();
            mockTicketService.Setup(p => p.GetTicketPrice(1)).Returns(100);
            mockTicketService.Setup(p => p.GetTicketPrice(2)).Returns(500);
            mockTicketService.Setup(p => p.GetTicketPrice(3)).Returns(7800);

            var ticketPriceTest = new TicketPrice(mockTicketService.Object);
            Assert.That(ticketPriceTest.MakeTicketPrice(3) == 7800);
        }

        [Test]
        public void FindAllMustReturnCorrectValue()
        {
            var mockUserRepos = new Mock<IUserRepository>();

            List<User> users = new List<User>
            {
                new User() {Name = "Антон"},
                new User() {Name = "Иван"},
                new User() {Name = "Алексей"}
            };

            mockUserRepos.Setup(p => p.FindAll()).Returns(users);

            Assert.That(mockUserRepos.Object.FindAll().Any(user => user.Name == "Антон"));
            Assert.That(mockUserRepos.Object.FindAll().Any(user => user.Name == "Иван"));
            Assert.That(mockUserRepos.Object.FindAll().Any(user => user.Name == "Алексей"));
        }

    }
}
