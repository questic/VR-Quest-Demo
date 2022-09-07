using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnlockChest : MonoBehaviour
{
    public UnityEvent chestUnlocked;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Key"))
        {
            chestUnlocked.Invoke();
        }
    }
}
