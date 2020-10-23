using Microsoft.VisualStudio.TestTools.UnitTesting;
using Linked_List;

namespace MSTest
{
    [TestClass]
    
    public class UnitTest1
    {
        Linked_List.Node newNode = null;
        [TestInitialize]
        public void SetUp()
        {
            newNode = new Node(56);
        }
        //UC1
        [TestMethod]
        public void ShouldBeAddedToTheLast()
        {
            Linked_List.LinkedListMethods methods = new LinkedListMethods();
            methods.InsertLast(56);
            methods.InsertLast(30);
            Node actual = methods.GetLastNode();
            int expected = 30;
            expected.Equals(actual.data);
        }
        [TestMethod]
        public void ShouldBeAddedToTheFront()
        {
            Linked_List.LinkedListMethods methods = new LinkedListMethods();
            methods.InsertFront(56);
            methods.InsertFront(30);
            Node actual = methods.GetLastNode();
            int expected = 56;
            expected.Equals(actual.data);
        }
    }
}
