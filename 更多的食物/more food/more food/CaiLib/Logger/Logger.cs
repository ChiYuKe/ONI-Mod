using System;
using KMod;

namespace CaiLib.Logger
{
	// Token: 0x02000010 RID: 16
	public static class Logger
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00002CC4 File Offset: 0x00000EC4
		public static void LogInit(Mod mod)
		{
			Logger._mod = mod;
			string[] array = new string[5];
			array[0] = Logger.Timestamp();
			array[1] = " <<-- CaiLib -->> Loaded [ ";
			array[2] = ((mod != null) ? mod.title : null);
			array[3] = " ] with version ";
			int num = 4;
			bool flag = mod == null;
			string text;
			if (flag)
			{
				text = null;
			}
			else
			{
				Mod.PackagedModInfo packagedModInfo = mod.packagedModInfo;
				text = ((packagedModInfo != null) ? packagedModInfo.version : null);
			}
			array[num] = text;
			Console.WriteLine(string.Concat(array));
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002D40 File Offset: 0x00000F40
		public static void Log(string message)
		{
			bool flag = Logger._mod == null;
			if (flag)
			{
				Console.WriteLine(Logger.Timestamp() + " <<-- CaiLib -->> Looks like you have not called LogInit! Please do that before using CaiLib.Log()");
			}
			string[] array = new string[5];
			array[0] = Logger.Timestamp();
			array[1] = " <<-- ";
			int num = 2;
			Mod mod = Logger._mod;
			array[num] = ((mod != null) ? mod.title : null);
			array[3] = " -->> ";
			array[4] = message;
			Console.WriteLine(string.Concat(array));
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002DB8 File Offset: 0x00000FB8
		private static string Timestamp()
		{
			return System.DateTime.UtcNow.ToString("[HH:mm:ss.fff]");
		}

		// Token: 0x0400001A RID: 26
		private static Mod _mod;
	}
}
