
public class Checklist: Goal
{
    //- _targetcount:int
    private int _targetcount;
    //- _currentcount: int
    private int _currentcount;
    //- _bonuspoint: int
    private int _bonuspoint;

public Checklist(string name, string description, int point, int targetcount, int bonuspoint): base (name, description, point)
    {
        _bonuspoint = bonuspoint;
        _currentcount = 0;
        _targetcount = targetcount;
    }

public Checklist(string name, string description, int point, int targetcount, int currentcount, int bonuspoint): base (name, description, point)
    {
        _bonuspoint = bonuspoint;
        _currentcount = currentcount;
        _targetcount = targetcount;
    }

    //+ Deserialize(parts: string[]): CheckListGoal
       public Checklist Deserialize(string[] parts)
    {
        string name = parts[1];
        string description = parts[2];
        int point = int.Parse(parts[3]);
        int targetcount = int.Parse(parts[4]);
        int currentcount = int.Parse(parts[5]);
        int bonuspoint = int.Parse(parts[6]);
        return new Checklist(name, description, point, targetcount, currentcount, bonuspoint);
    }

//+ IsComplete(): bool
public override bool IsComplete()
{
    return _currentcount >= _targetcount;
}
//+ RecordEvent():int
public override int RecordEvent()
{
    if(_currentcount < _targetcount)
    {
        _currentcount++;
        if(_currentcount == _targetcount)
        {
            return GetPoint() + _bonuspoint;
        }
        return GetPoint();
    }
    return 0;
}
//+ getDisplayString(): string
public override string getDisplayString()
{
    string status = IsComplete() ? "[X]" : "[ ]";
    return $"{status} {GetName()} ({GetDescription()}) -- Completed {_currentcount}/{_targetcount} times";
}
//+ Serialize(): string
public override string Serialize()
{
    return $"Checklist|{GetName()}|{GetDescription()}|{GetPoint()}|{_targetcount}|{_currentcount}|{_bonuspoint}";
}
}

    




