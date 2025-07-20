using TMPro;
using UnityEngine;

public class PlayerScriptDZ : MonoBehaviour
{
    //Movement
    [SerializeField] Rigidbody playerRigidbody;
    [SerializeField] TMP_Text doorText;
    [SerializeField] float speed = 10;
    [SerializeField] GameObject door;
    int left = 0;
    int right = 0;
    int up = 0;
    int down = 0;

    bool atDoor = false;
    bool gotKey = false;

    private void Update()
    {
        if(atDoor && gotKey && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(door);
            gotKey = false;
            LeaveDoor();
        }

        //Movement
        playerRigidbody.linearVelocity = new Vector2((right - left) * speed, (up - down) * speed);
        if (Input.GetKey(KeyCode.A))
        {
            left = 1;
        }
        else { left = 0; }

        if (Input.GetKey(KeyCode.D))
        {
            right = 1;
        }
        else { right = 0; }

        if (Input.GetKey(KeyCode.W))
        {
            up = 1;
        }
        else { up = 0; }

        if (Input.GetKey(KeyCode.S))
        {
            down = 1;
        }
        else { down = 0; }
    }

    public void ApproachDoor()
    {
        if (!gotKey)
        {
            doorText.text = "GET THE KEY!!!!";
        }
        else
        {
            doorText.text = "PRESS E TO USE KEY!!";
        }
        atDoor = true;
    }

    public void LeaveDoor()
    {
        doorText.text = "";
        atDoor = false;
    }

    public void GetKey()
    {
        gotKey = true;
    }
}
