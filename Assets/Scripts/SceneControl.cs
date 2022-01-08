using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{

    public VideoControl videoControl;
    public UIInteraction uiInteraction;

    public void MoveToNextScene(int index)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + index);
    }

    public void MoveToPreviousScene(int index)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - index);
    }

    public void CheckCurrentSceneStarted()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        switch (index)
        {
            case 1:
                videoControl.PlayVideo("Outside_To_Info_Desk.mp4");
                break;

            case 2:
                videoControl.PlayVideo("Info_Desk.mp4");
                break;

            case 3:
                videoControl.PlayVideo("Info_Desk_To_Auditorium.mp4");
                break;

            case 4:
                videoControl.PlayVideo("Info_Desk_To_Exhibition.mp4");
                break;

            case 5:
                videoControl.PlayVideo("Info_Desk_To_Conference.mp4");
                break;

            case 6:
                videoControl.PlayVideo("Stall_1.mp4");
                break;

            case 7:
                videoControl.PlayVideo("Stall_2.mp4");
                break;

            case 8:
                videoControl.PlayVideo("Stall_3.mp4");
                break;

            case 9:
                videoControl.PlayVideo("Stall_4.mp4");
                break;

            case 10:
                videoControl.PlayVideo("Stall_5.mp4");
                break;

            case 11:
                videoControl.PlayVideo("Stall_6.mp4");
                break;
        }
    }

    public void CheckCurrentSceneFinished()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        switch (index)
        {
            case 1:
                MoveToNextScene(1);
                break;

            case 3:
            case 4:
            case 5:
                uiInteraction.ShowUIComponent(uiInteraction.backBtn);
                break;
        }
    }
}
