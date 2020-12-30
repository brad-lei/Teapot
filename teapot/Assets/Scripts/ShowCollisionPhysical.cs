using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShowCollisionPhysical : MonoBehaviour
{

    [SerializeField]
    public GameObject TeaPot, Cylinder, Canvas;

    [SerializeField]
    private Text displayText;

    Collider tp_collider, c_collider;

    Rigidbody tp_rigid, c_rigid;

    private List<string> coords = new List<string>();

    


    void Start()
    {
        displayText.text = ""; 

        
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
            //the Physical solution
            c_rigid.useGravity = false;
            c_collider.isTrigger = true;
            Debug.Log("intersected");

            Collider[] intersections = Physics.OverlapSphere(transform.position, transform.localScale.x);


            foreach (Collider intersection in intersections)
            {
                Vector3 coordvec = intersection.transform.position;

                coords.Add(coordvec.ToString());

            }
            //Debug.Log(coords);

            displayText.text = "intersect at" + coords;

            
        }

        else
        {
            displayText.text = "";
            c_rigid.useGravity = true;
            c_collider.isTrigger = false;
        }
    }
}
