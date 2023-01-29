using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Amogus : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public Slider red;
    public Slider blue;
    public Slider green;
    // Start is called before the first frame update
    public void OnEdit()
    {
        Color color = meshRenderer.material.color;
        color.r = red.value;
        color.g = green.value;
        color.b = blue.value;
        meshRenderer.material.color = color;
        meshRenderer.material.SetColor("_EmissionColor", color);
    }
}
