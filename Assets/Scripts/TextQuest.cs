using TMPro;
using UnityEngine;

public class TextQuest : MonoBehaviour
{
    #region Variables

    [SerializeField] private TMP_Text _descriptionLabel;
    [SerializeField] private TMP_Text _answerLabel;
    [SerializeField] private TMP_Text _locationNameLabel;
    
    [SerializeField] private Step _startStep;

    [SerializeField] private Step _currentStep;

    #endregion

    #region Unity lifecycle

    private void Start() { }

    private void Update() { }

    private void SetCurrentStepAndUpdateUi(Step step)
    {
        _currentStep = step;

        UpdateUi();
    }

    private void TryGoToNextStep(int number)
    {
        
        if (number > _currentStep.NextSteps.Length)
        {
            return;
        }

        int nextStepIndex = number - 1;
        Step nextStep = _currentStep.NextSteps[nextStepIndex];
        SetCurrentStepAndUpdateUi(nextStep);
    }

    private void UpdateUi()
    {
        _locationNameLabel.text = _currentStep.Answers;
        _descriptionLabel.text = _currentStep.Description;
        _answerLabel.text = _currentStep.Answers;
        
    }
    
    #endregion
    
}