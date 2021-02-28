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
    public Score scoreController;
    public InGameCharacterFactory inGameCharacterFactory;

    public Button moveButton;
    public Button attackButton;
    private bool isMoveButton = true;

    private void Awake()
    {
        InGameEventService.Instance.Clear();    
    }

    private void Start()
    {
        Character character = inGameCharacterFactory.GetCharacter();
        characterController.character = character;

        Invoke("AddClickEventMoveButton", 1.0f);


        InGameEventService.Instance.hitCharacterEvent += hpController.DecreaseHP;
        int hp = characterController.character.GetComponent<Character>().GetHP();
        hpController.SetHP(hp);

        InGameEventService.Instance.enterGroundEvent += SetEnableButtonTrue;
        InGameEventService.Instance.enterGroundEvent += characterController.PlayIdle;

        InGameEventService.Instance.dieCharacterEvent += () =>
        {
            int bestScore = PlayerInfo.Instance.GetBestScore();
            int score = scoreController.getScoreValue();
            resultController.ShowResultPopup(bestScore, score);
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
            mapController.MoveMap();

            characterController.PlayJump();
            scoreController.addScoreValue(1);
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
