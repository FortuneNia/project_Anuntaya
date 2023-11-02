using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float forcePower;

    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private float JumpForce = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ;
        }
    }
    public void SetForce(float force)

    {
        rb.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
    }
}
