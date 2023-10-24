using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool vivo = true;
    private Rigidbody2D rb2d;
    public float upForce;
    private Animator anim;

    private RotateBird rotateBird;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Start()
    {

    }

    private void Update()
    {
        if (vivo == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(Vector2.up * upForce);
                anim.SetTrigger("Fly");
                SoundSystem.instance.PlayFlap();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        vivo = false;
        anim.SetTrigger("Die");
        GameController.instance.BirdDie();
        rb2d.velocity = Vector2.zero;
        SoundSystem.instance.PlayHit();
        rotateBird.enabled = false;
    }
}
