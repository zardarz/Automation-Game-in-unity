using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HotBarUI : MonoBehaviour
{
    public GameObject Items;

    void Update()
    {
        int j = 0;
        foreach (Transform i in Items.transform)
        {
            if (i.gameObject.GetComponent<SpriteRenderer>() != null)
            {
                transform.GetChild(j).gameObject.GetComponent<Image>().sprite = i.gameObject.GetComponent<SpriteRenderer>().sprite;
                
                if (j > Items.transform.childCount - 1) {
                    j = 0;
                } else {
                    j++;
                }
            }
        }
    }
}
