using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCollision : MonoBehaviour
{

    [SerializeField]
    public GameObject TeaPot, Cylinder, Can;

    Collider tp_collider, c_collider;

    Rigidbody tp_rigid, c_rigid;


    void Start()
    {
        Can.SetActive(false);

        if (TeaPot != null)
            tp_collider = TeaPot.GetComponent<Collider>();
            tp_rigid = TeaPot.GetComponent<Rigidbody>();

        if (Cylinder != null)
            c_collider = Cylinder.GetComponent<Collider>();
            c_rigid = Cylinder.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (tp_collider.bounds.Intersects(c_collider.bounds))
        {
            Can.SetActive(true);
            c_rigid.useGravity = false;
            c_collider.isTrigger = true;
        }

        else
        {
            Can.SetActive(false);
            c_rigid.useGravity = true;
            c_collider.isTrigger = false;
        }
    }
}
