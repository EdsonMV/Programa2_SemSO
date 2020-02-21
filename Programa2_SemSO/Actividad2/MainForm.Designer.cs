/*
 * Created by SharpDevelop.
 * User: edson
 * Date: 13/02/2020
 * Time: 11:02 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Actividad2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox gbShow;
		private System.Windows.Forms.Label lblCount;
		private System.Windows.Forms.DataGridView dgvFinished;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
		private System.Windows.Forms.Label lblInformation2;
		private System.Windows.Forms.Label lblInformation1;
		private System.Windows.Forms.DataGridView dgvExecute;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Operación;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn TT;
		private System.Windows.Forms.DataGridViewTextBoxColumn TR;
		private System.Windows.Forms.DataGridView dgvBatch;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn max_time;
		private System.Windows.Forms.GroupBox gbProcess;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TextBox txtNProcess;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblNumberProcess;
		private System.Windows.Forms.Button btnExecute;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo_transcurrido;
		private System.Windows.Forms.Timer tiempoGlobal;
		private System.Windows.Forms.DataGridViewTextBoxColumn TiempoRestante;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.gbShow = new System.Windows.Forms.GroupBox();
			this.dgvFinished = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblInformation2 = new System.Windows.Forms.Label();
			this.lblInformation1 = new System.Windows.Forms.Label();
			this.dgvExecute = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Operación = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvBatch = new System.Windows.Forms.DataGridView();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.max_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tiempo_transcurrido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TiempoRestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblCount = new System.Windows.Forms.Label();
			this.gbProcess = new System.Windows.Forms.GroupBox();
			this.btnExecute = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.txtNProcess = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblNumberProcess = new System.Windows.Forms.Label();
			this.tiempoGlobal = new System.Windows.Forms.Timer(this.components);
			this.gbShow.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFinished)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvExecute)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBatch)).BeginInit();
			this.gbProcess.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbShow
			// 
			this.gbShow.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.gbShow.Controls.Add(this.dgvFinished);
			this.gbShow.Controls.Add(this.lblInformation2);
			this.gbShow.Controls.Add(this.lblInformation1);
			this.gbShow.Controls.Add(this.dgvExecute);
			this.gbShow.Controls.Add(this.dgvBatch);
			this.gbShow.Enabled = false;
			this.gbShow.Location = new System.Drawing.Point(11, 158);
			this.gbShow.Margin = new System.Windows.Forms.Padding(2);
			this.gbShow.Name = "gbShow";
			this.gbShow.Padding = new System.Windows.Forms.Padding(2);
			this.gbShow.Size = new System.Drawing.Size(1000, 458);
			this.gbShow.TabIndex = 3;
			this.gbShow.TabStop = false;
			this.gbShow.Text = "Lotes";
			// 
			// dgvFinished
			// 
			this.dgvFinished.AllowUserToDeleteRows = false;
			this.dgvFinished.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFinished.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.dataGridViewTextBoxColumn4,
			this.dataGridViewTextBoxColumn5,
			this.dataGridViewTextBoxColumn6,
			this.dataGridViewTextBoxColumn8,
			this.Lote});
			this.dgvFinished.Location = new System.Drawing.Point(5, 215);
			this.dgvFinished.Margin = new System.Windows.Forms.Padding(2);
			this.dgvFinished.Name = "dgvFinished";
			this.dgvFinished.ReadOnly = true;
			this.dgvFinished.RowTemplate.Height = 24;
			this.dgvFinished.Size = new System.Drawing.Size(991, 228);
			this.dgvFinished.TabIndex = 4;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Id";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "Operación";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.HeaderText = "Tiempo máximo";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.HeaderText = "Resultado";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// Lote
			// 
			this.Lote.HeaderText = "Lote";
			this.Lote.Name = "Lote";
			this.Lote.ReadOnly = true;
			// 
			// lblInformation2
			// 
			this.lblInformation2.AutoSize = true;
			this.lblInformation2.Location = new System.Drawing.Point(5, 43);
			this.lblInformation2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblInformation2.Name = "lblInformation2";
			this.lblInformation2.Size = new System.Drawing.Size(0, 13);
			this.lblInformation2.TabIndex = 3;
			// 
			// lblInformation1
			// 
			this.lblInformation1.AutoSize = true;
			this.lblInformation1.Location = new System.Drawing.Point(5, 18);
			this.lblInformation1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblInformation1.Name = "lblInformation1";
			this.lblInformation1.Size = new System.Drawing.Size(0, 13);
			this.lblInformation1.TabIndex = 2;
			// 
			// dgvExecute
			// 
			this.dgvExecute.AllowUserToDeleteRows = false;
			this.dgvExecute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvExecute.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Id,
			this.Operación,
			this.dataGridViewTextBoxColumn2,
			this.TT,
			this.TR});
			this.dgvExecute.Location = new System.Drawing.Point(432, 74);
			this.dgvExecute.Margin = new System.Windows.Forms.Padding(2);
			this.dgvExecute.Name = "dgvExecute";
			this.dgvExecute.ReadOnly = true;
			this.dgvExecute.RowTemplate.Height = 24;
			this.dgvExecute.Size = new System.Drawing.Size(564, 122);
			this.dgvExecute.TabIndex = 1;
			// 
			// Id
			// 
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			// 
			// Operación
			// 
			this.Operación.HeaderText = "Operación";
			this.Operación.Name = "Operación";
			this.Operación.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Tiempo máximo";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// TT
			// 
			this.TT.HeaderText = "Tiempo transcurrido";
			this.TT.Name = "TT";
			this.TT.ReadOnly = true;
			// 
			// TR
			// 
			this.TR.HeaderText = "Tiempo restante";
			this.TR.Name = "TR";
			this.TR.ReadOnly = true;
			// 
			// dgvBatch
			// 
			this.dgvBatch.AllowUserToDeleteRows = false;
			this.dgvBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.name,
			this.max_time,
			this.Tiempo_transcurrido,
			this.TiempoRestante});
			this.dgvBatch.Location = new System.Drawing.Point(5, 74);
			this.dgvBatch.Margin = new System.Windows.Forms.Padding(2);
			this.dgvBatch.Name = "dgvBatch";
			this.dgvBatch.ReadOnly = true;
			this.dgvBatch.RowTemplate.Height = 24;
			this.dgvBatch.Size = new System.Drawing.Size(422, 122);
			this.dgvBatch.TabIndex = 0;
			// 
			// name
			// 
			this.name.HeaderText = "Id";
			this.name.Name = "name";
			this.name.ReadOnly = true;
			// 
			// max_time
			// 
			this.max_time.HeaderText = "Tiempo máximo";
			this.max_time.Name = "max_time";
			this.max_time.ReadOnly = true;
			// 
			// Tiempo_transcurrido
			// 
			this.Tiempo_transcurrido.HeaderText = "Tiempo transcurrido";
			this.Tiempo_transcurrido.Name = "Tiempo_transcurrido";
			this.Tiempo_transcurrido.ReadOnly = true;
			// 
			// TiempoRestante
			// 
			this.TiempoRestante.HeaderText = "Tiempo restante";
			this.TiempoRestante.Name = "TiempoRestante";
			this.TiempoRestante.ReadOnly = true;
			// 
			// lblCount
			// 
			this.lblCount.AutoSize = true;
			this.lblCount.Location = new System.Drawing.Point(338, 112);
			this.lblCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(53, 13);
			this.lblCount.TabIndex = 5;
			this.lblCount.Text = "Contador:";
			// 
			// gbProcess
			// 
			this.gbProcess.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.gbProcess.Controls.Add(this.lblCount);
			this.gbProcess.Controls.Add(this.btnExecute);
			this.gbProcess.Controls.Add(this.btnCreate);
			this.gbProcess.Controls.Add(this.txtNProcess);
			this.gbProcess.Controls.Add(this.label1);
			this.gbProcess.Controls.Add(this.lblNumberProcess);
			this.gbProcess.Location = new System.Drawing.Point(11, 15);
			this.gbProcess.Margin = new System.Windows.Forms.Padding(2);
			this.gbProcess.Name = "gbProcess";
			this.gbProcess.Padding = new System.Windows.Forms.Padding(2);
			this.gbProcess.Size = new System.Drawing.Size(474, 132);
			this.gbProcess.TabIndex = 2;
			this.gbProcess.TabStop = false;
			this.gbProcess.Text = "Captura";
			// 
			// btnExecute
			// 
			this.btnExecute.Location = new System.Drawing.Point(221, 64);
			this.btnExecute.Margin = new System.Windows.Forms.Padding(2);
			this.btnExecute.Name = "btnExecute";
			this.btnExecute.Size = new System.Drawing.Size(81, 41);
			this.btnExecute.TabIndex = 15;
			this.btnExecute.Text = "Ejecutar";
			this.btnExecute.UseVisualStyleBackColor = true;
			this.btnExecute.Click += new System.EventHandler(this.BtnExecuteClick);
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(138, 64);
			this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(79, 41);
			this.btnCreate.TabIndex = 14;
			this.btnCreate.Text = "Crear";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.BtnCreateClick);
			// 
			// txtNProcess
			// 
			this.txtNProcess.Location = new System.Drawing.Point(138, 31);
			this.txtNProcess.Margin = new System.Windows.Forms.Padding(2);
			this.txtNProcess.Name = "txtNProcess";
			this.txtNProcess.Size = new System.Drawing.Size(204, 20);
			this.txtNProcess.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 38);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Numero de procesos: ";
			// 
			// lblNumberProcess
			// 
			this.lblNumberProcess.AutoSize = true;
			this.lblNumberProcess.Location = new System.Drawing.Point(5, 92);
			this.lblNumberProcess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNumberProcess.Name = "lblNumberProcess";
			this.lblNumberProcess.Size = new System.Drawing.Size(0, 13);
			this.lblNumberProcess.TabIndex = 11;
			// 
			// tiempoGlobal
			// 
			this.tiempoGlobal.Interval = 1000;
			this.tiempoGlobal.Tick += new System.EventHandler(this.GlobalTimerTick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSlateGray;
			this.ClientSize = new System.Drawing.Size(1026, 632);
			this.Controls.Add(this.gbShow);
			this.Controls.Add(this.gbProcess);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "Programa 2";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.gbShow.ResumeLayout(false);
			this.gbShow.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFinished)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvExecute)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBatch)).EndInit();
			this.gbProcess.ResumeLayout(false);
			this.gbProcess.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
