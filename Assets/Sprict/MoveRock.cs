using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRock : MonoBehaviour
{
    public Vector2 velocity = new Vector2(-400, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<Rigidbody2D>().velocity = velocity; 
    }
}
