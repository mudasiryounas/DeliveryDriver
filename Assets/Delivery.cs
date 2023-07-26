using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            hasPackage = true;
            Destroy(other.gameObject, 0); // delay: 0
            
            // change car color
            spriteRenderer.color = new Color(255, 0, 0, 255);

            Debug.Log("Package picked up");
        }
        else if (other.tag == "Customer" && hasPackage)
        {
            hasPackage = false;
            
            // change car color
            spriteRenderer.color = new Color(200, 200, 255, 255);

            Debug.Log("Package delivered to the customer");
        }
    }
}
