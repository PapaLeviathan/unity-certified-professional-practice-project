using UnityEngine;

public class FloatInACircle : MonoBehaviour
{
    [SerializeField] private int _amplitude = 1;
    [SerializeField] private float _frequency = 0.1f;
    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Cos(Time.time * _frequency) * _amplitude;
        float y = Mathf.Sin(Time.time * _frequency) * _amplitude;
        float z = transform.position.z;

        transform.position = new Vector3(x, y, z);
    }
}