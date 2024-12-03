using UnityEngine;

public class StayInBounds : MonoBehaviour
{
    public RectTransform canvasRect; 

    private float minY;
    private float maxY;

    void Start()
    {
        if (canvasRect == null)
        {
            Debug.LogError("Canvas Rect is not assigned! Please assign it in the Inspector.");
            return;
        }

        // Get the world space corners of the canvas
        Vector3[] worldCorners = new Vector3[4];
        canvasRect.GetWorldCorners(worldCorners);

        minY = worldCorners[0].y; 
        maxY = worldCorners[1].y; 

        Debug.Log($"Canvas Y Bounds - MinY: {minY}, MaxY: {maxY}");
    }

    void Update()
    {
        if (canvasRect == null) return;

        Vector3 position = transform.position;
        position.y = Mathf.Clamp(position.y, minY, maxY);
        transform.position = position;
    }
}
