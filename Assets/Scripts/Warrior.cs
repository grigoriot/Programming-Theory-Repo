using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Warrior : BaseEnemy
{
    // Start is called before the first frame update
    void Start()
    {
        SetPoints(20);
    }
    
    private void FixedUpdate()
    {
        Move();
    }

    // POLYMORPHISM
    protected override void Move()
    {
        transform.Translate(Vector3.right * speed * Time.fixedDeltaTime);
    }
}
