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
    public Button attackButton;
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
            if (isMoveButton == false)
                return;

            isMoveButton = false;
            mapController.CreateRandomMap();
            mapController.RemoveObject(mapController.mapObjects[0]);
            mapController.MoveMap();

            characterController.PlayJump();
        });

        attackButton.onClick.AddListener(() =>
        {
            characterController.PlayAttack();
        });
    }

    private void SetEnableButtonTrue()
    {
        isMoveButton = true;
    }
}
