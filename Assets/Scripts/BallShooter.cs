using UnityEngine;

public class BallShooter : MonoBehaviour
{
    public float shootForce = 500f;
    public Vector3 direction = new Vector3(0f,1f,0f);
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(direction * shootForce);
        }
    }
}
