using UnityEngine;

public class CameraComponent : MonoBehaviour
{
    public Transform cameraTransform;

    public Transform targetTransform;

    public float minOffset;
    public float maxOffset;

    public float currentOffset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentOffset = minOffset;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movePosition = targetTransform.position - cameraTransform.position;

        

        cameraTransform.LookAt(targetTransform);
    }

    public void ChangeCameraOffset(float amount)
    {
        currentOffset += amount * Time.deltaTime;

        currentOffset = Mathf.Clamp(currentOffset, minOffset, maxOffset);
    }
}
