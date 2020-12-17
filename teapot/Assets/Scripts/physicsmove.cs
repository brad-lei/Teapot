using UnityEngine;

public class physicsmove : MonoBehaviour
{
    public float moveSpeed;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float hm = Input.GetAxis("Horizontal");
        float vm = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(hm * Time.fixedDeltaTime, 0.0f, vm * Time.fixedDeltaTime);

        rb.AddForce(movement * moveSpeed);

    }
}
