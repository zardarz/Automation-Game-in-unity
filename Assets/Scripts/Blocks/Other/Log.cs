using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Iamountitem {
    void pick();
}

public class Log : MonoBehaviour, Iamountitem
{
    public float Amount;

    public void pick() {
        Amount++;
    }
}