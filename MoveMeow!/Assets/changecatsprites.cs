using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeCatSprite : MonoBehaviour
{
    public Image currentImage;
    public Sprite idleCat, buffCat, fatCat, hungryCat, thirstyCat, excerciseNeededCat;
    public static int timer = 90;
    private void Update()
    {
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
                    //Change scene SceneManager.LoadScene(sceneBuilderIndex: <Index here>);
                     timer = 90;
                    GlobalVariables.userCalories = 0;
                    GlobalVariables.userWater = 0;
                    GlobalVariables.userExcersise = 0;
                }
                else
                {
                    //Change scene SceneManager.LoadScene(sceneBuilderIndex: <Index here>);
                    timer = 90;
                    GlobalVariables.userCalories = 0;
                    GlobalVariables.userWater = 0;
                    GlobalVariables.userExcersise = 0;
                }

            }
        }
    }
}
