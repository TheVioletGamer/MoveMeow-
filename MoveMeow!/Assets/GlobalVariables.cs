using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalVariables : MonoBehaviour
{
    //users goals
    public static double userCalories = 1;
    public static double userWater = 1;
    public static double userExcersise = 1;

    //logged daily updates by the user
    public static int loggedCalories = 0;
    public static int loggedWater = 0;
    public static int loggedExercise = 0;

    //Timer Var
    public static int timer = 90;

    private void tick() 
    {
        timer--;
        if(userCalories == loggedCalories &&  userWater >= loggedWater && userExcersise >= loggedExercise)
        {
            //Change scene SceneManager.LoadScene(sceneBuilderIndex: <Index here>);
            timer = 90;
            userCalories = 0;
            userWater = 0;
            userExcersise = 0;
        } else 
        {
            //Change scene SceneManager.LoadScene(sceneBuilderIndex: <Index here>);
            timer = 90;
            userCalories = 0;
            userWater = 0;
            userExcersise = 0;
        }
        
    }
}
