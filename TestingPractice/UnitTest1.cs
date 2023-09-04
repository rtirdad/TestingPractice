using Newtonsoft.Json.Linq;
using System.Security.Cryptography.X509Certificates;
using FluentAssertions;
using System.Linq;
using System.Collections.Generic;
using static TestingPractice.Tests;
using NUnit.Framework;

namespace TestingPractice
{
    public class Tests
    {
        public class MyLinkedList
        { 

            internal interface IMyList<T>
            {
                void Clear();
                void Add(T element);
                int IndexOf(T element);
                bool Contains(T element);
                void Insert(int index, T element);
                void Remove(T element);
                void RemoveAt(int index);
                T this[int index] { get; set; }
                int Count();
            }

            /*[Test]
            public void Clear()
            {
                // Arrange
                var list = new MyLinkedList<int>();
                list.add(1);

                // Act
                list.Clear();

                // Assert
                list.Should().BeEmpty();
            }*/


            [Test]
            public void Clear()
            {
                // Arrange
                var list = new List<int> { 1, 2, 3 };

                // Act
                list.Clear();

                // Assert
                list.Should().BeEmpty();
            }


            [Test]
            public void Add()
            {
                // Arrange
                var list = new List<int> { 1, 2, 3 };

                // Act
                list.Add(4);

                // Assert
                Assert.Contains(4, list);
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
            public void t_this()
            {
                // Arrange
                var list = new List<int> { 1, 2, 3 };
                // Act
                list.Add(123);
                list[0] = 456;
                Console.WriteLine(list[0]);

                // Assert
                list.Should().ContainInOrder(456,2,3);
            }

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
    }
}
