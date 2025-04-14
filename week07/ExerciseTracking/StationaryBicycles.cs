public class StationaryBycicles:Activity {
    public StationaryBycicles(int minutes, double speed): base(minutes){
        _speed = speed;
        _distance = _speed * 30/60 * 0.5;
        _pace = 60/_speed;

    }
    
    public override string GetSummary(){
        return $"{Date()} Stationary Bycicles {_minutes} min: Distance: {_distance:F2} km, Speed: {_speed:F2} kph, Pace: {_pace:F2} min per Km";
    }
}