using System.Security.Cryptography.X509Certificates;

namespace TestingPractice
{
    public class Tests
    {
        public interface IMyList<T> { 
        
            void Add(T item);
        }

        [Test]
        public void Clear()
        {
            // Arrange
            var list = new List<int> { 1, 2, 3 };

            // Act
            list.Clear();

            // Assert
            Assert.IsEmpty(list);
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
        public void IndexOf()
        {
            // Arrange
            var list = new List<int> { 1, 2, 3 };

            // Act
            list.IndexOf(4);

            // Assert
           
        }

        [Test]
        public void BoolContains()
        {
            // Arrange
            var list = new List<int> { 1, 2, 3 };

            // Act
            list.Add(4);

            // Assert
            Assert.Contains(4, list);
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