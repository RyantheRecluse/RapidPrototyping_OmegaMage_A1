using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameEvents
{

    public static event Action<int> OnScoreChange = null;

    public static void ReportOnScoreChange(int newValue)
    {
        if (OnScoreChange != null)
        {
            OnScoreChange(newValue);
        }
    }

}
