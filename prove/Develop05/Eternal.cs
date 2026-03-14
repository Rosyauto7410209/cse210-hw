
public class Eternal: Goal
{
public Eternal(string name, string description, int point): base (name, description, point){}

    //+ Deserialize(parts: string[]): EternalGoal
   public static Eternal Deserialize(string[] parts)
    {
        string name = parts[1];
        string description = parts[2];
        int point = int.Parse(parts[3]);
        bool iscomplete = bool.Parse(parts[4]);
        return new Eternal(name, description, point);
    }


//+ IsComplete(): bool
public override bool IsComplete()
{
    return false;
}

//+ RecordEvent():int
public override int RecordEvent()
{
    return GetPoint();
}

//+ getDisplayString(): string
public override string getDisplayString()
{
    return $"[] {GetName()} ({GetDescription()})";
}

//+ Serialize(): string
public override string Serialize()
{
    return $"Eternal|{GetName()}|{GetDescription()}|{GetPoint()}";
}
}