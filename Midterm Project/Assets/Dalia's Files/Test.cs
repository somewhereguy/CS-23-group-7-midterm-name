using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Grid grid;
    GameObject Cursor;
    // Start is called before the first frame update
    private void Start() {
        grid = new Grid(16, 10, 1f, new Vector3(-8f, -5f)); //change f for smaller grid 
    }

    private void Update() {
        if (Input.GetKey(KeyCode.Space)) {
            //change value inside grid with click:
            grid.SetValue(GameObject.Find("Cursor").transform.position, 56);
        }

        //reading values on right click
        if (Input.GetKey(KeyCode.Space)) {
            //change value inside grid with click:
            Debug.Log(grid.GetValue(GetMouseWorldPosition()));
        }
    }

    public static Vector3 GetMouseWorldPosition() {
        Vector3 vec = GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);
        vec.z = 0f;
        return vec;
    }

    public static Vector3 GetMouseWorldPositionWithZ() {
        return GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);
    }

    public static Vector3 GetMouseWorldPositionWithZ(Camera worldCamera) {
        return GetMouseWorldPositionWithZ(Input.mousePosition, worldCamera);
    }

    public static Vector3 GetMouseWorldPositionWithZ(Vector3 screenPosition, Camera worldCamera) {
        Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
        return worldPosition;
    }

}
