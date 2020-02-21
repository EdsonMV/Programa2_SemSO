
/*
 * Created by SharpDevelop.
 * User: edson
 * Date: 13/02/2020
 * Time: 11:54 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace Actividad2 {
	public class Generador {
		
		private int id;
		private static int seed = Environment.TickCount;
		private Random random = new Random(seed);
		
		public Generador() { this.id = 1; }
		
		public int generateId() {
			return id++;
			}
		
		public int generateMaxTime() {
			return random.Next(7, 18);
			}
		
		public string generateOperation() {
			return Convert.ToString(random.Next(0, 20)) + generateOperator() + Convert.ToString(random.Next(1, 20));
			}
		
		private string generateOperator() {
			int valueOperator = random.Next(1, 5);
			
			switch (valueOperator) {
				case 1:
					return "+";
				case 2:
					return "-";
				case 3:
					return "*";
				case 4:
					return "/";
				case 5: 
					return "%";
				}
			return "";
			}
		}
	}
