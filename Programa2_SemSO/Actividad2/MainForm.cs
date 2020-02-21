/*
 * Created by SharpDevelop.
 * User: edson
 * Date: 13/02/2020
 * Time: 11:02 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Actividad2 {
	
	
	public partial class MainForm : Form {
		
		private Process procesoActual = new Process();
		private Process[] arrayOfProcess = new Process[5];
		private List<Batch> listaLotes = new List<Batch>();
		private Queue<Process> loteActual = new Queue<Process>();
		private string estado = "continue";
		private int contadorLocal = 0;
		private int maxTime = 0;
		private int contadorProcesos = 0;
		private int contadorPantalla = 0;
		private int i = 0;
		private bool firstTime = true;
		private bool procesoFinalizado = true;
		private bool finalizado = false;
		
		public MainForm() {
			InitializeComponent();
			dgvBatch.Rows.Add(3);
			}
		
		static Double eval(String expression) {
    		var table = new System.Data.DataTable();
    		return Convert.ToDouble(table.Compute(expression, String.Empty));
			}
		
		void BtnCreateClick(object sender, EventArgs e) {
			try {	
				Generador myGenerator = new Generador();
				float numberProcess = Convert.ToInt16(txtNProcess.Text);
				double numberOfBatches = Math.Ceiling(numberProcess / 5);
				int batchCount = 0;
	
				for (int i = 0; i < numberOfBatches; i++) {
					Batch newBatch = new Batch();
					listaLotes.Add(newBatch);
					}
				
				for (int i = 0; i < numberProcess; i++) {
					
					if (listaLotes[batchCount].isBatchFull()) {
						batchCount++;
						}
					
					Process newProcess = new Process();
					newProcess.Id = myGenerator.generateId();
					newProcess.Operation = myGenerator.generateOperation();
					newProcess.MaxTime = myGenerator.generateMaxTime();
					newProcess.Result = Convert.ToString(eval(newProcess.Operation));
					listaLotes[batchCount].insertProcess(newProcess);
					btnCreate.Enabled = false;
					}
				}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
				}
			}
		
		void BtnExecuteClick(object sender, EventArgs e) {
			gbProcess.Enabled = false;
			gbShow.Enabled = true;
			maxTime = procesoActual.MaxTime;
			tiempoGlobal.Enabled = true;
			dgvExecute.Rows.Clear();
		}
		
		public void insertarProceso() {
			dgvFinished.Rows.Add(1);
			dgvFinished.Rows[contadorProcesos].Cells[0].Value = procesoActual.Id;
			dgvFinished.Rows[contadorProcesos].Cells[1].Value = procesoActual.Operation;
			dgvFinished.Rows[contadorProcesos].Cells[2].Value = procesoActual.MaxTime;	
			dgvFinished.Rows[contadorProcesos].Cells[3].Value = procesoActual.Result;
			dgvFinished.Rows[contadorProcesos++].Cells[4].Value = i;
			}
		
		void MainFormKeyDown(object sender, KeyEventArgs e) { 
			
			if (finalizado) return;
			
			if (e.KeyCode == Keys.P) { 
				tiempoGlobal.Enabled = false;
				estado = "pause";
				}
			else if (e.KeyCode == Keys.C) {
				tiempoGlobal.Enabled = true;
				estado = "continue";
				}
			else if (e.KeyCode == Keys.E && estado != "pause") {
				tiempoGlobal.Enabled = false;
				procesoActual.Result = "ERROR";
				insertarProceso();
				if (loteActual.Count != 0) {
					procesoFinalizado = true;
					}
				else {
					firstTime = true;
					procesoFinalizado = true;
					}
				dgvExecute.Rows.Clear();
				
				if (i >= listaLotes.Count && loteActual.Count == 0) {
					tiempoGlobal.Enabled = false;
					return;
					}
				
				tiempoGlobal.Enabled = true;
				estado = "error";
				}
			else if (e.KeyCode == Keys.I && estado != "pause") {
				loteActual.Enqueue(procesoActual);
				procesoActual = loteActual.Dequeue();
				contadorLocal = procesoActual.TimeElapsed;
				maxTime = procesoActual.MaxTime;
				updateTable();
				estado = "interrpcion";
				}
			}
		
		void updateTable() {
			arrayOfProcess = loteActual.ToArray();
			for (int j = 0; j < loteActual.Count; j++) {
				dgvBatch.Rows[j].Cells[0].Value = arrayOfProcess[j].Id;
				dgvBatch.Rows[j].Cells[1].Value = arrayOfProcess[j].MaxTime;
				dgvBatch.Rows[j].Cells[2].Value = arrayOfProcess[j].TimeElapsed;
				dgvBatch.Rows[j].Cells[3].Value = arrayOfProcess[j].TimeRestant;
				}
			}
		
		void GlobalTimerTick(object sender, EventArgs e) {
			
			
			if (firstTime && i < listaLotes.Count) {
				for (int j = 0; j < listaLotes[i].Count; j++) {
					loteActual.Enqueue(listaLotes[i].getProcess(j));
					}
				i++;
				firstTime = false;
				}
			
			lblInformation1.Text = "Lotes pendientes: " + Convert.ToString(listaLotes.Count - i);
			lblInformation2.Text = "Lote actual: " + i.ToString();
			
			if (procesoFinalizado && loteActual.Count != 0) {
				dgvBatch.Rows.Clear();
				dgvBatch.Rows.Add(3);
				procesoActual = loteActual.Dequeue();
				arrayOfProcess = loteActual.ToArray();	
				contadorLocal = procesoActual.TimeElapsed;
				maxTime = procesoActual.MaxTime;
				
				for (int j = 0; j < loteActual.Count; j++) {
					dgvBatch.Rows[j].Cells[0].Value = arrayOfProcess[j].Id;
					dgvBatch.Rows[j].Cells[1].Value = arrayOfProcess[j].MaxTime;
					dgvBatch.Rows[j].Cells[2].Value = arrayOfProcess[j].TimeElapsed;
					dgvBatch.Rows[j].Cells[3].Value = arrayOfProcess[j].TimeRestant;
					}
				
				procesoFinalizado = false;
				}
			
			if (contadorLocal < maxTime) {
				dgvExecute.Rows[0].Cells[0].Value = procesoActual.Id;
				dgvExecute.Rows[0].Cells[1].Value = procesoActual.Operation;
				dgvExecute.Rows[0].Cells[2].Value = maxTime;
				dgvExecute.Rows[0].Cells[3].Value = contadorLocal;
				dgvExecute.Rows[0].Cells[4].Value = maxTime - contadorLocal;
				procesoActual.TimeRestant = maxTime - contadorLocal;
				procesoActual.TimeElapsed = contadorLocal++;
				lblCount.Text = "Contador: " + contadorPantalla++.ToString();
				}
			else {
				if (i >= listaLotes.Count && loteActual.Count == 0 && finalizado) {
					tiempoGlobal.Enabled = false;
					return;
					}
				else if (i >= listaLotes.Count && loteActual.Count == 0 && !finalizado) {
					finalizado = true;
					}	
				
				procesoFinalizado = true;
				insertarProceso();
				dgvExecute.Rows.Clear();
				
				if (loteActual.Count == 0 && i < listaLotes.Count) firstTime = true;
				}
			}
		}
	}	
