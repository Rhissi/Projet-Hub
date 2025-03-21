using UnityEngine;

public class scriptcamera : MonoBehaviour
{
    public GameObject Player;
    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position;
        transform.rotation = Player.transform.rotation;
    }
}
