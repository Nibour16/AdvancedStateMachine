using UnityEngine;

public class SampleStateB : BaseState
{
    private SampleStateMachine _stateMachine;

    public SampleStateB(SampleStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public override void EnterState()
    {
        Debug.Log("Enter State B");
    }
    public override void UpdateState()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _stateMachine.SetState(_stateMachine.SampleStateC);
    }
    public override void ExitState()
    {
        
    }
}
