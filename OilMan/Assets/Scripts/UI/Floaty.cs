using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Floaty : MonoBehaviour
{
    public float moveSpeed;
    public float lifetime;
    public float timer;
    public Text myText;
    public Vector3 myPosition;
    public Color myColor;
    // Start is called before the first frame update
    void Start()
    {
        // Get the Text component from the main object.
        myText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= lifetime)
        {
            DestroySelf();
        }
        else
        {
            MoveUp();
            UpdateAlpha();
        }
    }

    // Moves the text up.
    void MoveUp()
    {
        // Get the latest values from the main transform.
        myPosition = gameObject.transform.position;
        // Move the text.
        myPosition.y += moveSpeed;
        gameObject.transform.position = myPosition;
    }

    // Allows to set the string outside of the script.
    public void SetText(string inString)
    {

    }
    // Get the latest color, update it locally, and set it to the Text component.
    void UpdateAlpha()
    {
        myColor = myText.color;
        myColor.a -= 0.01f;
        myText.color = myColor;
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
