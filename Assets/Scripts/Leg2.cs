using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class Leg2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private int counter = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            counter++;
            if (counter % 2 != 0)
            {
                transform.rotation = quaternion.Euler(new Vector3(11, 0, 0));
            }
            else
            {
                transform.rotation = quaternion.Euler(new Vector3(0, 0, 0));
            }

        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            transform.rotation = quaternion.Euler(new Vector3(0, 0, 0));

        }

    }
}
