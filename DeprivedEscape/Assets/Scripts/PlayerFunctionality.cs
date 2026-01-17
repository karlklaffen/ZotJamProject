using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFunctionality : MonoBehaviour
{
    public string keyTag;
    public string doorTag;
    public bool gotKey;

    public string nextSceneName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(keyTag))
        {
            Destroy(collision.gameObject);
            gotKey = true;
        }
        else if (collision.gameObject.CompareTag(doorTag))
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
