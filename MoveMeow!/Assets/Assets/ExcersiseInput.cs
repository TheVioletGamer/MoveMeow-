using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class ExcersiseInput : MonoBehaviour
{


    private string input;
    private int minutes;
    public void ReadStringInput(string s)
    {
        input = s;
        int.TryParse(input, out minutes);
        GlobalVariables.userExcersise = minutes;
    }
}
