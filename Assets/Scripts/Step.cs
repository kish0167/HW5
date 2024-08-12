using UnityEngine;

public class Step : MonoBehaviour
{
    #region Variables

    [SerializeField] private string _locationName;
    [TextArea(3, 10)]
    [SerializeField] private string _description;
    [TextArea(3, 10)]
    [SerializeField] private string _answers;

    [SerializeField] private Step[] _nextSteps;

    #endregion

    #region Properties

    public string Answers => _answers;
    public string Description => _description;

    public string LocationName => _locationName;
    public Step[] NextSteps => _nextSteps;

    #endregion
}