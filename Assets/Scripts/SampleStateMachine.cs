public class SampleStateMachine : BaseStateMachine
{
    #region Keep track of all state groups
    private SampleStateGroupA _sampleStateGroupA;
    #endregion

    #region Referencing all state groups
    public SampleStateGroupA sampleStateGroupA => _sampleStateGroupA;
    #endregion

    private void Awake()
    {
        _sampleStateGroupA = new(this);
    }

    private void Start()
    {
        SetState(sampleStateGroupA);
    }
}
