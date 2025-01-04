using UnityEngine;

public class Movementcontrols : MonoBehaviour
{
    public float constantspeed = 2.0f;
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    //yes
    // Update is called once per frame
    void Update()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
  
        // Move translation along the object's y-axis
        transform.Translate(0, translation + constantspeed * Time.deltaTime, 0);

        // Rotate around our y-axis
        transform.Rotate(0, 0, -rotation);
    }
}
