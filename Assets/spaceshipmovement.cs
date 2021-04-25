using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceshipmovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float HorizontalInput = Input.GetAxis("Horizontal");
    transform.Translate(HorizontalInput* Time.deltaTime* speed, 0, 0);
    Vector2 MaxPosition = new Vector2(5.0f, transform.position.y);
    Vector2 MinPosition = new Vector2(-5.0f, transform.position.y);
        if(transform.position.x > 5.0f)
        {
            transform.position = MaxPosition;
        }
        else if (transform.position.x < -5.0f)
        {
          transform.position = MinPosition;
         }
        
    }
    
}
  
