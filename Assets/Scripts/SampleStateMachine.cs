public class SampleStateMachine : BaseStateMachine
{
    #region Keep track of all state groups
    private SampleStateA _sampleStateA;
    private SampleStateB _sampleStateB;
    private SampleStateC _sampleStateC;
    #endregion

    #region Referencing all state groups
    public SampleStateA SampleStateA => _sampleStateA;
    public SampleStateB SampleStateB => _sampleStateB;
    public SampleStateC SampleStateC => _sampleStateC;
    #endregion

    private void Awake()
    {
        _sampleStateA = new(this);
        _sampleStateB = new(this);
        _sampleStateC = new(this);
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        SetState(SampleStateA);
    }
}
