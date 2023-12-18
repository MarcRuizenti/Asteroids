using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTriangulo : MonoBehaviour
{
   
    public float speedRotacion;
    public float speedMovimento;
    public string inputHorizontal;
    public string inputVertical;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis(inputHorizontal);

        horizontal *= Time.deltaTime * speedRotacion;

        float vertical = Input.GetAxis(inputVertical);

        if (vertical > 0)
        {
            rb.AddForce(transform.up * vertical * speedMovimento * Time.deltaTime);
        }

        transform.eulerAngles += new Vector3(0, 0, horizontal);
    }
}
