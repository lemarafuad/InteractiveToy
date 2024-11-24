using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class MyToy : MonoBehaviour
{
    private float move = 0.01f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0, move);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, 0, -move);
        }

        // if (Input.GetKey(KeyCode.LeftArrow))
        // {
        //     transform.rotation = quaternion.Euler(new Vector3(0, 90, 0));

        // }
        // if (Input.GetKey(KeyCode.RightArrow))
        // {
        //     transform.rotation = quaternion.Euler(new Vector3(0, -90, 0));
        // }

    }
}
