using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calorieLogInput : MonoBehaviour
{
    private string input;
    private int cal;
    public void ReadStringInput(string s)
    {
        input = s;
        int.TryParse(input, out cal);
        GlobalVariables.loggedCalories += cal;
        Debug.Log(cal);
    }

}
