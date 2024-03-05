using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick : MonoBehaviour
{
    Vector2 joystickcenter;
    Vector2 CenterDistance;
    Vector2 mouseposition;
    
    private float karekok;
    public static Joystick instance;
    public float side;
    public float forward;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        joystickcenter = transform.position;
        //Debug.Log(transform.position);
    }
    void Update()
    {
        mouseposition = Input.mousePosition;

        if (Input.GetMouseButton(0))
        {
            MeasureDistance();
            
            if (karekok < 100)
            {
                transform.position = mouseposition;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            transform.position = joystickcenter;
            side = 0;
            forward = 0;
        }

    }
    private void MeasureDistance()
    {
        CenterDistance = mouseposition - joystickcenter;
        side = CenterDistance.x;
        forward = CenterDistance.y;

        CenterDistance.x *= CenterDistance.x;
        CenterDistance.y *= CenterDistance.y;
        float sum = CenterDistance.y + CenterDistance.x;
        karekok = Mathf.Sqrt(sum);
        
    }
}
