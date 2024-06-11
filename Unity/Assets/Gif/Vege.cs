using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vege : MonoBehaviour
{
    public Button tovabbGomb;


	void Start()
	{
		tovabbGomb.onClick.AddListener(PalyaBetoltes);
	}

	public static void PalyaBetoltes()
	{
		Application.Quit();
	}
}
