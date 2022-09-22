using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timeToWait = 3.0f;

    private Rigidbody rb;
    private MeshRenderer mr;
    
    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        
        rb.useGravity = false;
        mr.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            rb.useGravity = true;
            mr.enabled = true;
        }
    }
}
