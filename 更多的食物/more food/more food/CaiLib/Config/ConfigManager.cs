using System;
using System.IO;
using CaiLib.Logger;
using KMod;
using Newtonsoft.Json;

namespace CaiLib.Config
{
	// Token: 0x02000011 RID: 17
	public class ConfigManager<T> where T : class, new()
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002DDC File Offset: 0x00000FDC
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00002DE4 File Offset: 0x00000FE4
		public T Config { get; set; }

		// Token: 0x06000035 RID: 53 RVA: 0x00002DED File Offset: 0x00000FED
		public ConfigManager(Mod mod, string configFileName = "Config.json")
		{
			this._modPath = mod.ContentPath;
			this._configFileName = configFileName;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002E0C File Offset: 0x0000100C
		public T ReadConfig(System.Action postReadAction = null)
		{
			this.Config = Activator.CreateInstance<T>();
			string text = Path.Combine(this._modPath, this._configFileName);
			Debug.Log(text);
			T config;
			try
			{
				using (StreamReader streamReader = new StreamReader(text))
				{
					config = JsonConvert.DeserializeObject<T>(streamReader.ReadToEnd());
				}
			}
			catch (Exception ex)
			{
				CaiLib.Logger.Logger.Log("Failed to read config file " + this._configFileName + " with exception: " + ex.Message);
				return this.Config;
			}
			this.Config = config;
			bool flag = postReadAction != null;
			if (flag)
			{
				postReadAction();
			}
			return this.Config;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002ED8 File Offset: 0x000010D8
		public bool SaveConfigToFile()
		{
			string directoryName = Path.GetDirectoryName(this._modPath);
			bool flag = directoryName == null;
			bool result;
			if (flag)
			{
				CaiLib.Logger.Logger.Log(string.Concat(new string[]
				{
					"Failed to read file ",
					this._configFileName,
					" - cannot get directory name for executing assembly path ",
					this._modPath,
					"."
				}));
				result = false;
			}
			else
			{
				string path = Path.Combine(directoryName, this._configFileName);
				try
				{
					using (StreamWriter streamWriter = new StreamWriter(path))
					{
						string value = JsonConvert.SerializeObject(this.Config, Formatting.Indented);
						streamWriter.Write(value);
					}
				}
				catch (Exception ex)
				{
					CaiLib.Logger.Logger.Log("Failed to write to config file " + this._configFileName + " with exception: " + ex.Message);
					return false;
				}
				result = true;
			}
			return result;
		}

		// Token: 0x0400001C RID: 28
		private readonly string _modPath;

		// Token: 0x0400001D RID: 29
		private readonly string _configFileName;
	}
}
