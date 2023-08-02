using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleListScript : MonoBehaviour
{
    [SerializeField] private MenuDataHolder dataHolder;
    void Start()
    {
        Toggle[] childArray = GetComponentsInChildren<Toggle>();
        for (int i = 0; i < childArray.Length; i++)
        {
            childArray[i].isOn = (i == dataHolder.Quality);
        }
        GetComponent<ToggleGroup>().allowSwitchOff = false;
    }
}
