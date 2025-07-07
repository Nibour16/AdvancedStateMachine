using UnityEngine;

public class SampleStateE : BaseState
{
    public override void EnterState()
    {
        Debug.Log("Enter State E");
    }
    public override void UpdateState()
    {

    }

    public override BaseState SwitchState()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            return SampleStateGroupB.sampleStateF;

        return null;
    }
    public override void ExitState()
    {

    }
}
