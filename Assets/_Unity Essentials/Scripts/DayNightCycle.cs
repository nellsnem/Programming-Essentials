using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Day Settings")]
    [Tooltip("—к≥льки реальних секунд триваЇ повний день")]
    public float dayDurationInSeconds = 120f;

    // Ўвидк≥сть обертанн€ (градус≥в за секунду)
    private float rotationSpeed;

    void Start()
    {
        // 360 градус≥в за один день
        rotationSpeed = 360f / dayDurationInSeconds;
    }

    void Update()
    {
        // ќбертаЇмо св≥тло навколо ос≥ X
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
