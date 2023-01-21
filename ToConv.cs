using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToConv : MonoBehaviour
{
    public float speed = 3;
    public float life = 4;
    public int id;
    public void Awake()
    {
        Destroy(gameObject, life);
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
