using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameService : MonoBehaviour
{
    public MapController mapController;
    public CharacterController characterController;
    public HpController hpController;
    public Button moveButton;
    private bool isMoveButton = true;

    private void Start()
    {
        AddClickEventMoveButton();


        InGameEventService.Instance.hitCharacterEvent += hpController.DecreaseHP;
        int hp = characterController.character.GetComponent<Character>().GetHP();
        hpController.SetHP(hp);
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

            Invoke("SetEnableButtonTrue", 0.6f);
        });
    }

    private void SetEnableButtonTrue()
    {
        isMoveButton = true;
    }
}
