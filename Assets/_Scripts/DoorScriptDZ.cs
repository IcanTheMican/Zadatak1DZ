using UnityEngine;

public class DoorScriptDZ : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out PlayerScriptDZ player))
        {
            player.ApproachDoor();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.TryGetComponent(out PlayerScriptDZ player))
        {
            player.LeaveDoor();
        }
    }
}
