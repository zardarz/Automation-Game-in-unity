using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform player;
    private SpriteRenderer sprite;
    public ItemSwap item;

    void Update() {
        if (transform.childCount > item.selectedItem) {
            Transform selectedChild = transform.GetChild(item.selectedItem);
            SpriteRenderer childSpriteRenderer = selectedChild.GetComponent<SpriteRenderer>();

            if (childSpriteRenderer != null) {
                sprite = childSpriteRenderer;
            }
        }
    }

    void FixedUpdate()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        transform.position = player.position;

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;

        if (angle > 90 || angle < -90)
        {
            sprite.flipY = true;
        }
        else
        {
            sprite.flipY = false;
        }
    }
}