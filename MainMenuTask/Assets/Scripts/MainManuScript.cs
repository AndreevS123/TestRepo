using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManuScript : MonoBehaviour
{
    public void Play()
    {
        //Сохранить настройки в статический класс
        SceneManager.LoadScene("Имя");
    }
}
