using UnityEngine;

public class SampleStateA : BaseState
{
    public override void EnterState()
    {
        Debug.Log("Enter State A");
        TestScript.instance.PrintLog();
    }
    public override void UpdateState()
    {
        
    }

    public override BaseState SwitchState()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            return SampleStateGroupA.sampleStateB;

        return null;
    }
    public override void ExitState()
    {
        
    }
}
