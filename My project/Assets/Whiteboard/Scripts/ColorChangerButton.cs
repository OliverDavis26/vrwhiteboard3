using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChangerButton : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;
    private Renderer cubeRenderer;
    private Color newCubeColor;
    private float randomUnos, randomDes, randomTres;

    void Start()
    {
        cubeRenderer = cube.GetComponent<Renderer>();
        gameObject.GetComponent<Button>().onClick.AddListener(ChangeCubeColor);
    }

    public void ChangeCubeColor()
    {
        randomUnos = Random.Range(0f, 1f);
        randomDes = Random.Range(0f, 1f);
        randomTres = Random.Range(0f, 1f);

        newCubeColor = new Color(randomUnos, randomDes, randomTres, 1f);
        cubeRenderer.material.SetColor("_Color", newCubeColor);
    }
}
