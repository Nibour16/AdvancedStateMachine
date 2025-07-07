using UnityEngine;

public class SampleStateB : BaseState
{
    public override void EnterState()
    {
        Debug.Log("Enter State B");
    }
    public override void UpdateState()
    {

    }
    public override BaseState SwitchState()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            return SampleStateGroupA.sampleStateC;

        return null;
    }
    public override void ExitState()
    {
        
    }
}
