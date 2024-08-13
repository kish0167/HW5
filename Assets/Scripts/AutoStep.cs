using UnityEngine;

public class AutoStep : Step
{
    #region Variables

    [SerializeField] private int[] _minKarmaForStep;

    #endregion

    #region Public methods

    public Step DefineNextStep(int karma)
    {
        for (int i = 0; i < _minKarmaForStep.Length; i++)
        {
            if (_minKarmaForStep[i] <= karma)
            {
                return NextSteps[i];
            }
        }

        return this;
    }

    #endregion
}