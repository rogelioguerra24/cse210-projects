using System.Drawing;

public abstract class Goal {
    private string _shortName ;
    private string _description;
    private string _points; 
    public Goal(string shortName, string description, string points) {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public string GetDetailString(){
        return $"{_shortName},{_description},{_points}";
    }
    public abstract string GetStringRepresentation();
}