﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary {
	class Program {
		void Run() {
			Dictionary<string, string> StateCodes = new Dictionary<string, string>();
			StateCodes["OH"] = "Ohio";
			StateCodes["KY"] = "Kentucky";
			StateCodes["IN"] = "Indiana";


			

			foreach(var key in StateCodes.Keys) {
				Console.WriteLine($"The state name for code KY is {StateCodes["KY"]}");
			}
		}
		static void Main(string[] args) {
			new Program().Run();
		}
	}
}
