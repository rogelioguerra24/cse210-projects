public class SimpleGoal: Goal{
    private bool _IsComplete; 
    public SimpleGoal(string name, string description, string points, bool isComplete): base(name, description, points){
        _IsComplete = isComplete;
    }
    public override void RecordEvent(){
        _IsComplete = true;
        Console.WriteLine($"Congratulations! You have earned {_points} points.");
    }
    public override bool IsComplete(){
        return _IsComplete;
    }
    public override string GetStringRepresentation(){
        return $"SimpleGoal,{_shortName},{_description},{_points},{_IsComplete}";
    }
}