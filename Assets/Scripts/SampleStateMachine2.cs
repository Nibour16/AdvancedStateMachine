public class SampleStateMachine2 : BaseStateMachine
{
    #region Keep track of all state groups
    private SampleStateD _sampleStateD;
    private SampleStateE _sampleStateE;
    #endregion

    #region Referencing all state groups
    public SampleStateD SampleStateD => _sampleStateD;
    public SampleStateE SampleStateE => _sampleStateE;
    #endregion

    private void Awake()
    {
        _sampleStateD = new(this);
        _sampleStateE = new(this);
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        SetState(SampleStateD);
    }
}
