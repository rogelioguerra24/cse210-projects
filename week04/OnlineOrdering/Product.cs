public class Product {
    private string _name;
    private int _productId;
    private decimal _price;
    private int _quantity;
    public Product (string name, int productId, decimal price, int quantity) {
        _name = name;
        _productId = productId;
        _price = price; 
        _quantity = quantity;
    }
    public decimal ComputeTotal(){
        decimal computeTotal = _price * _quantity;
        return computeTotal;
    }  
    public string GetProductPacking (){
        return $"Product Name: {_name}\nProduct ID: {_productId}";
    }
}