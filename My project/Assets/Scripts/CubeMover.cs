using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CubeMover : MonoBehaviour
{

    // [SerializeField] private float speed;
    // private Rigidbody rb;

    // private Vector3 movement = Vector3.zero;

    // private void Awake()
    // {
    //     rb = GetComponent<Rigidbody>();
    // }

    // private void Update()
    // {
    //     movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    // }

    // private void FixedUpdate()
    // {
    //     rb.MovePosition(transform.position + movement * Time.fixedDeltaTime * speed);
    // }

    [SerializeField] private float speed;
    private Vector3 movement = Vector3.zero;

    void Start()
    {
        print("mi sto avviando.");
    }

    void Update()
    {
        movement = Vector3.zero;

        if(Input.GetKey(KeyCode.W))
        {
            movement += Vector3.forward;
        }
        if(Input.GetKey(KeyCode.A))
        {
            movement += Vector3.left;
        }
        if(Input.GetKey(KeyCode.S))
        {
            movement += Vector3.back;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement += Vector3.right;
        }
        
        transform.position += movement * speed * Time.deltaTime;
    }
}
