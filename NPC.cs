using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //кол-во жизней
    public int health = 3;
    //кол-во уровней
    public int level = 2;
    //скорость
    public float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        health = health += level;
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        //позиция
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
