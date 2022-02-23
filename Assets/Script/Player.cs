using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
 {
    public Animator ani;
    private float inputH;
    private float inputV;
    public Rigidbody rigi;
    public bool run;
    public bool jump;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        rigi = GetComponent<Rigidbody>();
        run = false;
    }

    // Update is called once per frame
    void FixedUpdate()  // update
    { 
        if (Input.GetKeyDown("1"))
        {
            ani.Play("WAIT01", -1, 0f);
        }

        if (Input.GetKeyDown("2"))
        {
            ani.Play("WAIT02", -1, 0f);
        }

        if (Input.GetKeyDown("3"))
        {
            ani.Play("WAIT03", -1, 0f);
        }

        if (Input.GetKeyDown("4"))
        {
            ani.Play("WAIT04", -1, 0f);
        }

        //if (Input.GetKeyDown("5"))
        //{
        //    ani.Play("JUMP00B", -1, 0f);
        //}


        if (Input.GetMouseButtonDown(0))
        {
            int n= Random.Range(0, 2);
            if (n==0)
            {
                ani.Play("DAMAGED00", -1, 0F);
            }
            else
            {
                ani.Play("DAMAGED01", -1, 0F);
            }
        }

        ///Run
        if (Input.GetKey(KeyCode.LeftShift))
        {
            run = true;
        }
        else
        {
            run = false;
        }
       
        //JUMP

        if (Input.GetKey(KeyCode.Space))
        {
            ani.SetBool("Jump", true);
        }
        else
        {
            ani.SetBool("Jump", false);
        }
        //

        inputH = Input.GetAxis("Horizontal");

        inputV = Input.GetAxis("Vertical");

        ani.SetFloat("inputH", inputH);
        ani.SetFloat("inputV", inputV);
        ani.SetBool("run", run);    

        float moveX = inputH * 30f * Time.deltaTime;

        float moveZ = inputV * 50f * Time.deltaTime;
        if (moveZ <= 0f)
        {
            moveX = 0f;
        }
        else if (run)
        {
            moveX = moveX * 5f;
            moveZ = moveZ * 5f;
        }
        rigi.velocity = new Vector3(moveX, 0f, moveZ);
    }
}
