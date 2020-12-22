using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 40.0f;
    public float xRange = 24;

    public GameObject projectilePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (xRange < Mathf.Abs(transform.position.x))  
            transform.position = new Vector3(xRange * Mathf.Sign(transform.position.x), transform.position.y, transform.position.z);

        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
     
        // We'll move 
        transform.Translate(speed * horizontalInput * Time.deltaTime * Vector3.right);
        
        // Spacebar button press reaction
        if (Input.GetKeyDown(KeyCode.Space)) // Launch the projectile from the player
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
