using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventVegrehajtoGifhez : MonoBehaviour
{
	
	public GameObject gombok;
	
	void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(ExampleCoroutine());
    }
	
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(2);
		gombok.SetActive(true);
    }
}
