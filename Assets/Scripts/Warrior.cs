using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    protected override void Move()
    {
        transform.Translate(Vector3.right * speed * Time.fixedDeltaTime);
    }
}
