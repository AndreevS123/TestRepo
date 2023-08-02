using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundScrollbar : MonoBehaviour
{
    [SerializeField] private MenuDataHolder dataHolder;
    [SerializeField] private Text myText;//��������� ����, ����������� � ����������� scrollbar-�
    private delegate void ChangeSoundDataDelegate(float value);
    private ChangeSoundDataDelegate changeSoundData;
    private string defaultText;//����� � ��������� ����
    private Scrollbar scrollbar;
    void Start()
    {
        defaultText = myText.text.Split(':')[0];
        scrollbar = GetComponent<Scrollbar>();
        float value = 0;
        if (gameObject.name == "MusicScrollBar")
        {
            changeSoundData = ChangeMusicLoudData;
            value = dataHolder.MusicLoud;
        }
        else if (gameObject.name == "NoiseScrollBar")
        {
            changeSoundData = ChangeNoiseLoudData;
            value = dataHolder.NoiseLoud;
        }
        scrollbar.value = value;
    }
    public void ChangedValue()
    {
        changeSoundData(scrollbar.value);
        int intValue = (int)(scrollbar.value * 100);
        myText.text = defaultText + $" {intValue}%";
    }
    private void ChangeMusicLoudData(float value) => dataHolder.MusicLoud = value;
    private void ChangeNoiseLoudData(float value) => dataHolder.NoiseLoud = value;
}
