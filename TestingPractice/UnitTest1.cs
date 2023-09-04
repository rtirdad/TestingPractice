using FluentAssertions;
using System.Linq;
using System.Collections.Generic;
using static TestingPractice.Tests;
using NUnit.Framework;
using System.Collections;

namespace TestingPractice
{
 

    public class Tests
    {
        [Test]
        public void When_a_list_is_created_it_should_be_empty()
        {
            // Arrange / Act
            var list = new MyList<int>();

            // Assert
           list.Count().Should().Be(0);
        }

        [Test]
        public void When_one_element_is_added_the_count_should_be_one()
        {
            // Arrange
            var list = new MyList<int>();

            // Act
            list.Add(1);

            // Assert
            list.Count().Should().Be(1);
        }

        [Test]
        public void When_one_element_is_added_the_element_is_retreivable()
        {
            // Arrange
            var list = new MyList<int>();

            // Act
            list.Add(123);

            // Assert
            list[0].Should().Be(123);
        }

        [Test]
        public void IndexOf_Should_find_element_If_element_does_not_exist_return_negative_one()
        {
            // Arrange
            var list = new MyList<int>();

            // Act
            list.Add(3);
            list.Add(3);
            int indexOfTwo = list.IndexOf(1);
            int indexOfFive = list.IndexOf(5);

            // Assert
            indexOfTwo.Should().Be(1);
            indexOfFive.Should().Be(-1);
        }

        [Test]
        //public void IndexOf_Should_find_element_If_element_does_not_exist_return_negative_one()
        public void IndexOf()
        {
            // Arrange
            var list = new List<int> { 1, 2, 3 };

            // Act
            int indexOfTwo = list.IndexOf(2);
            int indexOfFive = list.IndexOf(5);

            // Assert
            indexOfTwo.Should().Be(1);
            indexOfFive.Should().Be(-1);
        }

        [Test]
        public void Contains()
        {
            // Arrange
            var list = new List<int> { 1, 2, 3 };

            // Act
            bool containOne = list.Contains(1);
            bool containSix = list.Contains(6);

            // Assert
            containOne.Should().BeTrue();
            containSix.Should().BeFalse();
        }

        [Test]
        public void Remove()
        {
            // Arrange
            var list = new List<int> { 1, 2, 3 };

            // Act
            bool removedNum3 = list.Remove(2);

            // Assert
            list.Contains(2).Should().BeFalse();
            list.Count.Should().Be(2);
        }


        [Test]
        //public void insert_element_should_be_inserted_and_in_right_order()
        public void Insert()
        {
            // Arrange
            var list = new List<int> { 1, 2, 3 };

            // Act
            list.Insert(3, 4);
            list.Insert(2, 5);

            // Assert
            list.Should().ContainInOrder(1, 2, 5, 3, 4);
        }

        [Test]
        public void RemoveAt()
        {
            // Arrange
            var list = new List<int> { 1, 2, 3 };
            // Act
            list.RemoveAt(1);

            // Assert
            list.Should().ContainInOrder(1, 3);
        }
        [Test]
        public void This()
        {
            // Arrange
            var list = new List<int> { 1, 2, 3 };
            // Act
            list.Add(123);
            list[0] = 456;
            Console.WriteLine(list[0]);

            // Assert
            list.Should().ContainInOrder(456, 2, 3);
        }

        /*[Test]
        public T this[int index]
        {
            // Arrange
            var list = new List<int> { 1, 2, 3 };
            // Act
            list.Add(123);
            list[0] = 456;
            Console.WriteLine(list[0]);

            // Assert
            list.Should().ContainInOrder(456, 2, 3);
        }*/


        [Test]
        public void Count()
        {
            // Arrange
            var list = new List<int> { 1, 2, 3 };
            // Act
            int Count = list.Count;

            // Assert
            Count.Should().Be(3);
        }
    }

    /*public class MyList<T>
    {
        MyList()
        {

        }
        public void Clear()
        {
            // Arrange
            var myList = new MyList<T>();
            // Act
            myList.Clear();

            // Assert
            //myList.Should().BeEmpty();
        }
    }*/

}
