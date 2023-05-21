using System;

namespace Pholib
{
	public class Logs
	{
		public static void InitIfNot()
		{
			if (Logs.initiated)
			{
				return;
			}
			Debug.Log("== Game Launched with Pholib " + Logs.version + "  " + System.DateTime.Now.ToString());
			Logs.initiated = true;
		}

		public static void Log(string informations)
		{
			Logs.InitIfNot();
			Debug.Log("Pholib: " + informations);
		}

		public static void Log(object informations)
		{
			Logs.InitIfNot();
			Debug.Log(("Pholib: " + ((informations != null) ? informations.ToString() : null) == null) ? "null" : informations.ToString());
		}

		public static void LogIfDebugging(string informations)
		{
			Logs.InitIfNot();
			if (Logs.DebugLog)
			{
				Debug.Log("Pholib: " + informations);
			}
		}

		private static readonly string version = "1.3";

		public static bool DebugLog = false;

		private static bool initiated = false;
	}
}
