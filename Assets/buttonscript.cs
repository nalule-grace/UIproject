using UnityEngine;
using UnityEngine.UI;

public class TitlePageButton : MonoBehaviour
{
    public GameObject titlePage;
    public GameObject settingsPage;

    public void OnButtonClick()
    {
        titlePage.SetActive(false);
        settingsPage.SetActive(true);
    }
}