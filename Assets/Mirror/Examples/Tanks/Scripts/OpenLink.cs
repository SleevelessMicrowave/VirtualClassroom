using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public void OpenChannel()
    {
        Application.OpenURL("https://meet.google.com/");
    }

    public void OpenClassroom()
    {
        Application.OpenURL("https://classroom.google.com");
    }

    public void OpenDrive()
    {
        Application.OpenURL("https://drive.google.com");
    }
}
