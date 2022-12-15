using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputValidator : MonoBehaviour
{
    [SerializeField] InputField nameInput;
    [SerializeField] InputField birthDayInput;
    [SerializeField] Text errorTxt;
    [SerializeField] string input;
    [SerializeField] GameObject go;

    private void Start()
    {
        IsStringContaintCharacter("abc");//sai
        IsStringContaintCharacter("123");
        nameInput= go.GetComponent<InputField>();
        //object pooling
    }
    public void ValidBirthDay(string input)
    {
        if (input.Length < 1)
        {
            Debug.Log("length <1");
            errorTxt.text = "Ngay thang nam sinh khong dc de trong";
            return;
        }
        // dd/mm/yyyy
        if (input.Length > 10)
        {
            Debug.Log("length >10");
            errorTxt.text = "Ngay thang nam sinh khong hop le";
            return;
        }
        if (IsStringContaintCharacter(input))
        {
            Debug.Log("IsStringContaintCharacter");
            errorTxt.text = "Ngay thang nam sinh ko dc co chu cai";
            return;

        }
        if (IsStringContaintSpecialCharacter(input.Replace("/","")))
        {
            Debug.Log("IsStringContaintCharacter");
            errorTxt.text = "Ngay thang nam sinh ko dc co ky tu dac biet";
            return;
        }

        errorTxt.text = "";
    }
    private bool IsStringContaintCharacter(string input)
    {
        string str = "abcdefgh";
        bool isContaintCharatec = false;
        foreach (char item in input)
        {
            if (str.Contains(item.ToString()))
            {

                isContaintCharatec = true;
            }
        }

        return isContaintCharatec;
    }
    private bool IsStringContaintSpecialCharacter(string input)
    {
        Debug.Log("special: " + input);
        string str = "abcdefgh";
        string num = "0123456789";
        bool isContaintSpecialCharacter = false;
        foreach (var item in input)
        {
            if (!str.Contains(item.ToString()) && !num.Contains(item.ToString()))
            {

                isContaintSpecialCharacter = true;
            }
        }

        return isContaintSpecialCharacter;
    }

    private void Update()
    {
        string input = nameInput.GetComponent<InputField>().text;
    }
}
