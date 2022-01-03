using KoreanStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KoreanStore.Testing
{
    public class TestClass
    {



        [Fact]// FACT is for a single test
        public void Test1()
        {
            //Arrange
            MockDbAccess mockDbAccess = new MockDbAccess();

            //Act
            List<Customer> customers = mockDbAccess.GetAllCustomer();
            //Assert
            Assert.Equal(3, customers.Count);
        }

        [Fact]
        public void Test2()
        {//Arrange
            MockDbAccess mockDbAccess = new MockDbAccess();
            //Act
            List<Product> products = mockDbAccess.GetAllProduct();
            //Assert
            Assert.Equal(4, products.Count);
        }

        [Fact]
        public void Test3()
        {
            //Arrange
            MockDbAccess mockDbAccess = new MockDbAccess();
            //Act
            List<Store> stores = mockDbAccess.GetAllStore();
            //Assert
            Assert.Equal(4, stores.Count);
        }

        [Fact]
        public void Test4()
        {
            //Arrange
            MockDbAccess mockDbAccess = new MockDbAccess();
            //Act
            List<Order> orders = mockDbAccess.GetAllOrder();
            //Assert
            Assert.Equal(1, orders.Count);

        }

    }
}

   
        




