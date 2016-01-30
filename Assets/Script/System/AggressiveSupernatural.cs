using UnityEngine;
using System.Collections;

public class AggressiveSupernatural : Supernaturals {
	public AggressiveSupernatural(string name, string description) : base(name, description) {
	}

	public override void appear() {
		// Make an appearance!
	}

	public override void attack() {
		// Implement this in accordance to the other's codes.
	}

	public override void attacked() {
		// Usually give a flashing effect, before disappearing.
		disappear ();
	}

	public override void disappear() {
		// Usually call a scream sound, marking the ghost has disappeared. May not be implemented in this version.
	}
}
