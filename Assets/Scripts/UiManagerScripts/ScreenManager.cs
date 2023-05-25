using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : BaseScreen
{
    public List<BaseScreen> ScreenList;
    [HideInInspector] public BaseScreen CurrentScreen;
    [HideInInspector] public BaseScreen PreviousScreen;
    public static ScreenManager instance;

    private void Awake()
    {
        instance = this;
        CurrentScreen = ScreenList[0];
    }

    public void ShowNextScreen(ScreenType screen)
    {
        PreviousScreen = CurrentScreen;
        CurrentScreen = ScreenList[(int)screen];
        PreviousScreen.HideScreen();
        CurrentScreen.ShowScreen();

        if(screen == ScreenType.MainMenu)
        {
            GameController.inst.StopMoveMent();
        }
        else if (screen == ScreenType.GamePlayCanvas)
        {
            GameController.inst.StartMoveMent();
        }

    }
    
}