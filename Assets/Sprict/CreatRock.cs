using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatRock : MonoBehaviour
{
    public GameObject[] rock;
    private int Index;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Creat", 1f, 18f);
    }

    private void Update()
    {
         Index = Random.Range(0, 19)/10;
    }
    // Update is called once per frame
    private void Creat()
    {
        
        var obj = Instantiate(rock[Index]);
        obj.transform.parent=this.gameObject.transform;
        if(Index==0)
        obj.transform.localPosition = new Vector3(184, Random.Range(24, 100) , 0);
        if(Index==1)
        obj.transform.localPosition = new Vector3(184, Random.Range(-24, -100) , 0);
    }
}
