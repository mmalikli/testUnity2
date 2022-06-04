using UnityEngine;


[RequireComponent(typeof (Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    //A reference to rigid body component
    private Rigidbody rb;
    Vector3 HorizontalMovement;
    Vector3 VerticalMovement;

    [Tooltip("How fast player moves left/right")]
    public float leftRightSpeed = 5;
    [Tooltip ("How fast the ball moves forwards automatically")]
    [Range(0 ,10) ]
    public float moveSpeed = 5;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate() {
        //var horizontalSpeed = Input.GetAxis("Horizontal")*leftRightSpeed;
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
 
        HorizontalMovement = new Vector3(moveHorizontal, 0, moveVertical );
 
        HorizontalMovement = HorizontalMovement * moveSpeed * Time.deltaTime; 
        transform.position += HorizontalMovement;
    }
    /*
    [SerializeField] private float characterMoveSpeed;
    [SerializeField] private float characterWalkSpeed = 0.01f;
    [SerializeField] private float characterRunSpeed = 0.05f;
    [SerializeField] private float characterRotation= 1;
    */

    // Start is called before the first frame update
    /*
    private void Start()
    {
        characterMoveSpeed= characterWalkSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * characterMoveSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -1) * characterMoveSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate (new Vector3(0, 1, 0) * characterRotation);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -1, 0) * characterRotation);
        }

    }
    */
}
