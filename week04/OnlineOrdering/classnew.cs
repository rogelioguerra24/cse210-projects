using System.Reflection.Metadata.Ecma335;

///Encapsulation Diagram
public class Order {
    private List<Product> _commentsArray = new List<Product>();
    public float TotalCost (){
        return 3;
    }
    public string CreatePackingLabel (){
        // public string _name;
        //public int _productId;
        return "";

    }
    public string CreateShippingLabel (){
        //public string _name;
        //public string _address;
        return "";
    }

}
public class Product {
    private string _name;
    private int _productId;
    private float _price;
    private int _quantity;
    public float ComputeTotal(){
        return 0;
    }  
}
public class Customer {
    private string _name;
    private Address _address;
    public bool IsFromUsa() {
        return true;
    }
    
}
public class Address {
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    public bool IsFromUsa() {
        return true;
    }
    public string CompleteAddress(){
        return "";
    }
}