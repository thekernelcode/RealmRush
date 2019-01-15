using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]     // Runs in editor
[SelectionBase]         // Helps to select base in heirarchy
[RequireComponent(typeof(Waypoint))]

public class CubeEditor : MonoBehaviour
{
    Waypoint waypoint;

    private void Awake()
    {
        waypoint = GetComponent<Waypoint>();
    }

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SnapToGrid();
        UpdateLabel();
    }

    private void SnapToGrid()
    {
        int gridSize = waypoint.GetGridSize();
        transform.position = new Vector3
        (waypoint.GetGridPos().x * gridSize,  
         0, 
         waypoint.GetGridPos().y * gridSize);  // Vector2Int has 2 components.  Requires X & Y for mapping
    }

    private void UpdateLabel()
    {
        TextMesh textMesh = GetComponentInChildren<TextMesh>();
        string labelText = waypoint.GetGridPos().x + "," 
                         + waypoint.GetGridPos().y;
        textMesh.text = labelText;
        gameObject.name = labelText;
    }
}
