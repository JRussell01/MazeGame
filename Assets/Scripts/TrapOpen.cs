using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapOpen : MonoBehaviour
{
    public GameObject TrapDoor;
    public AudioSource TrapAudio;

    private void OnTriggerEnter(Collider other)
    {
        TrapDoor.GetComponent<Animation>().Play("TrapAnim");
        TrapAudio.Play();
    }
}
