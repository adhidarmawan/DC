using UnityEngine;
using System.Collections;
using System.IO;

public static class SupernaturalReader {
	public static SupernaturalManager AssessGhosts() {
		SupernaturalManager manager = new SupernaturalManager ();
		string[] locations = initialize ();
		ReadToManager (locations, manager);
		return manager;
	}

	/* Generic Code */

	private static string[] initialize() {
		if (!Directory.Exists (GeneralManager.FILES_LOCATION))
			return null;
		return Directory.GetFiles (GeneralManager.FILES_LOCATION);
	}

	private static void ReadToManager(string[] loc, SupernaturalManager mgr) {
		if (mgr == null)
			mgr = new SupernaturalManager ();
		foreach (string file in loc) {
			Debug.Log(file.ToString());
			ParseInfo (file, mgr);
		}
	}

	/* For reusability, only modify this method if you need to as the files vary! */

	private static void ParseInfo(string location, SupernaturalManager mgr) {
		StreamReader sr  = new StreamReader (location);
		string[] ghostInfo = sr.ReadToEnd ().Split (System.Environment.NewLine.ToCharArray());
		if (ghostInfo.Length != 4)
			return;
		if (ghostInfo[0].Equals ("AGGRESSIVE", System.StringComparison.InvariantCultureIgnoreCase))
			mgr.RegisterMember (ghostInfo[1], new AggressiveSupernatural(ghostInfo[2], ghostInfo[3]));
		if (ghostInfo [0].Equals ("PASSIVE", System.StringComparison.InvariantCultureIgnoreCase))
			mgr.RegisterMember (ghostInfo [1], new PassiveSupernatural (ghostInfo [2], ghostInfo [3]));
	}
}
