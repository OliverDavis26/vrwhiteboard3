using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour
{
    private Material targetMaterial;
    public GameObject targetObject;
    public Slider redSlider;
    public Slider greenSlider;
    public Slider blueSlider;

    void Start()
    {
        // Get the Renderer component on the targetObject
        Renderer renderer = targetObject.GetComponent<Renderer>();
        if (renderer == null)
        {
            Debug.LogError("Cannot find renderer on object " + targetObject.name);
            return;
        }
        // Get the material from the renderer
        targetMaterial = renderer.material;
        if (targetMaterial == null)
        {
            Debug.LogError("Cannot find Material on object " + targetObject.name);
            return;
        }
        // Set the default color of the material
        //targetMaterial = renderer.material; 
        /*redSlider.onValueChanged.AddListener(delegate { ChangeColor(); });
        greenSlider.onValueChanged.AddListener(delegate { ChangeColor(); });
        blueSlider.onValueChanged.AddListener(delegate { ChangeColor(); }); */
    }

    void Update()
    {
        targetMaterial.color = new Color(redSlider.value, greenSlider.value, blueSlider.value);

    }

    void ChangeColor()
    {
      targetMaterial.color = new Color(redSlider.value, greenSlider.value, blueSlider.value);
      Debug.Log(redSlider.value);
    }
}
