public class Running:Activity {
    public Running(int minutes, double distance): base(minutes){
        _distance = distance;
        _speed = _distance/_minutes* 60;
        _pace = _minutes / _distance;
    }
    public override string GetSummary(){
        return $"{Date()} Running {_minutes} min: Distance: {_distance:F2} km, Speed: {_speed:F2} kph, Pace: {_pace:F2} min per Km";
    }
}