using System.Reflection.Metadata;

public class Customer {
    private string _name;
    private Address _address;
    public Customer (string name, Address address) {
        _name = name;
        _address = address;
    }
    public bool LivesInUsa() {
        return _address.IsFromUsa(); 
    }
    public string GetDisplayCustomer(){
        return $"Customer Name: {_name}\nAddress: {_address.CompleteAddress()}\nHe is from USA: {LivesInUsa()}";
    }
}