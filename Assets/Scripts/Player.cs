using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector2.left * speed * Time.deltaTime);    
    }
}
