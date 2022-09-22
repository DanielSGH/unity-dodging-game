using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1;
    public GameObject StartHere;

    // Start is called before the first frame update
    void Start()
    {
        transform.SetPositionAndRotation(StartHere.transform.position, new Quaternion(0f,0f,0f,0f));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, 0, Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed);
    }
}
