using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deletor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(collider.gameObject);
        Debug.Log("Yay");
    }


}