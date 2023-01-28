using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeControl : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 position;
    public float rotationSpeed;
    
    void Start()
    {
        position = new Vector3(0, 1, 0);

        
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Transform>().Rotate(position, 45 * rotationSpeed*Time.deltaTime);
        //shortcut only for transform component: transform.position, transform.RotateAroundLocal
    }
}
