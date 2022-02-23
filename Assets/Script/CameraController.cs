using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Free_Racing_Car_Red;

   
    private Vector3 vector3;
    //Start is called before the first frame update
    void Start()
    {
        //vector3 = new Vector3(0, 0.5f, -5.09f);
        vector3 = new Vector3(0, 7f, -20f);

    }

//    Update is called once per frame
    void Update()
    {    // kết nối với tranform của component của vật thể Camera
        transform.position = Free_Racing_Car_Red.transform.position + vector3;

    }

}
