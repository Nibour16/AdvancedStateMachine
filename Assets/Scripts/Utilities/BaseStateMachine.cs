using UnityEngine;

public abstract class BaseStateMachine: MonoBehaviour
{
    [SerializeField] protected BaseStateMachine nextStateMachine;
    protected BaseState CurrentState;

    protected virtual void OnEnable()
    {
        if (nextStateMachine != null)
        {
            if (nextStateMachine.enabled)
            {
                if (nextStateMachine == this)
                    Debug.Log("Next state machine cannot be self");

                nextStateMachine.enabled = false;
            }
        }
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
    }

    public virtual void SwitchStateMachine()
    {
        if (nextStateMachine == null)
            Debug.Log("Variable nextStateMachine is not set!");
        else
        {
            nextStateMachine.enabled = true;
            enabled = false;
        }
    }
}
