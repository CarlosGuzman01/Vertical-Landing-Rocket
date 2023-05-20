using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Utilizing transform.rotation, a quaternion (used to represent rotations of a GameObject)
//that stores the rotation of the Transform (position, rotation, and scale of an object) in world space

//The GameObject will be tilted using arrow keys
//when released the cube will be rotated back to the center using Slerp (spherically interpolates between two vectors)
public class NewBehaviourScript : MonoBehaviour
{

    public GameObject rocketMotor;

    //PID controller is used to drive any system with variable input
    private float PIDX, PIDY, previous_errorX,previous_errorY, pwmX, pwmY;

    public float desired_angleX = 0f;
    public float desired_angleY = 0f;
    private float errorX = 0f;
    private float errorY = 0f;
    public float offsetX = 0f;
    public float offsetY = 0f;


    //PID parameters
    private float pidX_proportional = 0f;
    private float pidY_proportional = 0f;

    private float pidX_integral = 0f;
    private float pidY_integral = 0f;

    private float pidX_derivative = 0f;
    private float pidX_derivative = 0f;

    //PID Gains
    //unsure about the values chosen
    public float kp = 0.11f;
    public float ki = 0.02f;
    public float kd = 0.04f;

    private float dt, currentTime, previousTime;
    //PID gains seem undetermined 

    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
