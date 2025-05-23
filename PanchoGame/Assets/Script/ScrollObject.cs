using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObject : MonoBehaviour
{
    private Rigidbody2D rb2d;
    // Use this for initialization
    void Start()
    {
        rb2d.velocity = new Vector2(GameController.instance.scrollSpeed, 0);
        //rb2d.velocity = Vector2.right * GameController.instance.scrollSpeed;
    }

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.instance.gameOver)
        {
            rb2d.velocity = Vector2.zero;
        }
    }

    private void OnBecameInvisible()
    {
        if (CompareTag("Coin"))
        {
            Destroy(gameObject); // Solo destruye si es una moneda
        }
    }
}
