using UnityEngine;

public abstract class BaseState
{   
    public abstract void EnterState();
    public abstract void UpdateState();
    public abstract BaseState SwitchState();
    public abstract void ExitState();
}
