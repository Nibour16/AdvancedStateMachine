using UnityEngine;

public class SampleStateF : BaseState
{
    public override void EnterState()
    {
        Debug.Log("Enter State F");
    }
    public override void UpdateState()
    {

    }

    public override BaseState SwitchState()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            return SampleStateGroupA.sampleStateA;

        return null;
    }
    public override void ExitState()
    {

    }
}
