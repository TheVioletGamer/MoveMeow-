using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatCaloriesInput : MonoBehaviour
{
    private string input;
    private int calories;
    public void ReadStringInput(string s)
    {
        input = s;
        int.TryParse(input, out calories);
        GlobalVariables.userCalories = calories;
    }
}
