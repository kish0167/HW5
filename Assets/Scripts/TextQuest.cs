using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
    #region Variables

    [SerializeField] private TMP_Text _locationNameLabel;
    [SerializeField] private TMP_Text _descriptionLabel;
    [SerializeField] private TMP_Text _answerLabel;
    [SerializeField] private Image _canvasBG;
    
    [SerializeField] private Step _startStep;

    [SerializeField] private Step _currentStep;

    private int _karma;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        _karma = 0;
        SetCurrentStepAndUpdateUi(_startStep);
    }

    private void Update()
    {
        for (int i = 1; i <= 9; i++)
        {
            if (Input.GetKeyDown(i.ToString()))
            {
                TryGoToNextStep(i);
            }
        }
    }

    #endregion

    #region Private methods

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

        try
        {
            _karma += _currentStep.KarmaValues[nextStepIndex];
        }
        catch (IndexOutOfRangeException)
        {
            Debug.Log("no karma values found on step " + _locationNameLabel.text);
            throw;
        }

        Step nextStep = _currentStep.NextSteps[nextStepIndex];
        SetCurrentStepAndUpdateUi(nextStep);

        if (_currentStep.GetType() == typeof(AutoStep))
        {
            SetCurrentStepAndUpdateUi(((AutoStep)_currentStep).DefineNextStep(_karma));
        }
    }

    private void UpdateUi()
    {
        _locationNameLabel.text = _currentStep.LocationName;
        _descriptionLabel.text = _currentStep.Description;
        _answerLabel.text = _currentStep.Answers;
        _canvasBG.sprite = _currentStep.StepBG;

    }

    #endregion
}