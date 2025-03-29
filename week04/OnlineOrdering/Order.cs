using System.Reflection.Metadata.Ecma335;

///Encapsulation Diagram
public class Order {
    private List<Product> _productsList = new List<Product>();
    private Customer _customer;
    public Order (Customer customer) {
        _customer = customer;
    }
    public void AddNewProducts(Product product) {
        _productsList.Add(product);
    }
    public decimal TotalCost (){
        decimal start = 0;
        foreach (Product product in _productsList) {
            start+=product.ComputeTotal();
        }
        int shippingCost = _customer.LivesInUsa() ? 5 : 35;
        return start + shippingCost;
    }
    public string CreatePackingLabel (){
        List<string> packingLabel = new List<string>(); 

        foreach (Product product in _productsList) {
            packingLabel.Add(product.GetProductPacking()); 
        }

        return string.Join("\n", packingLabel);
    }
    public string CreateShippingLabel (){
        return _customer.GetDisplayCustomer();
    }
    public string GetDisplayOrder(){
        string productDetails = string.Join("\n", _productsList.Select(p => p.GetProductPacking()));

        return $"Order for {_customer.GetDisplayCustomer()}\n" +
            $"Products:\n{productDetails}\n" +
            $"Total: ${TotalCost():F2}\n";
    }
}


