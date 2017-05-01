using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;

	private enum States {cell, mirror, sheets_0, lock_0, sheets_1, lock_1, freedom};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if(myState == States.cell){
			state_cell();
		} else if (myState == States.sheets_0
	}

	void state_cell(){
		text.text = "You wake up feeling dizzy and disoriented. The air is damp, and the little light comes " +
			"into the room from a very small window at the top of your cell. " +
				"Looking around, you don't see many things in your cell: a wall mirror, dirty sheets on the bed, " + 
				"and of course, a locked door.\n\n" +
	 			"Press S to view the Sheets, M to view the Mirror, L to view the Lock";

			if(Input.GetKeyDown(KeyCode.S)){
			myState = States.sheets_0;
			}
	}
}
