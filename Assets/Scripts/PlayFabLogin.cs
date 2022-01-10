using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;

public class PlayFabLogin : MonoBehaviour
{
    /*    public void Start()
        {
            if (string.IsNullOrEmpty(PlayFabSettings.TitleId))
            {
                *//*
                Please change the titleId below to your own titleId from PlayFab Game Manager.
                If you have already set the value in the Editor Extensions, this can be skipped.
                *//*
                PlayFabSettings.staticSettings.TitleId = "A42B0"; // Please change this value to your own titleId from PlayFab Game Manager
                //Debug.LogError("No title id set!");
            }
            var request = new LoginWithCustomIDRequest { CustomId = "GettingStartedGuide", CreateAccount = true };
            PlayFabClientAPI.LoginWithCustomID(request, OnLoginSuccess, OnLoginFailure);
            //PlayFabClientAPI.UpdateUserTitleDisplayName();
        }

        private void OnLoginSuccess(LoginResult result)
        {
            Debug.Log("Congratulations, you made your first successful API call!");
            Debug.Log("Response: " + result.ToJson());
        }

        private void OnLoginFailure(PlayFabError error)
        {
            Debug.LogWarning("Something went wrong with your first API call.  :(");
            Debug.LogError("Here's some debug information:");
            Debug.LogError(error.GenerateErrorReport());
        }*/
    public void Start()
    {
        if (string.IsNullOrEmpty(PlayFabSettings.staticSettings.TitleId))
        {
            /*
            Please change the titleId below to your own titleId from PlayFab Game Manager.
            If you have already set the value in the Editor Extensions, this can be skipped.
            */
            PlayFabSettings.staticSettings.TitleId = "A42B0";
        }
        var request = new LoginWithCustomIDRequest { CustomId = "GettingStartedGuide", CreateAccount = true };
        PlayFabClientAPI.LoginWithCustomID(request, OnLoginSuccess, OnLoginFailure);
    }

    private void OnLoginSuccess(LoginResult result)
    {
        Debug.Log("Congratulations, you made your first successful API call!");
        Debug.Log("Response: " + result.ToJson());
    }

    private void OnLoginFailure(PlayFabError error)
    {
        Debug.LogWarning("Something went wrong with your first API call.  :(");
        Debug.LogError("Here's some debug information:");
        Debug.LogError(error.GenerateErrorReport());
    }


        
}