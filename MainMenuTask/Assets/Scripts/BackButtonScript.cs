using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButtonScript : MonoBehaviour
{
    [SerializeField] private GameObject currentMenu;//где мы сейчас
    [SerializeField] private GameObject mainMenu;//куда вернуться
    void Awake()
    {
        currentMenu = gameObject.transform.parent.gameObject;
        mainMenu.SetActive(false);
    }
    public void OnButtonClicked()
    {
        currentMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
