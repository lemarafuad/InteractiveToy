using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class arm1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
             transform.rotation = quaternion.Euler(new Vector3(0, 0, -90));
        }
        else if (Input.GetKeyUp(KeyCode.H))
        {
             transform.rotation = quaternion.Euler(new Vector3(0, 0, -45));
        }
        
    }
}
