using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ChangeCatSprite : MonoBehaviour
{
    public Image currentImage;
    public Sprite idleCat, buffCat, fatCat, hungryCat, thirstyCat, excerciseNeededCat;
    private  uint timer = 9000;
    private void Update()
    {
        Debug.Log(timer);
        timer--;
        if (GlobalVariables.loggedWater / GlobalVariables.userWater <= 0.50 && GlobalVariables.timer <= 90 * 3/4)
        {
            currentImage.sprite = thirstyCat;
        }
        else if (GlobalVariables.loggedCalories / GlobalVariables.userCalories <= 0.50 && GlobalVariables.timer <= 90 / 2)
        {
            currentImage.sprite = hungryCat;
        }
        else if (GlobalVariables.loggedCalories / GlobalVariables.userCalories >= 1)
        {
            currentImage.sprite = fatCat;
        }
        else if (GlobalVariables.loggedExercise / GlobalVariables.userExcersise >= 1)
        {
            currentImage.sprite = buffCat;
        }
        else if (GlobalVariables.loggedExercise / GlobalVariables.userExcersise <= 0.50 && GlobalVariables.timer <= 90 / 4)
        {
            currentImage.sprite = excerciseNeededCat;
        }
        else if (timer != 0) { 
        {
            currentImage.sprite = idleCat;
        }
            if (timer == 0) {

                if (GlobalVariables.userCalories == GlobalVariables.loggedCalories && GlobalVariables.userWater >= GlobalVariables.loggedWater && GlobalVariables.userExcersise >= GlobalVariables.loggedExercise)
                {
                    SceneManager.LoadScene(9);
                    timer = 90;
                    GlobalVariables.userCalories = 0;
                    GlobalVariables.userWater = 0;
                    GlobalVariables.userExcersise = 0;
                }
                else
                {
                    SceneManager.LoadScene(8);
                    timer = 90;
                    GlobalVariables.userCalories = 0;
                    GlobalVariables.userWater = 0;
                    GlobalVariables.userExcersise = 0;
                }

            }
        }
    }
}
