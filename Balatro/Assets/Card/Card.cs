using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler,IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler
{

    public bool Isdragging;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Isdragging = true;
        //throw new System.NotImplementedException();
    }

    public void OnDrag(PointerEventData eventData) { 

        //throw new System.NotImplementedException();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Isdragging = false;
        transform.localPosition = Vector3.zero;
        //throw new System.NotImplementedException();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
       // throw new System.NotImplementedException();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Isdragging){
            Vector3 targetPOS = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPOS.z = 0;
            transform.position = targetPOS;
        }
    }
}
