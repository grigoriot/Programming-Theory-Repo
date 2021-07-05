using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        MoveHorizontal();
        MoveVertical();
    }

    // ABSTRACTION
    public void MoveHorizontal()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontal * speed * Time.fixedDeltaTime);
    }

    public void MoveVertical()
    {
        float vertical = Input.GetAxis("Vertical");  
        transform.Translate(Vector3.forward * vertical * speed * Time.fixedDeltaTime);
    }
}
