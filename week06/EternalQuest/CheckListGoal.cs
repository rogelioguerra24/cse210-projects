public class CheckListGoal: Goal{
    protected int _amountCompleted;
    private int _target;
    private int _bonus; 

    public CheckListGoal(string name, string description, string points, int target, int bonus, int autoCompleted): base(name, description, points){
        _target = target;
        _bonus = bonus;
        _amountCompleted = autoCompleted;
    }
    public override void RecordEvent(){
        _amountCompleted++;
        if (_amountCompleted<_target){Console.WriteLine($"Congratulations! You have earned {_points} points.");}
        if (_amountCompleted == _target){Console.WriteLine($"Congratulations! You have earned {int.Parse(_points) + _bonus} points.");}
        
    }
  
    public override bool IsComplete(){
        return _amountCompleted == _target;
    }
    public override string GetStringRepresentation(){
    return $"CheckListGoal,{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
}
}