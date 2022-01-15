using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace UserTicketService.Tests
{

    public class BookTest
    {
        [Fact]
        public void FindAllMustReturnCorrectValue()
        {
            var bookList = new List<Book>()
            {
                new Book() {Title = "Война и мир"},
                new Book() {Title = "Человек-невидимка"},
                new Book() {Title = "Анна Каренина"}
            };

            var mockBookRep = new Mock<IBookRepository>();

            mockBookRep.Setup(b => b.FindAll()).Returns(bookList);

            Assert.Contains(mockBookRep.Object.FindAll(), b => b.Title == "Война и мир");
            Assert.Contains(mockBookRep.Object.FindAll().FirstOrDefault(b => b.Title == "Человек-невидимка").Title, "Человек-невидимка");
            Assert.Contains(mockBookRep.Object.FindAll().FirstOrDefault(b => b.Title == "Анна Каренина").Title, "Анна Каренина");
        }
    }
}
