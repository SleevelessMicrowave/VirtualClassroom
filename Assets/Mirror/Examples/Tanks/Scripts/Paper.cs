using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  
public class SceneChanger: MonoBehaviour {  
    public void Scene1() {  
        SceneManager.LoadScene("Assignment_Scene");  
    }  
    public void Scene2() {  
        SceneManager.LoadScene("ClassroomScene");  
    }  

}   