using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private static int pwrUpCount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pwrUpCount++;
            Debug.Log("Power-Up count: " + pwrUpCount);
            Destroy(gameObject);
        }
    }
}
