/*
 * Created by SharpDevelop.
 * User: edson
 * Date: 13/02/2020
 * Time: 11:16 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text.RegularExpressions;

namespace Actividad2 {
		public class Process {
		
		private int field_id;
		private string field_operation;
		private int field_maxTime;
		private string field_result;
		private int field_timeElapsed;
		private int field_timeRestant;
		
		public Process() {
			}
		
		public Process(int _id, string _operation, int _maxTime) {
			this.Id = _id;
			this.Operation = _operation;
			this.MaxTime = _maxTime;
			this.Result = "";
			this.TimeElapsed = 0;
			this.TimeRestant = 0;
			}
		
		public int Id {
			get { return field_id; }
			set { field_id = value; }
			}
		
		public string Operation {
			get { return field_operation; }
			set { field_operation = value; }
			}
		
		public int MaxTime {
			get { return field_maxTime; }
			set {
				if (value <= 0) throw new Exception("El valor del tiempo máximo debe ser mayor que 0.");
				field_maxTime = value;
				}
			}	
		
		public string Result {
			get { return field_result; }
			set { field_result = value; }
			}
		
		public int TimeElapsed {
			get { return field_timeElapsed; }
			set { field_timeElapsed = value; }
			}
		public int TimeRestant {
			get { return field_timeRestant; }
			set { field_timeRestant = value; }
			}
		}
	}
