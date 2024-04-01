using Services;

namespace Test
{
    public class Tests
    {

        private IProductService _productService;

        [SetUp]
        public void Setup()
        {
            _productService = new ProductService(); 
        }

        [Test]
        public void VerifyProductsQuantity()
        {
            var list = _productService.GetProducts();
            Assert.AreEqual(3, list.Count);
        } 
    }
}