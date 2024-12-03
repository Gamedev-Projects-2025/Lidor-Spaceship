using UnityEngine;

public class UltraLaser : MonoBehaviour
{
    [Tooltip("The number of seconds that the shield remains active")]
    [SerializeField] private float duration;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"Laser triggered by: {other.name}");

        GameObject[] objects = Object.FindObjectsOfType<GameObject>();

        if (other.gameObject.name == "PlayerSpaceship1")
        {
            foreach (GameObject obj in objects)
            {
                if (obj.gameObject.name == "EnemySaucerWithCollider(Clone)")
                {
                    Debug.Log($"Destroying object: {obj.name}");
                    Destroy(obj);
                }
            }

            Destroy(this.gameObject);
        }

    }
}
