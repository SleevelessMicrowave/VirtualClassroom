using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadAssignment()
    {
        SceneManager.LoadScene("Assignment_Scene");
        Debug.Log("clicked");
    }

    public void goBack()
    {
        SceneManager.LoadScene("Scene");
    }
}
