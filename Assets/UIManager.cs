using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameManager gameManager;

    public GameObject menuUI;
    public GameObject pauseUI;
    public GameObject optionsUI;

    public void EnableMenuUI()
    {
        DisableAllUI();
        menuUI.SetActive(true);
    }
    public void EnablePauseUI()
    {
        DisableAllUI();
        pauseUI.SetActive(true);
    }
    public void EnableOptionsUI()
    {
        DisableAllUI();
        optionsUI.SetActive(true);
    }
    public void DisableAllUI()
    {
        menuUI.SetActive(false);
        pauseUI.SetActive(false);
        optionsUI.SetActive(false);
    }
    public void StartOrResumeUI()
    {
        gameManager.gameStateManager.ChangeState(GameStateManager.GameState.Game_State);
    }
    public void GoToMenuUI()
    {
        gameManager.gameStateManager.ChangeState(GameStateManager.GameState.Menu_State);
    }
    public void BackUI()
    {
        if (gameManager.gameStateManager.lastStateDebug == "Pause_State")
        {
            gameManager.gameStateManager.ChangeState(GameStateManager.GameState.Pause_State);
        }
        else if (gameManager.gameStateManager.lastStateDebug == "Menu_State")
        {
            gameManager.gameStateManager.ChangeState(GameStateManager.GameState.Menu_State);
        }
    }
    public void OptionsUI()
    {
        gameManager.gameStateManager.ChangeState(GameStateManager.GameState.Options_State);
    }
    public void QuitUI()
    {
        Application.Quit();
    }
}
