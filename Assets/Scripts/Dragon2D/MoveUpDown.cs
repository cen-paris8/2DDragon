﻿using UnityEngine;

public class MoveUpDown : MonoBehaviour
{
    private float HeightVariance = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * Mathf.Sin(Time.time) * Time.deltaTime * HeightVariance;
    }
}
