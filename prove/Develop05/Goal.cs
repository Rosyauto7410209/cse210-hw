public abstract class Goal
{
 private string _name;
 private string _description;
 private int _point;
public Goal(string name, string description, int point)
{
    _name = name;
    _description = description;
    _point = point;
}

public string GetName()
{
return _name;
}


public string GetDescription()
{
    return _description;
}

public int GetPoint()
{
    return _point;
}

public abstract bool IsComplete();

public abstract int RecordEvent();

public abstract string getDisplayString();

public abstract string Serialize();
}


//Abstract Class Goal{
//# _name: string
//# _description: string
//# _point: int
//+ GetName(): string
//+ GetDescription(): string
//+ GetPoint(): int
//+ IsComplete(): bool
//+ RecordEvent():int
//+ getDisplayString(): string
//+ Serialize(): string
