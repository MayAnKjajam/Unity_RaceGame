using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CarJoyStick : MonoBehaviour
{
    public float maxTorq = 5000f;
    public float Steerforce = 2f;
    public WheelCollider[] WheelColliders = new WheelCollider[4];
    public Transform[] TireMeshes = new Transform[4];
    public Transform centerofmass;
    public Rigidbody mybody;
    public bool Accelerate=false,Deaccelerate=false;
    public float accelerate = 0f;

    void Start()
    {
        Accelerate = false;
        Deaccelerate = false;
    }
    void Update()
    {
        if (Accelerate)
        {

            accelerate = 0.0811f;
            Steer();

        }
       
       else if (Deaccelerate)
        {
            accelerate = -0.0811f;
            Steer();
        }
        else
        {
            Steer();
            accelerate = 0f;
        }
        float x = Input.acceleration.x;
        if (x < -0.1)
        {
            Steer();
        }
        else if (x > 0.1)
        {
            Steer();
        }
        else
        {
            for (int i = 0; i < 4; i++)
            {
               // WheelColliders[i].motorTorque = 0 * maxTorq;
            }
        }
        UpdateMeshesPosition();
    }
    void UpdateMeshesPosition()
    {
        for (int i = 0; i < 4; i++)
        {
            Quaternion q;
            Vector3 Pos;
            WheelColliders[i].GetWorldPose(out Pos, out q);

            TireMeshes[i].position = Pos;
            TireMeshes[i].rotation = q;
        }
    }
    void Steer()
    {
        float steer = Input.acceleration.x;
        float aceleration = accelerate;
        float angle = steer * 45f;

        WheelColliders[0].steerAngle = angle;
        WheelColliders[1].steerAngle = angle;
        for (int i = 0; i < 4; i++)
        {
            WheelColliders[i].motorTorque = aceleration * maxTorq;
        }
    }

   
}