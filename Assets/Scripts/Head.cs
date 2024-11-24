using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Head : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation = quaternion.Euler(new Vector3(0, 0, 6));

        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            transform.rotation = quaternion.Euler(new Vector3(0, 0, 0));

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = quaternion.Euler(new Vector3(0, 0, -6));   
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            transform.rotation = quaternion.Euler(new Vector3(0, 0, 0));

        }
    }
}
