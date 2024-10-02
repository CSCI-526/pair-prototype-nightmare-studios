using UnityEngine;

public class RotatePlayArea : MonoBehaviour
{
    public float rotationSpeed = 100f; 
    private bool isRotating = false;
    private float targetAngle = 0f;

    public Rigidbody2D rb;
    public Transform player;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && !isRotating)
        {
            targetAngle -= 90f; 
            isRotating = true;
        }

        if (isRotating)
        {
            RotateArea();
     
        }
    }

    void RotateArea()
    {
     
        float step = rotationSpeed * Time.deltaTime;
        float angleBefore = transform.eulerAngles.z;
        float angle = Mathf.MoveTowardsAngle(angleBefore, targetAngle, step);
        transform.eulerAngles = new Vector3(0, 0, angle);
        // player.transform.eulerAngles = new Vector3(0, 0, 0);

   
        if (Mathf.Approximately(angle, targetAngle))
        {
            isRotating = false;
          
        }
    }



}
