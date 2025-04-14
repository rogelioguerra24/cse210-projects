public class Swimmming:Activity {
    public Swimmming(int minutes, double laps): base(minutes){
        _laps = laps;
        _pace = 60 / _speed;
        _distance = _laps*50/1000;
        _speed = _laps*50/1000*0.62;
    }
    
    public override string GetSummary(){
        return $"{Date()} Swimming {_minutes} min: Distance: {_distance:F2} km, Speed: {_speed:F2} kph, Pace: {_pace:F2} min per Km";
    }
}