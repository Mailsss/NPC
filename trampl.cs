using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    public float jumpFactor = 2.0f;

    void OnTriggerEnter(Collider other)
    {
        //���������� �������� ���� ������
        other.GetComponent<Jump>().jumpStrength *= jumpFactor;
    }

    void OnTriggerExit(Collider other)
    {
        //��������� �������� ���� ������
        other.GetComponent<Jump>(). jumpStrength /= jumpFactor;
    }
}
