using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPad : MonoBehaviour
{
    private static string _correctCode = "322";
    private static string _currentEnrty = "";

    public string thisKey = "";

    public AudioSource audioSource;
    public AudioClip ketHit;
    public AudioClip succesSound;
    public AudioClip errorSound;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            _currentEnrty += thisKey;
            if(_currentEnrty.Length > 2)
            {
                if(_currentEnrty == _correctCode)
                {
                    GetComponent<Animator>().SetTrigger("Unlock");
                    audioSource.PlayOneShot(succesSound);
                    _currentEnrty = "";
                }
                else
                {
                    _currentEnrty = "";
                    audioSource.PlayOneShot(errorSound);
                }
            }
            else
            {
                audioSource.PlayOneShot(ketHit);
            }
        }
    }
}
