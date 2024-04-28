using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterInput : MonoBehaviour
{
    private string input;
    private int water;
    public void ReadStringInput(string s)
    {
        input = s;
        int.TryParse(input, out water);
        GlobalVariables.userExcersise = water;
    }

}
