using UnityEngine;

public class Platform : MonoBehaviour
{
    public bool isBreakable = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isBreakable && collision.relativeVelocity.y <= 0)
        {
            Destroy(gameObject); // Destroy platform on player landing if it's breakable
        }
    }
}
