using UnityEngine;

public class Step : MonoBehaviour
{
    #region Variables

    [SerializeField] private Sprite _stepBG;
    
    [SerializeField] private string _locationName;
    [TextArea(3, 10)]
    [SerializeField] private string _description;
    [TextArea(3, 10)]
    [SerializeField] private string _answers;

    [SerializeField] private Step[] _nextSteps;

    [SerializeField] private int[] _karmaValues;

    #endregion

    #region Properties

    public string Answers => _answers;
    public int[] KarmaValues => _karmaValues;
    public string Description => _description;
    public string LocationName => _locationName;

    public Sprite StepBG => _stepBG;
    public Step[] NextSteps => _nextSteps;

    #endregion
}