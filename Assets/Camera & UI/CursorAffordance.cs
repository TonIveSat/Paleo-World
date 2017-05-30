using UnityEngine;

public class CursorAffordance : MonoBehaviour
{
    [SerializeField]
    Texture2D WalkCursor = null;

    [SerializeField]
    Texture2D CombatCursor = null;

    [SerializeField]
    Texture2D StopCursor = null;

    CameraRaycaster cameraRayCaster;
    private Layer LastLayerHit;

    // Use this for initialization
    void Start ()
    {
        cameraRayCaster = GetComponent<CameraRaycaster>();
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        var currentLayerHit = cameraRayCaster.currentLayerHit;
        if (currentLayerHit != LastLayerHit)
        {
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
            LastLayerHit = currentLayerHit;
        }
    }
}
