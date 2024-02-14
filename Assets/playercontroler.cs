using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercomponent : MonoBehaviour
{
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += Vector3.right * Time.deltaTime;
        //zczytaj klawiature w osi poziomej
        float x = Input.GetAxisRaw("Horizontal");

        Debug.Log(x);   

        Vector3 movment = Vector3.right * x ;

        //transform.position += movment;

        float y = Input.GetAxisRaw("Vertical");

        movment += Vector3.forward * y ;

        movment = movment.normalized;
        movment *= Time.deltaTime;
        movment *= moveSpeed; 

        transform.position += movment;





    }
}
