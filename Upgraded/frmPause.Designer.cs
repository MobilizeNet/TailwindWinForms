
namespace TailwindPOS
{
	partial class frmPause
	{

		#region "Upgrade Support "
		private static frmPause m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmPause DefInstance
		{
			get
			{
				if (m_vb6FormDefInstance is null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new frmPause();
					m_InitializingDefInstance = false;
				}
				return m_vb6FormDefInstance;
			}
			set
			{
				m_vb6FormDefInstance = value;
			}
		}

		#endregion
		#region "Windows Form Designer generated code "
		private string[] visualControls = new string[]{"components", "ToolTipMain", "cbReturn", "lblPauseMessage", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button cbReturn;
		public System.Windows.Forms.Label lblPauseMessage;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPause));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			cbReturn = new System.Windows.Forms.Button();
			lblPauseMessage = new System.Windows.Forms.Label();
			SuspendLayout();
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			// 
			// cbReturn
			// 
			cbReturn.AllowDrop = true;
			cbReturn.BackColor = System.Drawing.Color.FromArgb(97, 44, 67);
			cbReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbReturn.ForeColor = System.Drawing.SystemColors.ControlText;
			cbReturn.Location = new System.Drawing.Point(224, 160);
			cbReturn.Name = "cbReturn";
			cbReturn.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cbReturn.Size = new System.Drawing.Size(417, 81);
			cbReturn.TabIndex = 1;
			cbReturn.Text = "Return";
			cbReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbReturn.UseVisualStyleBackColor = false;
			cbReturn.Click += new System.EventHandler(cbReturn_Click);
			// 
			// lblPauseMessage
			// 
			lblPauseMessage.AllowDrop = true;
			lblPauseMessage.BackColor = System.Drawing.Color.White;
			lblPauseMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblPauseMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblPauseMessage.ForeColor = System.Drawing.SystemColors.ControlText;
			lblPauseMessage.Location = new System.Drawing.Point(56, 32);
			lblPauseMessage.MinimumSize = new System.Drawing.Size(713, 73);
			lblPauseMessage.Name = "lblPauseMessage";
			lblPauseMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblPauseMessage.Size = new System.Drawing.Size(713, 73);
			lblPauseMessage.TabIndex = 0;
			lblPauseMessage.Text = "POS Paused";
			lblPauseMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// frmPause
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.Window;
			ClientSize = new System.Drawing.Size(844, 334);
			ControlBox = false;
			Controls.Add(cbReturn);
			Controls.Add(lblPauseMessage);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			Location = new System.Drawing.Point(3, 26);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmPause";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			ShowInTaskbar = false;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Tailwind Point of Sale Paused";
			commandButtonHelper1.SetStyle(cbReturn, 1);
			Activated += new System.EventHandler(frmPause_Activated);
			Closed += new System.EventHandler(Form_Closed);
			Load += new System.EventHandler(Form_Load);
			ResumeLayout(false);
		}
		#endregion
	}
}