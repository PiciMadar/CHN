using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tovabb3 : MonoBehaviour
{
    public Button tovabbGomb;


	void Start()
	{
		tovabbGomb.onClick.AddListener(PalyaBetoltes);
	}

	public static void PalyaBetoltes()
	{
		SceneManager.LoadScene("3");
	}
}
