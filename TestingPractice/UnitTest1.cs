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
            list.Add(6);
            list.Add(3);
            int indexOfTwo = list.IndexOf(3);
            int indexOfFive = list.IndexOf(5);

            // Assert
            indexOfTwo.Should().Be(1);
            indexOfFive.Should().Be(-1);
        }
        [Test]
        public void insert_element_should_be_inserted_and_in_right_order()
        {
            // Arrange
            var list = new MyList<int>();
     
            // Act
            list.Insert(0, 1);
            list.Insert(1, 2);
            list.Insert(1, 3);
            var indexOfOne = list.IndexOf(3);

            // Assert
            //list.Should().ContainInOrder(1, 2, 5, 3, 4);
            indexOfOne.Should().Be(1);
        }

        [Test]
        public void when_list_contains_element_should_give_back_true_otherwise_false()
        {
            // Arrange
            var list = new MyList<int>();

            // Act
            list.Add(1);
            list.Add(2);
            bool containOne = list.Contains(1);
            bool containSix = list.Contains(6);

            // Assert
            containOne.Should().BeTrue();
            containSix.Should().BeFalse();
        }

        [Test]
        public void When_element_is_removed_list_should_be_empty()
        {
            // Arrange
            var list = new MyList<int>();

            // Act
            list.Add(1);
            list.Add(2);
            list.RemoveAt(1);

            // Assert
            list.Contains(5).Should().BeTrue();
        }
        


        [Test]
        public void RemoveAt()
        {
            // Arrange
            var list = new MyList<int>();

            // Act
            list.Add(1);
            list.Add(2);
            //list.RemoveAt(1);

            // Assert
            list.Count().Should().Be(1);
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
