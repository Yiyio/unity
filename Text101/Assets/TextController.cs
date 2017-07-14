using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;

	private enum States {cell, mirror, sheets_0, lock_0, sheets_1, lock_1, cell_mirror, freedom};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if(myState == States.cell)	{state_cell();}
		else if (myState == States.sheets_0)	{state_sheets_0();} 
		else if (myState == States.sheets_1)	{state_sheets_1();} 
		else if (myState == States.lock_0)	{state_lock_0();} 
		else if (myState == States.lock_1)	{state_lock_1();} 
		else if (myState == States.mirror)	{state_mirror();} 
		else if (myState == States.cell_mirror)	{state_cell_mirror();} 
		else if (myState == States.freedom)	{state_freedom();} 
	}

	void state_cell(){
		text.text = "You wake up feeling dizzy and disoriented. The air is damp, and the little light comes " +
			"into the room from a very small window at the top of your cell. " +
				"Looking around, you don't see many things in your cell: a wall mirror, dirty sheets on the bed, " + 
				"and of course, a locked door.\n\n" +
				"Press S to view the Sheets, M to view the Mirror, L to view the Lock";
		
		if(Input.GetKeyDown(KeyCode.S)){
			myState = States.sheets_0;
		} else if(Input.GetKeyDown(KeyCode.M)){
			myState = States.mirror;
		} else if(Input.GetKeyDown(KeyCode.L)){
			myState = States.lock_0;
		}
	} 

	void state_mirror(){
		text.text = "Mirror Mirror on the wall \n\n True hope lies beyond the coast \n\n You're a damned kind can't you see \n\n That the winds will change\n\n " +
	 				"Press G to get the mirror, or R to go back to your cell";

			if(Input.GetKeyDown(KeyCode.G)){
				myState = States.cell_mirror;
		} else if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
	}



	void state_cell_mirror(){
		text.text = "You are still in your cell. Something feels different, as if a breath of fresh air had " +
			"come suddenly from the depths of the dungeon, giving you some hope\n\n" + 

				"Press S to view the Sheets, or L to view the Lock";
		
		if(Input.GetKeyDown(KeyCode.S)){
			myState = States.sheets_1;
		} else if(Input.GetKeyDown(KeyCode.L)){
			myState = States.lock_1;
		}
	}

	void state_sheets_0(){
		text.text = "Not quite the kind of bed you had back at your parent's house. " +
			         "Thanks god they taught you how to make the bed, I guess. \n\n" +
				     "Press R to return to roaming your cell";
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
	} 	void state_sheets_1(){
		text.text = "Still doesn't look as nice as the bed you had back at your parent's house. " +
			"\n\n" +
				"Press R to return to roaming your cell";
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell_mirror;
		}
	}

	void state_lock_0(){
		text.text = "You get closer to the lock, but can't see much of it." +
			"The angle is simply not very good \n\n" +
				"Press R to return to roaming your cell";
		
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
	}

	void state_lock_1(){
		text.text = "Now you can see the lock properly. You examine it closely with the mirror " +
			"and find that someone left the key inside the lock! \n\n" +
				"Press O to Open the lock, or R to return to roaming your cell";
		
		if(Input.GetKeyDown(KeyCode.O)){
			myState = States.freedom;
		} else if (Input.GetKeyDown(KeyCode.R)){
			myState = States.cell_mirror;
		}
	}

	void state_freedom(){
		text.text = "FREEDOM! It tastes good \n\n" +
				"Press P to play this varied game again!";
		
		if(Input.GetKeyDown(KeyCode.P)){
			myState = States.cell;
		}
	}
}
