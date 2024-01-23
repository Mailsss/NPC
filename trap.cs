using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    public Transform teleportPoint;

    void OnTriggerEnter(Collider other)
    {


        other.transform.position = teleportPoint.position;
    }
}