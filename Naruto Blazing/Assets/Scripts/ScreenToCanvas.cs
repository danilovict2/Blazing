using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenToCanvas : MonoBehaviour
{
	public RectTransform m_parent;
	public Camera m_uiCamera;
	public RectTransform m_image;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
	   {
		   Vector2 anchoredPos;
		   RectTransformUtility.ScreenPointToLocalPointInRectangle(m_parent, Input.mousePosition, m_uiCamera, out anchoredPos);
		   m_image.anchoredPosition = anchoredPos;
	   }		   
    }
}
