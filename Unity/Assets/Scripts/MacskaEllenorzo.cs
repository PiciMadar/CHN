using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MacskaEllenorzo : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Macska"))
        {
            Destroy(collision.gameObject);
        }
    }


}
