using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UsernameInputScript : MonoBehaviour
{
    [SerializeField] private MenuDataHolder dataHolder;
    [SerializeField] private Text text;
    void Start()
    {
        GetComponent<InputField>().text = dataHolder.UserName;
    }
    public void OnEndEdit()
    {
        dataHolder.UserName = text.text;
    }
}
