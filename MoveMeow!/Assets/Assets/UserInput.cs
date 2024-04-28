using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    static int userCalories = 0;
    public void setCalories(int caloriesAmount)
    {
        userCalories = caloriesAmount;
    }
}
