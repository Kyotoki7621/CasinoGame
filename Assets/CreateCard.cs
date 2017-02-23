using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Define{
	public const int SHEETS=53;

}
public class CreateCard : MonoBehaviour {

	public GameObject card;
	public GameObject[] Deck=new GameObject[Define.SHEETS];
	//int cardCount=0;
	private GameObject trump;
	private float SetCard=0.0f;
	private Vector3 DeckPos;


 	void Shuffle (GameObject[] deck) {
        for (int i = 0; i < deck.Length; i++) {
            GameObject temp = deck[i];
            int randomIndex = Random.Range(0, deck.Length);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = temp;
        }
    }

	// Use this for initialization
	void Start () {
		DeckPos=this.transform.position;
		for(int i=0;i<Deck.Length;i++){
			trump=Instantiate(card) as GameObject;
			Deck[i]=trump;	
		}
		Shuffle(Deck);

		for(int i=0;i<Deck.Length;i++){
			Deck[i].transform.position=new Vector3(DeckPos.x,SetCard,DeckPos.z);
			SetCard+=0.01f;//(int)Deck[i].transform.localScale.y;
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
