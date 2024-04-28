using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    public Image origonal;
    public Sprite newSprite;

    public void NewImage()
    {
        origonal.sprite = newSprite;
    }
}
