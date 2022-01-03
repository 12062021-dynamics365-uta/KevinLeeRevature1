using System.Collections.Generic;
using System.Data.SqlClient;
namespace KoreanStore.Domain
{
    internal interface IMapper
    {
        List<Customer> EntityToCustomerList(SqlDataReader dr);
        List<Store> EntityToStoreList(SqlDataReader dr);
        List<Product> EntityToProductList(SqlDataReader dr);
        List<Order> EntityToOrderList(SqlDataReader dr);
    }
}