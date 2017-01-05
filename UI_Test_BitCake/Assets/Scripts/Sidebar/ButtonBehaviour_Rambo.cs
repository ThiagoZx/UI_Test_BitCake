using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour_Rambo : ButtonBehaviour {

	private List <string> itemName = new List<string>();
	private List <string> spriteName = new List<string>();
	private List <bool> ownedItem = new List<bool>();
	private List <bool> foilItem = new List<bool>();

	void Start() {
		itemName.Add ("STRONG ARMS"); spriteName.Add ("Rambo_Arms"); ownedItem.Add (true); foilItem.Add (true);
		itemName.Add ("HAIR POWER"); spriteName.Add ("Rambo_Hat"); ownedItem.Add (true); foilItem.Add (false);
		itemName.Add ("SOLDIER TROUSERS"); spriteName.Add ("Rambo_Legs"); ownedItem.Add (true); foilItem.Add (false);
		itemName.Add ("SOLDIER SHIRT"); spriteName.Add ("Rambo_Torso"); ownedItem.Add (true); foilItem.Add (true);
	}

	public void setRamboList(){

		resetSlots ();

		for (int i = 0; i < itemName.Count; i++) {
			setCardItem (i, ownedItem [i], foilItem [i], itemName [i], spriteName [i]);
		}
	}
}
