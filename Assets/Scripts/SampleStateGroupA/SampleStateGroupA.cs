public class SampleStateGroupA : BaseStateGroup
{
    #region Keep track of all states in a group
    public static readonly SampleStateA sampleStateA = new();
    #endregion

    public SampleStateGroupA(SampleStateMachine stateMachine) : base(sampleStateA) { }  //Set initial state for the base
}
