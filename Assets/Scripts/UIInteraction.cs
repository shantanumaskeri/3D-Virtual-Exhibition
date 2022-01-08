using UnityEngine;

public class UIInteraction : MonoBehaviour
{

    public GameObject backBtn;
   
    public void ShowUIComponent(GameObject instance)
    {
        instance.SetActive(true);
    }

    public void HideUIComponent(GameObject instance)
    {
        instance.SetActive(false);
    }

}
