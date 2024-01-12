using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGen : MonoBehaviour
{
    public GameObject Tree;
    public int amountOfTrees;

    void Start() {
        for(int i = 0; i < amountOfTrees; i++) {
            Vector3 pos = new Vector3(Mathf.Round(Random.insideUnitCircle.x * 50) + transform.position.x, Mathf.Round(Random.insideUnitCircle.y * 50) + transform.position.y, 0);
            Instantiate(Tree, pos, Quaternion.identity);
        }
    }
}