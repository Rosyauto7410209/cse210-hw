// This is the code to a uml diagram for this program.

@startuml
Class Program {
+ Main() 
}

Abstract Class Goal{
# _name: string
# _description: string
# _point: int
+ GetName(): string
+ GetDescription(): string
+ GetPoint(): int
+ IsComplete(): bool
+ RecordEvent():int
+ getDisplayString(): string
+ Serialize(): string
}


Class GoalManager
{
- _goals: List<Goal>
 - _score:int
 + Start():void
 - CreateGoal():void
 - ListGoals():void
 - RecordEvents():void
 - SaveEvents(filename:string):void
 - LoadEvents(filename:string):void
 + GetScore(): int
}

Program --> GoalManager
GoalManager *-- Goal

Class Simple
{
- _iscomplete:bool
+ Deserialize(parts: string[]): SimpleGoal
+ IsComplete(): bool
+ RecordEvent():int
+ getDisplayString(): string
+ Serialize(): string
}
Goal <|-- Simple

Class Eternal{

+ Deserialize(parts: string[]): EternalGoal
+ IsComplete(): bool
+ RecordEvent():int
+ getDisplayString(): string
+ Serialize(): string
}

Goal<|-- Eternal

Class Checklist{
- _targetcount:int
- _currentcount: int
- _bonuspoint: int
+ Deserialize(parts: string[]): CheckListGoal
+ IsComplete(): bool
+ RecordEvent():int
+ getDisplayString(): string
+ Serialize(): string
}
Goal<|-- Checklist


@enduml