public class SampleStateGroupB : BaseStateGroup
{
    #region Keep track of all states in a group
    public static readonly SampleStateD sampleStateD = new();
    public static readonly SampleStateE sampleStateE = new();
    public static readonly SampleStateF sampleStateF = new();
    #endregion

    public SampleStateGroupB() : base(sampleStateD) { }  //Set initial state for the base
}
