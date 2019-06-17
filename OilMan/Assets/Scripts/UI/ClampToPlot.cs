using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampToPlot : MonoBehaviour
{
    public Transform plotUITransform;
    public int vertOffset;
    public int horizOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUIPositions();
    }

    void UpdateUIPositions()
    {
        // Gets the position of teh Plot's UI position on screen.
        Vector3 uiPos = Camera.main.WorldToScreenPoint(plotUITransform.transform.position);
        uiPos.x += horizOffset;
        uiPos.y += vertOffset;
        this.GetComponent<RectTransform>().position = uiPos;
    }
}
