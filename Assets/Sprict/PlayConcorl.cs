using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayConcorl : MonoBehaviour
{
    private Vector2 jumpForce = new Vector2(0, 1600);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {

           this.gameObject.GetComponent<Rigidbody2D>() .velocity = Vector2.zero;

            GetComponent<Rigidbody2D>().AddForce(jumpForce);
        }

        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);

        if (screenPosition.y > Screen.height || screenPosition.y < 0)

        {

            Die();

        }
    }





 

// Die by collision

void OnCollisionEnter2D(Collision2D other)

{

    Die();

}



void Die()

{
        SceneManager.LoadScene("Start");
    

}


}
