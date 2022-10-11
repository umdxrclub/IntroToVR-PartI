using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides simple functions that can operate on a cube. 
/// </summary>
public class CubeFunctions : MonoBehaviour
{
    private MeshRenderer _renderer;
    
    /// <summary>
    /// Start is called to initialize the script upon the GameObject's creation.
    /// </summary>
    private void Start()
    {
        // Get the attached MeshRenderer of this cube.
        _renderer = GetComponent<MeshRenderer>();
    }

    /// <summary>
    /// Sets a new scale for the cube (scaled uniformly).
    /// </summary>
    /// <param name="newScale">The new scale to use</param>
    public void SetCubeScale(float newScale)
    {
        transform.localScale = newScale * Vector3.one;
    }

    /// <summary>
    /// Destroys this cube!
    /// </summary>
    public void DestroyCube()
    {
        Destroy(gameObject);
    }

    public void SetColor(Color color)
    {
        // We update the cube's color by taking its renderer and setting the "color" field on its material.
        _renderer.material.color = color;
    }

    public void SetRedColor()
    {
        SetColor(Color.red);
    }

    public void SetGreenColor()
    {
        SetColor(Color.green);
    }

    public void SetBlueColor()
    {
        SetColor(Color.blue);
    }

    public void SetWhiteColor()
    {
        SetColor(Color.white);
    }
}
