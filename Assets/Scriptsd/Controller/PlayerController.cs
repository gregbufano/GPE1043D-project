using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public PlayerPawn pawn;

    public KeyCode moveFowardKey;
    public KeyCode moveBackwardKey;
    public KeyCode yawClockwise;
    public KeyCode yawCounterClockwise;
    public KeyCode rollClockwise;
    public KeyCode rollCounterClockwise;
    public KeyCode pitchClockwise;
    public KeyCode pitchCounterClockwise;
    public KeyCode reduceCameraOffset;
    public KeyCode increaseCameraOffset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    public void ProcessInputs()
    {
        if (Input.GetKey(moveFowardKey))
        {
            // move foward
            pawn.MoveFoward();
        }

        if (Input.GetKey(moveBackwardKey))
        {
            // move backward
            pawn.MoveBackward();
        }

        if (Input.GetKey(yawClockwise))
        {
            // yaw clockwise
            pawn.YawClockwise();
        }

        if (Input.GetKey(yawCounterClockwise))
        {
            // yaw CounterClockwise
            pawn.YawCounterClockwise();
        }
        if (Input.GetKey(rollClockwise))
        {
            // roll clockwise
            pawn.RollClockwise();
        }
        if (Input.GetKey(rollCounterClockwise))
        {
            // roll counterclockwise
            pawn.RollCounterClockwise();
        }
        if (Input.GetKey(pitchClockwise))
        {
            // pitch clockwise
            pawn.PitchClockwise();
        }
        if (Input.GetKey(pitchCounterClockwise))
        {
            // putch counterclockwise
            pawn.PitchCounterClockwise();
        }
        if (Input.GetKey(reduceCameraOffset))
        {
            pawn.IncreaseCameraOffset();
        }
        if (Input.GetKey(increaseCameraOffset))
        {
            pawn.DecreaseCameraOffset();
        }
    }
    
}
