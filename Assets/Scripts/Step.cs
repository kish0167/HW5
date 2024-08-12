using UnityEngine;

public class Step : MonoBehaviour
{
    #region Unity lifecycle

    [SerializeField] private string _locationName;
    [TextArea(3, 10)]
    [SerializeField] private string _answers;
    [TextArea(3, 10)]
    [SerializeField] private string _description;

    [SerializeField] private Step[] _nextSteps;
    
    public string LocationName => _locationName;
    public string Answers => _answers;
    public string Description => _description;
    public Step[] NextSteps => _nextSteps;

    #endregion
}