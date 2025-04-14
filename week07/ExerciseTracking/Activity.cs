public abstract class Activity{
    protected int _minutes;
    protected double _distance;
    protected double _speed;
    protected double _laps;
    protected double _pace;
    public Activity(int minutes){
        _minutes = minutes;
    }
    protected string Date(){
        DateTime today = DateTime.Now;
        return today.ToString("dd MMM yyyy", new System.Globalization.CultureInfo("en-US"));
    }
    public abstract string GetSummary();
}