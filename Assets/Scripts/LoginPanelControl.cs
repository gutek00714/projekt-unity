using UnityEngine;
using UnityEngine.UI;

public class LoginPanelControl : AbstractPanelController
{
    [SerializeField] private Button loginButton;
    [SerializeField] private UserProfilePanelControl userProfilePanelControl;
    [SerializeField] private InputField loginInput;

    private void Awake()
    {
        loginButton.onClick.AddListener(LoginButtonClicked);
    }


    private void LoginButtonClicked()
    {
        GlobalVariables.userId = int.Parse(loginInput.text);
        gameObject.SetActive(false);
        userProfilePanelControl.Show();
    }

    private void OnDestroy()
    {
        loginButton.onClick.RemoveListener(LoginButtonClicked);
    }
}
