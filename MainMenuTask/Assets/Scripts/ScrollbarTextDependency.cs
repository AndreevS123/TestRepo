using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollbarTextDependency : MonoBehaviour
{
    [SerializeField] private Text myText;//текстовое поле, привязанное к конкретному scrollbar-у
    private string defaultText;//текст в текстовом поле
    private Scrollbar scrollbar;
    void Start()
    {
        defaultText = myText.text.Split(':')[0];
        scrollbar = GetComponent<Scrollbar>();
    }
    public void ChangedValue()
    {
        int intValue = (int)(scrollbar.value * 100);
        //записать новые данные
        myText.text = defaultText + $" {intValue}%";
    }
}
