using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tovabb2 : MonoBehaviour
{
	public Button tovabbGomb;


	void Start()
	{
		tovabbGomb.onClick.AddListener(PalyaBetoltes);
	}

	public static void PalyaBetoltes()
	{
		SceneManager.LoadScene("2");
	}
}
