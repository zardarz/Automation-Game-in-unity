using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAble : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D info)
    {
        if (info.gameObject.CompareTag("Player"))
        {
            foreach (Transform item in info.transform.GetChild(2).transform)
            {
                if (item.gameObject.name == gameObject.name)
                {
                    Iamountitem g = item.gameObject.GetComponent<Iamountitem>();
                    g.pick();
                    Destroy(gameObject);
                }
            }
        }
    }
}