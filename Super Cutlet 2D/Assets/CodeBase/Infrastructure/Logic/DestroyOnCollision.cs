using UnityEngine;

namespace CodeBase.Infrastructure.Logic
{
    public class DestroyOnCollision : MonoBehaviour
    {
        private const string PlayerTag = "Player";

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.collider.CompareTag(PlayerTag) == false)
                Destroy(gameObject);
        }
    }
}