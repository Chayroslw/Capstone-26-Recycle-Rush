using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUpTrigger : MonoBehaviour
{

    [Header("Main Settings")]
    public string TagObject;
    public UnityEvent TriggerEvent;
    public bool DestroyTrigger;
    public AudioClip _freezeSfx, _addTimerSfx;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InvokeTrigger()
    {
        TriggerEvent.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == TagObject)
        {
            TriggerEvent.Invoke();
            Destroy(gameObject);
        }
    }

    public void PowerUpFreezeSfx()
    {
        SoundManager.Instance.PlaySound(_freezeSfx);
    }
    public void PowerUpAddTimerSfx()
    {
        SoundManager.Instance.PlaySound(_addTimerSfx);
    }
}
