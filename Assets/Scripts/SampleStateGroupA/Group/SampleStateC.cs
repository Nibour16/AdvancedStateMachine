using UnityEngine;

public class SampleStateC : BaseState
{
    public override void EnterState()
    {
        Debug.Log("Enter State C");
    }
    public override void UpdateState()
    {

    }

    public override BaseState SwitchState()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            return SampleStateGroupB.sampleStateD;

        return null;
    }
    public override void ExitState()
    {

    }
}
