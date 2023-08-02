using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MenuStorage", menuName = "MenuStorage")]

public class MenuDataHolder : ScriptableObject
{
    public enum Qualities { High, Medium, Low } //Наверное нужно, чтобы enum был известен всем объектам, иначе не имеет смыслаS

    [SerializeField] private string userName;
	[SerializeField] public string UserName
	{
		get { return userName; }
		set 
		{
			if (value != null)//добавить проверку на валидность
				userName = value;
		}
	}

    [SerializeField] private float musicLoud;
	[SerializeField] public float MusicLoud
	{
		get { return musicLoud; }
		set
		{
			if (value>=0 && value<=1)
			musicLoud = value;
		}
	}

    [SerializeField] private float noiseLoud;
    [SerializeField] public float NoiseLoud
    {
        get { return noiseLoud; }
        set
        {
            if (value >= 0 && value <= 1)
                noiseLoud = value;
        }
    }

    [SerializeField] private Qualities quality;
	public int Quality
    {
		get { return (int)quality; }
		set { quality = (Qualities)value; }
	}
	/*
	режим игры
	настройки управления
	*/
}
