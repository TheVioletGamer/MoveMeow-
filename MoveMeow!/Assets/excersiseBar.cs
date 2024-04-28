using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class excersiseBar : MonoBehaviour
{
    public Image currentImage;
    public Sprite zeroPerc, twentyFivePerc, fiftyPerc, seventyFivePerc, hundredPerc;

    private void UpdateBar()
    {
        if (GlobalVariables.loggedExercise / GlobalVariables.userExcersise == 0)
        {
            currentImage.sprite = zeroPerc;
        }
        else if (GlobalVariables.loggedExercise / GlobalVariables.userExcersise <= 0.25)
        {
            currentImage.sprite = twentyFivePerc;
        }
        else if (GlobalVariables.loggedExercise / GlobalVariables.userExcersise <= 0.50)
        {
            currentImage.sprite = fiftyPerc;
        }
        else if (GlobalVariables.loggedExercise / GlobalVariables.userExcersise <= 0.75)
        {
            currentImage.sprite = seventyFivePerc;
        }
        else
        {
            currentImage.sprite = hundredPerc;
        }
    }
}
