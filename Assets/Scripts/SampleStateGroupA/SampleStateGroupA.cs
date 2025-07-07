public class SampleStateGroupA : BaseStateGroup
{
    #region Keep track of all states in a group
    public static readonly SampleStateA sampleStateA = new();
    public static readonly SampleStateB sampleStateB = new();
    public static readonly SampleStateC sampleStateC = new();
    #endregion

    public SampleStateGroupA() : base(sampleStateA) { }  //Set initial state for the base
}
