using UnityEngine;

public class KeyScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out PlayerScriptDZ player))
        {
            player.GetKey();
            Destroy(gameObject);
        }
    }
}
