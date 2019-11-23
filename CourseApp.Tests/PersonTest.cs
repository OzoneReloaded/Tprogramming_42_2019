using System;
using Xunit;

namespace CourseApp.Tests
{
    public class PersonTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Person();
            Assert.Equal(0, item.Age);
            Assert.Equal("Somename", item.Name);
            Assert.Equal("Somesurname", item.Surname);
            Assert.True(item.IsMale);
        }

        [Fact]
        public void TestView()
        {
            var item = new Person();
            var view = @"hello";
            Assert.Equal(view, item.View());
        }

        [Fact]
        public void TestSetAge()
        {
            var item = new Person();
            item.Age = 26;
            Assert.Equal(26, item.Age);
        }

        [Fact]
        public void TestIncorrectSetAge()
        {
            var item = new Person();
            item.Age = -5;
            Assert.Equal(0, item.Age);
        }

        [Fact]
        public void TestCorrectIncorrectSetAge()
        {
            var item = new Person();
            item.Age = 27;
            item.Age = -1;
            Assert.Equal(27, item.Age);
        }
    }
}
