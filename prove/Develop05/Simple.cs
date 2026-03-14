public class Simple: Goal
{
    //- _iscomplete:bool
    private bool _iscomplete;

    public Simple(string name, string description, int point): base (name, description, point)
    {
        _iscomplete = false;
    }

        public Simple(string name, string description, int point, bool iscomplete): base (name, description, point)
    {
        _iscomplete = iscomplete;
    }
    //+ Deserialize(parts: string[]): SimpleGoal
    public static Simple Deserialize(string[] parts)
    {
        string name = parts[1];
        string description = parts[2];
        int point = int.Parse(parts[3]);
        bool iscomplete = bool.Parse(parts[4]);
        return new Simple(name, description, point, iscomplete);
    }
    //+ IsComplete(): bool
    public override bool IsComplete()
    {
        return _iscomplete;
    }
    //+ RecordEvent():int
    public override int RecordEvent()
    {
        if(!_iscomplete)
        {
            _iscomplete = true;
            return GetPoint();
        }
        return 0;
    }
    //+ getDisplayString(): string
    public override string getDisplayString()
    {
        string checkbox;
        if(_iscomplete)
        {
            checkbox = "[X]";
        }
        else
        {
            checkbox = "[ ]";
        }
        return $"{checkbox} {GetName()} ({GetDescription()})";
    }
    //+ Serialize(): string
    public override string Serialize()
    {
        return $"Simple|{GetName()}|{GetDescription()}|{GetPoint()}|{_iscomplete}";
    }
}