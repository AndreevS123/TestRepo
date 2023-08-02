using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollbarTextDependency : MonoBehaviour
{
    [SerializeField] private Text myText;//��������� ����, ����������� � ����������� scrollbar-�
    private string defaultText;//����� � ��������� ����
    private Scrollbar scrollbar;
    void Start()
    {
        defaultText = myText.text.Split(':')[0];
        scrollbar = GetComponent<Scrollbar>();
    }
    public void ChangedValue()
    {
        int intValue = (int)(scrollbar.value * 100);
        //�������� ����� ������
        myText.text = defaultText + $" {intValue}%";
    }
}
