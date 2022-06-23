using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float forwardSpeed;
    [SerializeField]
    private float sideSpeed;
    // Start is called before the first frame update
    void Start()
    {
        forwardSpeed = 5;
        sideSpeed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal") * sideSpeed * Time.deltaTime;
        this.transform.Translate(xAxis, 0, forwardSpeed * Time.deltaTime);
    }
}
