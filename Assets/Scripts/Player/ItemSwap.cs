using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSwap : MonoBehaviour
{
    public int selectedItem = 0;

    void Start() {
        SelectItem();
    }

    void Update() {

        int previousSelectedItem = selectedItem;

        if (Input.GetAxis("Mouse ScrollWheel") > 0f) {
            if (selectedItem >= transform.childCount - 1) {
                selectedItem = 0;
            } else {
                selectedItem++;
            }
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0f) {
            if (selectedItem <= 0) {
                selectedItem = transform.childCount -1;
            } else {
                selectedItem--;
            }
        }

        if (previousSelectedItem == selectedItem) {
            SelectItem();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            selectedItem = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2) {
            selectedItem = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && transform.childCount >= 3) {
            selectedItem = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && transform.childCount >= 4) {
            selectedItem = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && transform.childCount >= 5) {
            selectedItem = 4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6) && transform.childCount >= 6) {
            selectedItem = 5;
        }
    }

    void SelectItem() {

        int i = 0;
        foreach(Transform item in transform) {
            if (i == selectedItem) {
                item.gameObject.SetActive(true);
            }else {
                item.gameObject.SetActive(false);
            }

            i++;
        }
    }
}