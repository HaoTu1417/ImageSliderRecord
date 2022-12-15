using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabParent : MonoBehaviour
{

    public GameObject go;

    public ButtonPrefab pf;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            //GameObject go1 = Instantiate(go, transform);
            //go1.name = i.ToString();
          
            ButtonPrefab pf1 = Instantiate(pf, transform);
            
            pf1.name = i.ToString();
           // pf1.handleButtonClicked = (s) => { text.text = s; };

            pf1.handleButtonClicked = HandleTextChange2;
        }
    }

    public void HandleTextChange(string message)
    {
        text.text = message;
    }

    public void HandleTextChange2(string message)
    {
        text.text = message;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
