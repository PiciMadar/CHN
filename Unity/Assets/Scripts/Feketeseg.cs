using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Feketeseg : MonoBehaviour
{
    private void Start() {
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1);
		SceneManager.LoadScene("2megnott");
    }
}
