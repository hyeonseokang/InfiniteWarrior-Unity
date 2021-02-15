using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameService : MonoBehaviour
{
    public MapController mapController;
    public CharacterController characterController;
    public HpController hpController;
    public ResultController resultController;

    public Button moveButton;
    private bool isMoveButton = true;

    private void Start()
    {
        Invoke("AddClickEventMoveButton", 1.0f);


        InGameEventService.Instance.hitCharacterEvent += hpController.DecreaseHP;
        int hp = characterController.character.GetComponent<Character>().GetHP();
        hpController.SetHP(hp);

        InGameEventService.Instance.enterGroundEvent += SetEnableButtonTrue;
        InGameEventService.Instance.enterGroundEvent += characterController.PlayIdle;

        InGameEventService.Instance.dieCharacterEvent += () =>
        {
            resultController.ShowResultPopup(100, 200);
        };
    }

    public void AddClickEventMoveButton()
    {
        moveButton.onClick.AddListener(() =>
        {
            Debug.Log("시작");
            if (isMoveButton == false)
                return;

            isMoveButton = false;
            mapController.CreateRandomMap();
            mapController.RemoveObject(mapController.mapObjects[0]);
            mapController.MoveMap();

            characterController.PlayJump();
        });
    }

    private void SetEnableButtonTrue()
    {
        isMoveButton = true;
    }
}
