using Newtonsoft.Json.Linq;
using System.Security.Cryptography.X509Certificates;
using FluentAssertions;
using System.Linq;

namespace TestingPractice
{
    public class Tests
    {
        public interface IMyList<T> {

            void Clear();
            void Add(T item);
            void IndexOf();
            bool Contains();
        }

        [Test]
        public void Clear_All_Elements_From_List()
        {
            // Arrange
            var list = new List<int> { 1, 2, 3 };

            // Act
            list.Clear();

            // Assert
            list.Should().BeEmpty();
        }

        [Test]
        public void AddElement()
        {
            // Arrange
            var list = new List<int> { 1, 2, 3 };

            // Act
            list.Add(4);

            // Assert
            Assert.Contains(4, list);
        }

        [Test]
        public void IndexOf_element()
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
        public void if_contain_return_true()
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

        /*[Test]
        public void Remove_ShouldRemoveItemFromList()
        {
            // Arrange
            IList<string> list = new MyList<string>();
            list.Add("apple");
            list.Add("banana");
            list.Add("cherry");

            // Act
            bool removedBanana = list.Remove("banana");
            bool removedGrape = list.Remove("grape");

            // Assert
            removedBanana.Should().BeTrue(); // "banana" was in the list and removed
            removedGrape.Should().BeFalse(); // "grape" was not in the list, so not removed

            // Verify that "banana" is no longer in the list
            list.Contains("banana").Should().BeFalse();
            list.Count.Should().Be(2); // Only two items remaining in the list
        }*/

        [Test]
        public void remove()
        {
            // Arrange
            var list = new List<int> { 1, 2, 3 };

            // Act
            bool removedNum3 = list.Remove(2);

            // Assert
            list.Contains(2).Should().BeFalse();
            list.Count.Should().Be(2);
        }





        /*[Test]
        public void if__element_is_pushed_to_stack_isEmpty_should_be_false()
        {

            // Arrange
            Stack<int> myStack = new Stack<int>();
            // Act
            myStack.Push(1);
            myStack.Push(1);

            // Assert
            Assert.IsEmpty(myStack);

        }

        /*[Test]
       public void if_one_element_is_pushed_to_stack_isEmp()
       {

           // Arrange
           Stack<int> myStack = new Stack<int>();
           // Act
           myStack.Push(1);

           // Assert
           Assert.IsEmpty(myStack);

       }*/
    }
}
