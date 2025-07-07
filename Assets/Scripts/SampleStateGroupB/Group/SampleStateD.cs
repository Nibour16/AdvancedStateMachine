using UnityEngine;

public class SampleStateD : BaseState
{
    public override void EnterState()
    {
        Debug.Log("Enter State D");
    }
    public override void UpdateState()
    {

    }

    public override BaseState SwitchState()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            return SampleStateGroupB.sampleStateE;

        return null;
    }
    public override void ExitState()
    {

    }
}
