using UnityEngine;

public class PlayerPawn : MonoBehaviour
{
    public Rigidbody rb;
    public Transform tf;
    public CameraComponent cameraComponent;

    public float forceMagnitude;
    public float rotationSpeed;
    public float cameraOffsetChangeRate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();
        cameraComponent = GetComponent<CameraComponent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveFoward()
    {
        Debug.Log("Move Foward");

        if (rb != null)
        {
            rb.AddForce(tf.forward * forceMagnitude);
        }
    }

    public void MoveBackward()
    {
        Debug.Log("Move Backward");
        
        if (rb != null)
        {
            rb.AddForce(tf.forward * -forceMagnitude);
        }
    }
    public void YawClockwise()
    {
        Debug.Log("Yaw Clockwise");
        if (tf != null)
        {
            tf.Rotate(new Vector3(0, 1, 0) * rotationSpeed * Time.deltaTime);
        }
    }
    public void YawCounterClockwise()
    {
        Debug.Log("Yaw CounterClockwise");
        if (tf != null)
        {
           tf.Rotate(new Vector3(0, 1, 0) * -rotationSpeed * Time.deltaTime);
        }
    }
    public void RollClockwise()
    {
        Debug.Log("Roll Clockwise");
        if (tf != null)
        {
            tf.Rotate(new Vector3(0, 0, 1) * -rotationSpeed * Time.deltaTime);
        }
    }
    public void RollCounterClockwise()
    {
        Debug.Log("Roll CounterClockwise");
        if (tf != null)
        {
            tf.Rotate(new Vector3(0, 0, 1) * rotationSpeed * Time.deltaTime);
        }
    }
    public void PitchClockwise()
    {
        Debug.Log("pitch Clockwise");
        if (tf != null)
        {
            tf.Rotate(new Vector3(1, 0, 0) * rotationSpeed * Time.deltaTime);
        }
    }
    public void PitchCounterClockwise()
    {
         Debug.Log("Pitch CounterClockwise");
         if (tf != null)
        {
            tf.Rotate(new Vector3(1, 0, 0) * -rotationSpeed * Time.deltaTime);
        }
    }

    public void IncreaseCameraOffset()
    {
        cameraComponent.ChangeCameraOffset(cameraOffsetChangeRate);
    }

    public void DecreaseCameraOffset()
    {
        cameraComponent.ChangeCameraOffset(-cameraOffsetChangeRate);
    }
}
