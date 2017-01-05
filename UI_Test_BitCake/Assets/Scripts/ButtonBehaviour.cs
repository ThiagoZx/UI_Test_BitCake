using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public abstract class ButtonBehaviour : MonoBehaviour {

	protected GameObject[] texts ;
	protected GameObject[] cards ;

	void Start() {
		texts = GameObject.FindGameObjectsWithTag ("Text");
		cards = GameObject.FindGameObjectsWithTag ("Cards");
	}

	public void setCardItem (int slot, bool owned, bool foil, string name, string itemName){
		Text[] currentSlotText = texts [slot].GetComponentsInChildren<Text> ();
		Image[] currentSlotImage = cards [slot].GetComponentsInChildren<Image> ();

		string[] currentPage = itemName.Split ('_');

		currentSlotText [0].text = "";
		currentSlotText [1].text = name;

		if (foil) {

			//Setting card background to foil
			currentSlotImage [0].sprite = Resources.Load<Sprite> ("Images/card_bg_foil") as Sprite;
			currentSlotImage [0].color = new Color (1, 1, 1, 1);

			//Setting item image to foil
			currentSlotImage [1].sprite = Resources.Load<Sprite> ("Images/items/" + currentPage [0] + "/" + itemName + "_foil") as Sprite;
			currentSlotImage [1].color = new Color (1, 1, 1, 1);

		} else if (owned) {

			//Setting card background to normal
			currentSlotImage [0].sprite = Resources.Load<Sprite> ("Images/card_bg") as Sprite;
			currentSlotImage [0].color = new Color (1, 1, 1, 1);

			//Setting item image to normal
			currentSlotImage [1].sprite = Resources.Load<Sprite> ("Images/items/" + currentPage [0] + "/" + itemName) as Sprite;
			currentSlotImage [1].color = new Color (1, 1, 1, 1);

		} else {

			currentSlotText [0].text = "?";

			//Setting card background to normal
			currentSlotImage [0].sprite = Resources.Load<Sprite> ("Images/empty_card_bg") as Sprite;
			currentSlotImage [0].color = new Color (1, 1, 1, 1);
		
		}
	}

	public void resetSlotsImage(){
		for (int i = 0; i < 6; i++) {
			Image[] currentSlot = cards [i].GetComponentsInChildren<Image> ();
			currentSlot [0].sprite = null;
			currentSlot [0].color = new Color(1,1,1,0);
			currentSlot [1].sprite = null;
			currentSlot [1].color = new Color(1,1,1,0);
		}
	}
}
