using UnityEngine;

public class BitwiseButtons : MonoBehaviour
{
    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    public void BitWiseCompliment()
    {
        mainCamera.cullingMask = ~LayerMask.GetMask("RedDimension", "GreenDimension", "BlueDimension");
        Debug.Log(mainCamera.cullingMask);
    }
    
    public void BitWiseLeftShift()
    {
        mainCamera.cullingMask = LayerMask.GetMask("RedDimension", "GreenDimension", "BlueDimension") << 1;
        Debug.Log(mainCamera.cullingMask);
    }
    
    public void BitWiseRightShift()
    {
        mainCamera.cullingMask = LayerMask.GetMask("RedDimension", "GreenDimension", "BlueDimension") >> 1;
        Debug.Log(mainCamera.cullingMask);
    }
    
    public void BitWiseAND()
    {
        mainCamera.cullingMask &= LayerMask.GetMask("RedDimension", "GreenDimension", "BlueDimension");
        Debug.Log(mainCamera.cullingMask);
    }
    
    public void BitWiseOR()
    {
        mainCamera.cullingMask ^= LayerMask.GetMask("RedDimension", "GreenDimension", "BlueDimension");
        Debug.Log(mainCamera.cullingMask);
    }
    
    public void BitWiseXOR()
    {
        mainCamera.cullingMask |= LayerMask.GetMask("RedDimension", "GreenDimension", "BlueDimension");
        Debug.Log(mainCamera.cullingMask);
    }
}