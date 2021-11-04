using UnityEngine;

public class BroadcastMessageDemo : MonoBehaviour
{
    private void Start()
    {
        BroadcastMessage("DestroyMyCube", 3f);
    }
}