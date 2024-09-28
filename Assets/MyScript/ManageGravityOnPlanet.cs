using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageGravityOnPlanet : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    public void setGravityOnPlanet()
    {
        rb.useGravity = true;
    }
}
