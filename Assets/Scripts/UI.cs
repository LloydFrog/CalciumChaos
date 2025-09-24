using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{

    public CanvasGroup StartScreenCanvasGroup;
    public CanvasGroup ConfigScreenCanvasGroup;
    public CanvasGroup PlayScreenCanvasGroup;
    public CanvasGroup SettingsScreenCanvasGroup;
    public CanvasGroup PauseScreenCanvasGroup;
    public CanvasGroup GameOverScreenCanvasGroup;
    
    private List<CanvasGroup> canvasGroups = new List<CanvasGroup>();
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canvasGroups.Add(StartScreenCanvasGroup);
        canvasGroups.Add(ConfigScreenCanvasGroup);
        canvasGroups.Add(PlayScreenCanvasGroup);
        canvasGroups.Add(SettingsScreenCanvasGroup);
        canvasGroups.Add(PauseScreenCanvasGroup);
        canvasGroups.Add(GameOverScreenCanvasGroup);
        
        ShowStartScreen();
    }

    public void ShowStartScreen()
    {
        HideAllScreens();
        ShowCanvasGroup(StartScreenCanvasGroup);
    }
    
    public void ShowConfigScreen()
    {
        HideAllScreens();
        ShowCanvasGroup(ConfigScreenCanvasGroup);
    }
    
    public void ShowPlayScreen()
    {
        HideAllScreens();
        ShowCanvasGroup(PlayScreenCanvasGroup);
    }
    
    public void ShowPauseScreen()
    {
        HideAllScreens();
        ShowCanvasGroup(PauseScreenCanvasGroup);
    }
    
    public void ShowSettingsScreen()
    {
        HideAllScreens();
        ShowCanvasGroup(SettingsScreenCanvasGroup);
    }
    
    public void ShowEndGameScreen()
    {
        HideAllScreens();
        ShowCanvasGroup(GameOverScreenCanvasGroup);
    }

    private void HideAllScreens()
    {
        foreach (CanvasGroup canvasGroup in canvasGroups)
            HideCanvasGroup(canvasGroup);
    }

    public void ShowCanvasGroup(CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
    }
    
    public void HideCanvasGroup(CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }
    
}
