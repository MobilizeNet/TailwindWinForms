
namespace TailwindPOS
{
	partial class frmSearchCust
	{

		#region "Upgrade Support "
		private static frmSearchCust m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmSearchCust DefInstance
		{
			get
			{
				if (m_vb6FormDefInstance is null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new frmSearchCust();
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
		private string[] visualControls = new string[]{"components", "ToolTipMain", "ucLettersPad", "cbClose", "fgCustomers", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public ucLettersPad ucLettersPad;
		public System.Windows.Forms.Button cbClose;
		public UpgradeHelpers.DataGridViewFlex fgCustomers;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchCust));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			ucLettersPad = new ucLettersPad();
			cbClose = new System.Windows.Forms.Button();
			fgCustomers = new UpgradeHelpers.DataGridViewFlex(components);
			SuspendLayout();
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			((System.ComponentModel.ISupportInitialize) fgCustomers).BeginInit();
			// 
			// ucLettersPad
			// 
			ucLettersPad.AllowDrop = true;
			ucLettersPad.Location = new System.Drawing.Point(8, 24);
			ucLettersPad.Name = "ucLettersPad";
			ucLettersPad.Size = new System.Drawing.Size(633, 569);
			ucLettersPad.TabIndex = 0;
			ucLettersPad.OnEnterEvent += new ucLettersPad.OnEnterEventHandler(ucLettersPad_OnEnterEvent);
			// 
			// cbClose
			// 
			cbClose.AllowDrop = true;
			cbClose.BackColor = System.Drawing.Color.FromArgb(97, 44, 67);
			cbClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbClose.ForeColor = System.Drawing.SystemColors.ControlText;
			cbClose.Location = new System.Drawing.Point(1008, 640);
			cbClose.Name = "cbClose";
			cbClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cbClose.Size = new System.Drawing.Size(241, 57);
			cbClose.TabIndex = 2;
			cbClose.Text = "Close";
			cbClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbClose.UseVisualStyleBackColor = false;
			cbClose.Click += new System.EventHandler(cbClose_Click);
			// 
			// fgCustomers
			// 
			fgCustomers.AllowDrop = true;
			fgCustomers.AllowUserToAddRows = false;
			fgCustomers.AllowUserToDeleteRows = false;
			fgCustomers.AllowUserToResizeColumns = false;
			fgCustomers.AllowUserToResizeRows = false;
			fgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			fgCustomers.ColumnsCount = 5;
			fgCustomers.FixedColumns = 0;
			fgCustomers.FixedRows = 1;
			fgCustomers.FocusRect = UpgradeHelpers.FocusRectSettings.FocusNone;
			fgCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			fgCustomers.Location = new System.Drawing.Point(648, 24);
			fgCustomers.Name = "fgCustomers";
			fgCustomers.ReadOnly = true;
			fgCustomers.RowsCount = 2;
			fgCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			fgCustomers.ShowCellToolTips = false;
			fgCustomers.Size = new System.Drawing.Size(849, 577);
			fgCustomers.StandardTab = true;
			fgCustomers.TabIndex = 1;
			fgCustomers.DoubleClick += new System.EventHandler(fgCustomers_DoubleClick);
			// 
			// frmSearchCust
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(16, 31);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.White;
			ClientSize = new System.Drawing.Size(1264, 737);
			Controls.Add(ucLettersPad);
			Controls.Add(cbClose);
			Controls.Add(fgCustomers);
			Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Location = new System.Drawing.Point(11, 34);
			MaximizeBox = true;
			MinimizeBox = true;
			Name = "frmSearchCust";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Customer Search";
			commandButtonHelper1.SetStyle(cbClose, 1);
			Activated += new System.EventHandler(frmSearchCust_Activated);
			Closed += new System.EventHandler(Form_Closed);
			Load += new System.EventHandler(Form_Load);
			((System.ComponentModel.ISupportInitialize) fgCustomers).EndInit();
			ResumeLayout(false);
		}
		#endregion
	}
}