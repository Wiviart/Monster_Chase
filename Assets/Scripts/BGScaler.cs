using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Transform()
    {
        // Get component spriterender of background
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        float maxScale = 2f;
        
        // Get height, width of background
        float background_y = sr.bounds.size.y;
        float background_x = sr.bounds.size.x;

        // Get height, width of screen
        float screen_y = Screen.height;
        float screen_x = Screen.width;

        // Get rate between background and screen
        float y = screen_y / background_y;
        float x = screen_x / background_x;
        float rate = Mathf.Min(Mathf.Max(y, x), maxScale);

        // Transform backgroun to screen by rate
        transform.localScale = new Vector3(rate, rate, 1);
    }
}
