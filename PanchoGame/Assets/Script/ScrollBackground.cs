using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    public float scrollSpeed = 1.0f;
    private void Update()
    {
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);
        if (transform.position.x <= -GetComponent<SpriteRenderer>().bounds.size.x + 0.01)
        {
            transform.position = new Vector3(GetComponent<SpriteRenderer>().bounds.size.x, transform.position.y, transform.position.z);
        }
    }
}
