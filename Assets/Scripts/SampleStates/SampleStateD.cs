using UnityEngine;

public class SampleStateD : BaseState
{
    private SampleStateMachine2 _stateMachine;

    public SampleStateD(SampleStateMachine2 stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public override void EnterState()
    {
        Debug.Log("Enter State D");
    }
    public override void UpdateState()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _stateMachine.SetState(_stateMachine.SampleStateE);
    }
    public override void ExitState()
    {

    }
}
