using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float maxTorq = 50f;
    public float Steerforce = 2f;
    public WheelCollider[] WheelColliders = new WheelCollider[4];
    public Transform[] TireMeshes = new Transform[4];
    public Transform centerofmass;
    public float aceleration;
    public Rigidbody mybody;
    void Start()
    {
        mybody = GetComponent<Rigidbody>();
       mybody.centerOfMass = centerofmass.localPosition ;
    }
    void Update()
    {
        UpdateMeshesPosition();
    }

    void FixedUpdate()
    {
       float steer = Input.GetAxis("Horizontal");
        aceleration= Input.GetAxis("Vertical");
        float angle = steer * 45f;

        WheelColliders[0].steerAngle =angle;
        WheelColliders[1].steerAngle = angle;
        for (int i = 0; i < 4; i++)
        {
            WheelColliders[i].motorTorque = aceleration * maxTorq;
        }
    }

    void UpdateMeshesPosition()
    {
         for(int i = 0; i < 4; i++)
        {
            Quaternion q;
            Vector3 Pos;
            WheelColliders[i].GetWorldPose(out Pos, out q);

            TireMeshes[i].position = Pos;
            TireMeshes[i].rotation = q;
        }
    }
}
