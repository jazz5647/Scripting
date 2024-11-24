using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrimitivesZamok : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Zamok(dumayte kakoy)
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 0, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(3, 0, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-3, 0, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cylinder).transform.position = new Vector3(3, 1, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cylinder).transform.position = new Vector3(-3, 1, 0);
        GameObject.CreatePrimitive(PrimitiveType.Sphere).transform.position = new Vector3(3, 2, 0);
        GameObject.CreatePrimitive(PrimitiveType.Sphere).transform.position = new Vector3(-3, 2, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(2, 0, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-2, 0, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(1, 0, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-1, 0, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(3, 0, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(3, 0, -1);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(3, 0, -2);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(3, 0, -3);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(3, 0, -4);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(3, 0, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(3, 0, -6);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-3, 0, -1);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-3, 0, -2);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-3, 0, -3);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-3, 0, -4);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-3, 0, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-3, 0, -6);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 0, -6);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(3, 0, -6);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-3, 0, -6);
        GameObject.CreatePrimitive(PrimitiveType.Cylinder).transform.position = new Vector3(3, 1, -6);
        GameObject.CreatePrimitive(PrimitiveType.Cylinder).transform.position = new Vector3(-3, 1, -6);
        GameObject.CreatePrimitive(PrimitiveType.Cylinder).transform.position = new Vector3(0, 0, -3);
        GameObject.CreatePrimitive(PrimitiveType.Cylinder).transform.position = new Vector3(0, 1, -3);
        GameObject.CreatePrimitive(PrimitiveType.Cylinder).transform.position = new Vector3(0, 2, -3);
        GameObject.CreatePrimitive(PrimitiveType.Cylinder).transform.position = new Vector3(0, 3, -3);
        GameObject.CreatePrimitive(PrimitiveType.Sphere).transform.position = new Vector3(0, 4, -3);
        GameObject.CreatePrimitive(PrimitiveType.Sphere).transform.position = new Vector3(3, 2, -6);
        GameObject.CreatePrimitive(PrimitiveType.Sphere).transform.position = new Vector3(-3, 2, -6);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(2, 0, -6);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-2, 0, -6);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(1, 0, -6);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-1, 0, -6);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
