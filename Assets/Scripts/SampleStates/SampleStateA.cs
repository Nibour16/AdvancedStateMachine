using UnityEngine;

public class SampleStateA : BaseState
{
    private SampleStateMachine _stateMachine;    

    public SampleStateA(SampleStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public override void EnterState()
    {
        Debug.Log("Enter State A");
    }
    public override void UpdateState()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _stateMachine.SetState(_stateMachine.SampleStateB);
    }
    public override void ExitState()
    {
        
    }
}
