namespace Latihan2.Case
{
    public class FirstDefaultCase
    {
        private readonly DataProduct _product;

        public FirstDefaultCase(DataProduct product)
        {
            _product = product;
        }

        public DataProduct.Product GetProduct_Equals_PlusWhere (string namaProduct)
        {
            return _product.GetProducts().Where(a => a.ProductName.Equals(namaProduct)).FirstOrDefault() ?? new DataProduct.Product();
        }

        public DataProduct.Product GetProduct_Equals_NoWhere(string namaProduct)
        {
            return _product.GetProducts().FirstOrDefault(a => a.ProductName.Equals(namaProduct)) ?? new DataProduct.Product();
        }

        public DataProduct.Product GetProduct_EqualsWithStringComparison_PlusWhere(string namaProduct)
        {
            return _product.GetProducts().Where(a => a.ProductName.Equals(namaProduct, StringComparison.OrdinalIgnoreCase)).FirstOrDefault() ?? new DataProduct.Product();
        }

        public DataProduct.Product GetProduct_EqualsWithStringComparison_NoWhere(string namaProduct)
        {
            return _product.GetProducts().FirstOrDefault(a => a.ProductName.Equals(namaProduct, StringComparison.OrdinalIgnoreCase)) ?? new DataProduct.Product();
        }

        public DataProduct.Product GetProduct_AssignementOperator_PlusWhere (string namaProduct)
        {
            return _product.GetProducts().Where(a => a.ProductName == namaProduct).FirstOrDefault() ?? new DataProduct.Product();
        }

        public DataProduct.Product GetProduct_AssignementOperator_NoWhere(string namaProduct)
        {
            return _product.GetProducts().FirstOrDefault(a => a.ProductName == namaProduct) ?? new DataProduct.Product();
        }
    }
}
