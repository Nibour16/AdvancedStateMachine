using UnityEngine;

public class BaseStateMachine: MonoBehaviour
{
    protected BaseState CurrentState;

    public virtual void SetState(BaseStateGroup newStateGroup)
    {
        SetState(newStateGroup.initialState);
    }

    public virtual void SetState(BaseState newState)
    {
        // exit the current state if it is available
        CurrentState?.ExitState();
        // Set the new state
        CurrentState = newState;
        // Enter the new state
        CurrentState.EnterState();
    }

    public virtual void Update()
    {
        CurrentState?.UpdateState();

        #region Switch state
        BaseState newState = CurrentState?.SwitchState();
        
        if (newState != null)
            SetState(newState);
        #endregion
    }
}
