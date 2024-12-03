using UnityEngine;
using UnityEngine.SceneManagement;

public class teleportSides : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.name == "PlayerSpaceship1")
        {
            Vector3 newPosition = other.transform.position;
            newPosition.x *= -0.95f;
            other.transform.position = newPosition;

        }
    }

}
