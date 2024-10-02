using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallMover : MonoBehaviour
{
    public Vector3 pos1 = new Vector3(23.9f, 6.3f, -13.8f);
    public Vector3 pos2 = -new Vector3(23.9f, 6.3f, 23.5f);
    public float difference;

    // Start is called before the first frame update
    void Start()
    {
        difference = pos1.z - pos2.z;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z >= pos1.z)
        {
            difference = pos1.z - pos2.z;
        }
        if(transform.position.z <= pos2.z)
        {
            difference = pos2.z - pos1.z;
        }
        transform.Translate(new Vector3(0f, 0f, -difference)*1*Time.deltaTime);

    }
}
