using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SampahBasahSlot : MonoBehaviour, IDropHandler
{
   
    [SerializeField] private AudioClip _rightEffect;
    [SerializeField] private AudioClip _wrongEffect;

    public void OnDrop(PointerEventData eventData)
    {
       

        if (eventData.pointerDrag.CompareTag("SampahBasah"))
        {
             Debug.Log("OnDrop" + eventData.pointerDrag.name);
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            SoundManager.Instance.PlaySound(_rightEffect); 
            DragAndDrop d = eventData.pointerDrag.GetComponent<DragAndDrop>();
        
          if (d != null) {
                
                 Destroy(d.gameObject);
            
          }
        }
        else
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            SoundManager.Instance.PlaySound(_wrongEffect);
        }
   
    }
}
