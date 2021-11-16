using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void OnLeftClick()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void OnRightClick()
    {
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        }
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OpenDoorClick()
    {
        SceneManager.LoadScene("OpenDoor");
    }
    public void UndoOpenDoorClick()
    {
        SceneManager.LoadScene("Scene 1");
    }
    public void OpenWindowClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void ChessOnClick()
    {
        SceneManager.LoadScene("PaperOnChess");
    }
    public void UndoChessOnClick()
    {
        SceneManager.LoadScene("Scene 4");
    }
    public void TheNoteOnClick()
    {
        SceneManager.LoadScene("TheNote");
    }
    public void EndGame()
    {
        SceneManager.LoadScene("WinTheGame");
    }

    
}
