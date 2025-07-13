using UnityEngine;

public class SampleStateE : BaseState
{
    private SampleStateMachine2 _stateMachine;

    public SampleStateE(SampleStateMachine2 stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public override void EnterState()
    {
        Debug.Log("Enter State E");
    }
    public override void UpdateState()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _stateMachine.SwitchStateMachine();
    }
    public override void ExitState()
    {

    }
}
