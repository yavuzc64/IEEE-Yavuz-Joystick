using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinspawn : MonoBehaviour
{
    public GameObject coinprefab;
    public Vector3[] spawnPoints = new Vector3[]
    {
        new Vector3(25f, 1.2f, -9f),
        new Vector3(37f, 1.2f, -13f),
        new Vector3(4f, 1.2f, -30f),
        new Vector3(-14f, 1.2f, -22f),
        new Vector3(-22f, 1.2f, -28f),
        new Vector3(-37f, 1.2f, -14f),
        new Vector3(-23f, 1.2f, -17f),
        new Vector3(-33f, 1.2f, -8.5f),
        new Vector3(-16f, 1.2f, 19f),
        new Vector3(-12f, 1.2f, 24f),
        new Vector3(35.5f, 1.2f, 28f),
        new Vector3(16f, 1.2f, 23f),
        new Vector3(10f, 1.2f, 16f),
        new Vector3(22.5f, 1.2f, 16f),
        new Vector3(-12f, 1.2f, 11f)
    };
    public static Coinspawn instance;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            Instantiate(coinprefab, spawnPoints[i], Quaternion.Euler(90, 0, 0));
        }
    }
}
