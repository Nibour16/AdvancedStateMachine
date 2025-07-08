using UnityEngine;

public class SampleStateMachine : BaseStateMachine
{
    #region Referencing all state groups
    public readonly SampleStateGroupA sampleStateGroupA = new();
    public readonly SampleStateGroupB sampleStateGroupB = new();
    #endregion

    private void Start()
    {
        SetState(sampleStateGroupA);
    }
}
