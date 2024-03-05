using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollider : MonoBehaviour
{
    [SerializeField] private float turnspeed;
    public GameObject coin;
    
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, turnspeed * Time.deltaTime));
    }
    
}
