using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCollision : MonoBehaviour
{
    [SerializeField]
    public GameObject TeaPot, Cylinder;

    [SerializeField]
    private Text displayText;

    Collider tp_collider, c_collider;

    private string defaultDisplay = "Intersections at: \n";


    // Start is called before the first frame update
    void Start()
    {
        if (TeaPot != null)
        {
            tp_collider = TeaPot.GetComponent<Collider>();
        }

        if (Cylinder != null)
        {
            c_collider = Cylinder.GetComponent<Collider>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (tp_collider.bounds.Intersects(c_collider.bounds))
        {

            Debug.Log(defaultDisplay);

            Collider[] intersections = Physics.OverlapSphere(transform.position, transform.localScale.x);


            foreach (Collider intersection in intersections)
            {
                Vector3 coordvec = intersection.transform.position;

                displayText.text += coordvec.ToString();

            }
        }
        else
        {
            displayText.text = defaultDisplay;
        }
    }
}
