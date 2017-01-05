using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour_Pirate : ButtonBehaviour {

	private List <string> itemName = new List<string>();
	private List <string> spriteName = new List<string>();
	private List <bool> ownedItem = new List<bool>();
	private List <bool> foilItem = new List<bool>();

	void Start() {
		itemName.Add ("PIRATE ARMS"); spriteName.Add ("Pirate_Arms"); ownedItem.Add (false); foilItem.Add (false);
		itemName.Add ("YAARRR!!"); spriteName.Add ("Pirate_Hat"); ownedItem.Add (true); foilItem.Add (false);
		itemName.Add ("PIRATE BEARD"); spriteName.Add ("Pirate_Head"); ownedItem.Add (true); foilItem.Add (false);
		itemName.Add ("RUM PACK"); spriteName.Add ("Pirate_Jetpack"); ownedItem.Add (true); foilItem.Add (false);
		itemName.Add ("PERNA DE PAU"); spriteName.Add ("Pirate_Legs"); ownedItem.Add (false); foilItem.Add (false);
		itemName.Add ("PIRATE BODY"); spriteName.Add ("Pirate_Torso"); ownedItem.Add (false); foilItem.Add (false);
	}

	public void setPirateList(){

		resetSlots ();

		for (int i = 0; i < itemName.Count; i++) {
			setCardItem (i, ownedItem [i], foilItem [i], itemName [i], spriteName [i]);
		}
	}
}
