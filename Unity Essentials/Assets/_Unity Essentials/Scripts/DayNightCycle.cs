using UnityEngine;

/// <summary>
/// Rotates a Directional Light to simulate the passing of a day.
/// Attach this script to your Directional Light.
/// </summary>
public class DayNightCycle : MonoBehaviour
{
    // How many real seconds it takes for one full day to pass
    public float dayDuration = 120.0f;

    // Multiplier for how fast the light rotates
    public float rotationSpeed = 1.0f;

    // Variable to keep track of time passed
    private float timePassed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Ensure that the rotation speed is not negative
        rotationSpeed = Mathf.Abs(rotationSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the angle to rotate based on time passed
        float angleToRotate = (360.0f / dayDuration) * Time.deltaTime;

        // Rotate the directional light
        transform.Rotate(Vector3.right, angleToRotate * rotationSpeed);

        // Update time passed
        timePassed += Time.deltaTime;

        // If a day has passed, reset the time counter
        if (timePassed >= dayDuration)
        {
            timePassed = 0.0f;
        }
    }
}