using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour_Ninja : ButtonBehaviour {

	private List <string> itemName = new List<string>();
	private List <string> spriteName = new List<string>();
	private List <bool> ownedItem = new List<bool>();
	private List <bool> foilItem = new List<bool>();

	void Start() {
		itemName.Add ("SHINOBI ARMS"); spriteName.Add ("Ninja_Arms"); ownedItem.Add (true); foilItem.Add (false);
		itemName.Add ("SHINOBI HAT"); spriteName.Add ("Ninja_Hat"); ownedItem.Add (false); foilItem.Add (false);
		itemName.Add ("SHINOBI WISDOM"); spriteName.Add ("Ninja_Head"); ownedItem.Add (false); foilItem.Add (false);
		itemName.Add ("SHINOBI PACK"); spriteName.Add ("Ninja_Jetpack"); ownedItem.Add (true); foilItem.Add (true);
	}

	public void setNinjaList(){

		//resetSlotsImage ();

		for (int i = 0; i < itemName.Count; i++) {
			setCardItem (i, ownedItem [i], foilItem [i], itemName [i], spriteName [i]);
		}
	}
}
