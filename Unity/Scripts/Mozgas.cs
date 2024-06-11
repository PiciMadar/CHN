using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mozgas : MonoBehaviour
{

    public float gyorsasag = 8f;
    private float horizontal;
    private float vertical;
    [SerializeField] private Rigidbody2D rb;

    public Animator animator;

    private bool animalva = true;
    public bool neLegyen = false;

    private void Update() {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (!neLegyen)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                try
                {
                    animator.Play("Futas");
                }
                catch (System.Exception)
                {
                }

            }
        }

        





    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * gyorsasag, vertical * gyorsasag);
        

    }


}