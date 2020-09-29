using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesaMove : MonoBehaviour
{
     public Vector2 startPosition;
    public Vector2 newPosition;
    
    [SerializeField] private int speed = 3;
    [SerializeField] private int maxDistance = 1;

    void Start()
    {
        startPosition = transform.position;
        newPosition = transform.position;
    }

    void Update()
    {
        newPosition = startPosition;
        newPosition.x = startPosition.x + (maxDistance * Mathf.Sin(Time.time * speed));
        transform.position = newPosition;
    }

}
