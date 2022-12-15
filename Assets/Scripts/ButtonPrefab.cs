using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPrefab : MonoBehaviour
{
    public Text text;

    public Action<string> handleButtonClicked;

    public void Print()
    {
        Debug.Log("alo;");
      // text.text = gameObject.name;
        //handleButtonClicked?.Invoke(gameObject.name);
        if (handleButtonClicked != null)
        {
            handleButtonClicked(gameObject.name);
        }
    }

}
