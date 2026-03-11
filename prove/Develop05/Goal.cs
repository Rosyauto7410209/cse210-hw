public abstract class Goal
{
 //# _name: string
 private string _name;
 //# _description: string
 private string _description;
 //# _point: int
 private int _point;
public Goal(string name, string description, int point)
{
    _name = name;
    _description = description;
    _point = point;
}
//+ GetName(): string
public string GetName()
{
return _name;
}

//+ GetDescription(): string
public string GetDescription()
{
    return _description;
}
//+ GetPoint(): int
public int GetPoint()
{
    return _point;
}
//+ IsComplete(): bool
public abstract bool IsComplete();
//+ RecordEvent():int
public abstract int RecordEvent();
//+ getDisplayString(): string
public abstract string getDisplayString();
//+ Serialize(): string
public abstract string Serialize();
}