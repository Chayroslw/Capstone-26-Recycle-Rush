using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Interactable : MonoBehaviour
{
    public bool isInRange = false;
    public UnityEvent interactAction;
    float posx;
    public float posy = -4.1f;
    Scene scene;
    string sceneName;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
        sceneName = scene.name;

        if (sceneName == "2c. Gameplay Pantai")
        {
            posx = Random.Range(-34f, 42f);
            Vector3 pos = new Vector3(posx, posy, transform.position.z);
            transform.position = pos;
        }
        else
        {
            posx = Random.Range(-42f, 42f);
            Vector3 pos = new Vector3(posx, posy, transform.position.z);
            transform.position = pos;
        }
    }

    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                interactAction.Invoke();
                Destroy(gameObject);
                Debug.Log("Sampah dipungut");
                SoundManager.Instance.InteractSfx();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Player dalam jangkauan");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("Player diluar jangkauan");
        }
    }
}
