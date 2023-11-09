using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{   //здоровье NPC
    public int health = 5;
    //уровень NPC
    public int level = 2;
    //скорость NPC
    public float speed = 1.2f;
    void Start()
    {   //прибавляет к количеству жизней NPC его уровень
        health += level;
        //Указывает здоровье NPC
        print("Здоровье " + health);


    }
    void Update()
    {   //Меняет позицию NPC
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
