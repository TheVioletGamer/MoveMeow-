using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exerciseLogInput : MonoBehaviour
{
    private string input;
    private int mins;
    public void ReadStringInput(string s)
    {
        input = s;
        int.TryParse(input, out mins);
        GlobalVariables.loggedExercise += mins;
    }

}