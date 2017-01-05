using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public abstract class ButtonBehaviour : MonoBehaviour {

	private List <GameObject> texts = GameObject.FindGameObjectsWithTag ("Text");
	private List <GameObject> cards = GameObject.FindGameObjectsWithTag ("Cards");
	private List <bool> owneds = new List<bool>();

	void setCardItemName (int slot, bool owned, string name){
		List <Text> currentSlot = texts [slot].GetComponentsInChildren<Text> ();
		currentSlot [0].text = name;

		if (owned) {
			currentSlot [1] = "";
		} else {
			currentSlot [1] = "?";
		}

		setCardItemBackground (cards[slot], name, owned);

	}

	virtual void setCardItemBackground (GameObject card, string itemName, bool owned) { }

	void resetSlotsImage(){
		for (int i = 0; i < 6; i++) {
			List <Image> currentSlot = cards [i].GetComponentsInChildren<Image> ();
			//I hate these lines looking like the same but...
			currentSlot [0].sprite = null;
			currentSlot [0].color = new Color(1,1,1,0);
			currentSlot [1].sprite = null;
			currentSlot [1].color = new Color(1,1,1,0);
		}
	}
}
