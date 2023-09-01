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
            public void AddElement_to_list()
            {
                // Arrange
                var list = new List<int> { 1, 2, 3 };

                // Act
                list.Add(4);

                // Assert
                Assert.Contains(4, list);
            }

            [Test]
            public void IndexOf_Should_find_element_If_element_does_not_exist_return_negative_one()
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
            public void if_contain_element_return_true()
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
            public void remove_element()
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
            public void insert_element_should_be_inserted_and_in_right_order()
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
            public void RemoveAt_Should_Remove_element_AtIndex()
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
            public void Count_elements()
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
