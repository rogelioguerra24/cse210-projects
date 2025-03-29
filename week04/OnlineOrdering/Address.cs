
public class Address {
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private bool _isFromUsa;
    public Address (string streetAddress, string city, string state, string country) {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
        _isFromUsa = country.ToLower() == "usa"; // Determina si es de EE.UU.
    }
    public bool IsFromUsa() {
        return _isFromUsa;
    }
    public string CompleteAddress(){
            return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }
}