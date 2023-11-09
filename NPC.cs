using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{   //�������� NPC
    public int health = 5;
    //������� NPC
    public int level = 2;
    //�������� NPC
    public float speed = 1.2f;
    void Start()
    {   //���������� � ���������� ������ NPC ��� �������
        health += level;
        //��������� �������� NPC
        print("�������� " + health);


    }
    void Update()
    {   //������ ������� NPC
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
