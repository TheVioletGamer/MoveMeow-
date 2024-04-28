using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateCalBar : MonoBehaviour
{
    public Image currentImage;
    public Sprite zeroPerc,twentyFivePerc, fiftyPerc, seventyFivePerc, hundredPerc;

    private void UpdateBar()
    {
        Debug.Log(GlobalVariables.loggedCalories);
        Debug.Log(GlobalVariables.userCalories);
        Debug.Log(GlobalVariables.loggedCalories / GlobalVariables.userCalories);

        if (GlobalVariables.loggedCalories / GlobalVariables.userCalories == 0)
        {
            currentImage.sprite = zeroPerc;
        }
        else if (GlobalVariables.loggedCalories / GlobalVariables.userCalories <= 0.25)
        {
            currentImage.sprite = twentyFivePerc;
        }
        else if (GlobalVariables.loggedCalories / GlobalVariables.userCalories <= 0.50)
        {
            currentImage.sprite = fiftyPerc;
        }
        else if (GlobalVariables.loggedCalories / GlobalVariables.userCalories <= 0.75)
        {
            currentImage.sprite = seventyFivePerc;
        }
        else
        {
            currentImage.sprite = hundredPerc;
        }
    }
}

