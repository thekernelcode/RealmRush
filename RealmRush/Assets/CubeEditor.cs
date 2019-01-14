using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]     // Runs in editor
[SelectionBase]         // Helps to select base in heirarchy

public class CubeEditor : MonoBehaviour
{
    [SerializeField] [Range (1f, 20f)] float gridSize = 10f;

    TextMesh textMesh;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 snapPos;
     
        snapPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize;
        snapPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize;

        textMesh = GetComponentInChildren<TextMesh>();
        textMesh.text = snapPos.x/gridSize + "," + snapPos.z/gridSize;

        transform.position = new Vector3(snapPos.x, 0, snapPos.z);

    }
}
