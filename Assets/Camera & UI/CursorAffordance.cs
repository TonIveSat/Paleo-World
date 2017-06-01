using UnityEngine;

[RequireComponent(typeof(CameraRaycaster))]
public class CursorAffordance : MonoBehaviour
{
    [SerializeField]
    Texture2D WalkCursor = null;

    [SerializeField]
    Texture2D CombatCursor = null;

    [SerializeField]
    Texture2D StopCursor = null;

    CameraRaycaster cameraRayCaster;

    // Use this for initialization
    void Start ()
    {
        cameraRayCaster = GetComponent<CameraRaycaster>();
        cameraRayCaster.layerChangeObservers += OnLayerChange;
	}
	
	// Update is called once per frame
	public void OnLayerChange()
    {
        var currentLayerHit = cameraRayCaster.currentLayerHit;
        switch (currentLayerHit)
        {
            case Layer.Enemy:
                Cursor.SetCursor(CombatCursor, new Vector2(), CursorMode.Auto);
                break;
            case Layer.RaycastEndStop:
                Cursor.SetCursor(StopCursor, new Vector2(), CursorMode.Auto);
                break;
            case Layer.Walkable:
                Cursor.SetCursor(WalkCursor, new Vector2(), CursorMode.Auto);
                break;
        }
    }
}
