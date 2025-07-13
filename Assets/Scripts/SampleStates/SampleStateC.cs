using UnityEngine;

public class SampleStateC : BaseState
{
    private SampleStateMachine _stateMachine;

    public SampleStateC(SampleStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public override void EnterState()
    {
        Debug.Log("Enter State C");
    }
    public override void UpdateState()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _stateMachine.SetState(_stateMachine.SampleStateA);
    }
    public override void ExitState()
    {

    }
}
