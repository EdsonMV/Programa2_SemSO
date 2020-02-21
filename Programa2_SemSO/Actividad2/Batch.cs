/*
 * Created by SharpDevelop.
 * User: edson
 * Date: 13/02/2020
 * Time: 11:22 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Actividad2 {
	public class Batch {
		private Process [] field_batch = new Process[5];
		private int field_count;
		
		public Batch() { field_count = 0; }
		
		public int Count {
			get { return field_count; }
			}
		
		public void insertProcess(Process p) {
			field_batch[field_count] = p;
			field_count++;
			}
		
		public Boolean isBatchEmpty() {
			if (field_count == 0) { return true; }
			return false;
			}
		
		public Boolean isBatchFull() {
			if (field_count == 5) return true;
			return false;
			}
		
		public Process getProcess(int pos) {
			return field_batch[pos];
			}
		}
	}
