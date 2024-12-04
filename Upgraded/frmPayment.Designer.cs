
namespace TailwindPOS
{
	partial class frmPayment
	{

		#region "Upgrade Support "
		private static frmPayment m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmPayment DefInstance
		{
			get
			{
				if (m_vb6FormDefInstance is null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new frmPayment();
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
		private string[] visualControls = new string[]{"components", "ToolTipMain", "cbCash", "cbCreditCard", "cbCheck", "cbGiftCard", "ucNumbers", "gbPayments", "cbFinishPayment", "fgPayments", "cb_Cancel", "lblPaymentReady", "lblChange", "lblChangeTitle", "lblPaidSoFarTitle", "lblRemaining", "lblRemaingTitle", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button cbCash;
		public System.Windows.Forms.Button cbCreditCard;
		public System.Windows.Forms.Button cbCheck;
		public System.Windows.Forms.Button cbGiftCard;
		public ucNumbersPad ucNumbers;
		public System.Windows.Forms.GroupBox gbPayments;
		public System.Windows.Forms.Button cbFinishPayment;
		public UpgradeHelpers.DataGridViewFlex fgPayments;
		public System.Windows.Forms.Button cb_Cancel;
		public System.Windows.Forms.Label lblPaymentReady;
		public System.Windows.Forms.Label lblChange;
		public System.Windows.Forms.Label lblChangeTitle;
		public System.Windows.Forms.Label lblPaidSoFarTitle;
		public System.Windows.Forms.Label lblRemaining;
		public System.Windows.Forms.Label lblRemaingTitle;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			gbPayments = new System.Windows.Forms.GroupBox();
			cbCash = new System.Windows.Forms.Button();
			cbCreditCard = new System.Windows.Forms.Button();
			cbCheck = new System.Windows.Forms.Button();
			cbGiftCard = new System.Windows.Forms.Button();
			ucNumbers = new ucNumbersPad();
			cbFinishPayment = new System.Windows.Forms.Button();
			fgPayments = new UpgradeHelpers.DataGridViewFlex(components);
			cb_Cancel = new System.Windows.Forms.Button();
			lblPaymentReady = new System.Windows.Forms.Label();
			lblChange = new System.Windows.Forms.Label();
			lblChangeTitle = new System.Windows.Forms.Label();
			lblPaidSoFarTitle = new System.Windows.Forms.Label();
			lblRemaining = new System.Windows.Forms.Label();
			lblRemaingTitle = new System.Windows.Forms.Label();
			gbPayments.SuspendLayout();
			SuspendLayout();
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			((System.ComponentModel.ISupportInitialize) fgPayments).BeginInit();
			// 
			// gbPayments
			// 
			gbPayments.AllowDrop = true;
			gbPayments.BackColor = System.Drawing.Color.White;
			gbPayments.Controls.Add(cbCash);
			gbPayments.Controls.Add(cbCreditCard);
			gbPayments.Controls.Add(cbCheck);
			gbPayments.Controls.Add(cbGiftCard);
			gbPayments.Controls.Add(ucNumbers);
			gbPayments.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
			gbPayments.Enabled = true;
			gbPayments.Font = new System.Drawing.Font("Gin", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			gbPayments.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			gbPayments.Location = new System.Drawing.Point(16, 24);
			gbPayments.Name = "gbPayments";
			gbPayments.RightToLeft = System.Windows.Forms.RightToLeft.No;
			gbPayments.Size = new System.Drawing.Size(729, 529);
			gbPayments.TabIndex = 1;
			gbPayments.Text = "Payments";
			gbPayments.Visible = true;
			// 
			// cbCash
			// 
			cbCash.AllowDrop = true;
			cbCash.BackColor = System.Drawing.Color.White;
			cbCash.Font = new System.Drawing.Font("Brandon Grotesque Light", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbCash.ForeColor = System.Drawing.SystemColors.ControlText;
			cbCash.Location = new System.Drawing.Point(368, 56);
			cbCash.Name = "cbCash";
			cbCash.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cbCash.Size = new System.Drawing.Size(313, 81);
			cbCash.TabIndex = 3;
			cbCash.Text = "Cash";
			cbCash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbCash.UseVisualStyleBackColor = false;
			cbCash.Click += new System.EventHandler(cbCash_Click);
			// 
			// cbCreditCard
			// 
			cbCreditCard.AllowDrop = true;
			cbCreditCard.BackColor = System.Drawing.Color.White;
			cbCreditCard.Font = new System.Drawing.Font("Brandon Grotesque Light", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbCreditCard.ForeColor = System.Drawing.SystemColors.ControlText;
			cbCreditCard.Location = new System.Drawing.Point(368, 144);
			cbCreditCard.Name = "cbCreditCard";
			cbCreditCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cbCreditCard.Size = new System.Drawing.Size(313, 81);
			cbCreditCard.TabIndex = 4;
			cbCreditCard.Text = "Credit Card";
			cbCreditCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbCreditCard.UseVisualStyleBackColor = false;
			cbCreditCard.Click += new System.EventHandler(cbCreditCard_Click);
			// 
			// cbCheck
			// 
			cbCheck.AllowDrop = true;
			cbCheck.BackColor = System.Drawing.Color.White;
			cbCheck.Font = new System.Drawing.Font("Brandon Grotesque Light", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbCheck.ForeColor = System.Drawing.SystemColors.ControlText;
			cbCheck.Location = new System.Drawing.Point(368, 232);
			cbCheck.Name = "cbCheck";
			cbCheck.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cbCheck.Size = new System.Drawing.Size(313, 81);
			cbCheck.TabIndex = 5;
			cbCheck.Text = "Check";
			cbCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbCheck.UseVisualStyleBackColor = false;
			cbCheck.Click += new System.EventHandler(cbCheck_Click);
			// 
			// cbGiftCard
			// 
			cbGiftCard.AllowDrop = true;
			cbGiftCard.BackColor = System.Drawing.Color.White;
			cbGiftCard.Font = new System.Drawing.Font("Brandon Grotesque Light", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbGiftCard.ForeColor = System.Drawing.SystemColors.ControlText;
			cbGiftCard.Location = new System.Drawing.Point(368, 320);
			cbGiftCard.Name = "cbGiftCard";
			cbGiftCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cbGiftCard.Size = new System.Drawing.Size(313, 81);
			cbGiftCard.TabIndex = 6;
			cbGiftCard.Text = "Gift Card";
			cbGiftCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbGiftCard.UseVisualStyleBackColor = false;
			cbGiftCard.Click += new System.EventHandler(cbGiftCard_Click);
			// 
			// ucNumbers
			// 
			ucNumbers.AllowDrop = true;
			ucNumbers.Location = new System.Drawing.Point(8, 48);
			ucNumbers.Name = "ucNumbers";
			ucNumbers.Size = new System.Drawing.Size(361, 457);
			ucNumbers.TabIndex = 2;
			// 
			// cbFinishPayment
			// 
			cbFinishPayment.AllowDrop = true;
			cbFinishPayment.BackColor = System.Drawing.Color.FromArgb(97, 44, 67);
			cbFinishPayment.Font = new System.Drawing.Font("Brandon Grotesque Light", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbFinishPayment.ForeColor = System.Drawing.SystemColors.ControlText;
			cbFinishPayment.Location = new System.Drawing.Point(624, 568);
			cbFinishPayment.Name = "cbFinishPayment";
			cbFinishPayment.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cbFinishPayment.Size = new System.Drawing.Size(289, 81);
			cbFinishPayment.TabIndex = 13;
			cbFinishPayment.Text = "Continue";
			cbFinishPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbFinishPayment.UseVisualStyleBackColor = false;
			cbFinishPayment.Click += new System.EventHandler(cbFinishPayment_Click);
			// 
			// fgPayments
			// 
			fgPayments.AllowDrop = true;
			fgPayments.AllowUserToAddRows = false;
			fgPayments.AllowUserToDeleteRows = false;
			fgPayments.AllowUserToResizeColumns = false;
			fgPayments.AllowUserToResizeRows = false;
			fgPayments.BackgroundColor = System.Drawing.Color.White;
			fgPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			fgPayments.ColumnsCount = 3;
			fgPayments.FixedColumns = 1;
			fgPayments.FixedRows = 1;
			fgPayments.Font = new System.Drawing.Font("Brandon Grotesque Light", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			fgPayments.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			fgPayments.Location = new System.Drawing.Point(816, 256);
			fgPayments.Name = "fgPayments";
			fgPayments.ReadOnly = true;
			fgPayments.RowsCount = 1;
			fgPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			fgPayments.ShowCellToolTips = false;
			fgPayments.Size = new System.Drawing.Size(385, 281);
			fgPayments.StandardTab = true;
			fgPayments.TabIndex = 12;
			// 
			// cb_Cancel
			// 
			cb_Cancel.AllowDrop = true;
			cb_Cancel.BackColor = System.Drawing.Color.White;
			cb_Cancel.Font = new System.Drawing.Font("Brandon Grotesque Light", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cb_Cancel.ForeColor = System.Drawing.SystemColors.ControlText;
			cb_Cancel.Location = new System.Drawing.Point(928, 568);
			cb_Cancel.Name = "cb_Cancel";
			cb_Cancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cb_Cancel.Size = new System.Drawing.Size(265, 81);
			cb_Cancel.TabIndex = 14;
			cb_Cancel.Text = "Cancel";
			cb_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cb_Cancel.UseVisualStyleBackColor = false;
			cb_Cancel.Click += new System.EventHandler(cb_Cancel_Click);
			// 
			// lblPaymentReady
			// 
			lblPaymentReady.AllowDrop = true;
			lblPaymentReady.BackColor = System.Drawing.SystemColors.Control;
			lblPaymentReady.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblPaymentReady.Font = new System.Drawing.Font("Gin", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblPaymentReady.ForeColor = System.Drawing.SystemColors.ControlText;
			lblPaymentReady.Location = new System.Drawing.Point(48, 184);
			lblPaymentReady.MinimumSize = new System.Drawing.Size(401, 193);
			lblPaymentReady.Name = "lblPaymentReady";
			lblPaymentReady.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblPaymentReady.Size = new System.Drawing.Size(401, 193);
			lblPaymentReady.TabIndex = 10;
			lblPaymentReady.Text = "Payment Ready. Press Continue to Print the Receipt";
			lblPaymentReady.Visible = false;
			// 
			// lblChange
			// 
			lblChange.AllowDrop = true;
			lblChange.BackColor = System.Drawing.Color.White;
			lblChange.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblChange.Font = new System.Drawing.Font("Brandon Grotesque Light", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblChange.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblChange.Location = new System.Drawing.Point(832, 152);
			lblChange.MinimumSize = new System.Drawing.Size(361, 41);
			lblChange.Name = "lblChange";
			lblChange.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblChange.Size = new System.Drawing.Size(361, 41);
			lblChange.TabIndex = 9;
			lblChange.Text = "$0.00";
			lblChange.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblChangeTitle
			// 
			lblChangeTitle.AllowDrop = true;
			lblChangeTitle.BackColor = System.Drawing.Color.White;
			lblChangeTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblChangeTitle.Font = new System.Drawing.Font("Gin", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblChangeTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblChangeTitle.Location = new System.Drawing.Point(864, 104);
			lblChangeTitle.MinimumSize = new System.Drawing.Size(329, 49);
			lblChangeTitle.Name = "lblChangeTitle";
			lblChangeTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblChangeTitle.Size = new System.Drawing.Size(329, 49);
			lblChangeTitle.TabIndex = 8;
			lblChangeTitle.Text = "Change Due";
			lblChangeTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblPaidSoFarTitle
			// 
			lblPaidSoFarTitle.AllowDrop = true;
			lblPaidSoFarTitle.BackColor = System.Drawing.Color.White;
			lblPaidSoFarTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblPaidSoFarTitle.Font = new System.Drawing.Font("Gin", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblPaidSoFarTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblPaidSoFarTitle.Location = new System.Drawing.Point(864, 200);
			lblPaidSoFarTitle.MinimumSize = new System.Drawing.Size(329, 49);
			lblPaidSoFarTitle.Name = "lblPaidSoFarTitle";
			lblPaidSoFarTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblPaidSoFarTitle.Size = new System.Drawing.Size(329, 49);
			lblPaidSoFarTitle.TabIndex = 11;
			lblPaidSoFarTitle.Text = "Paid So Far";
			lblPaidSoFarTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblRemaining
			// 
			lblRemaining.AllowDrop = true;
			lblRemaining.BackColor = System.Drawing.Color.White;
			lblRemaining.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblRemaining.Font = new System.Drawing.Font("Brandon Grotesque Light", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblRemaining.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblRemaining.Location = new System.Drawing.Point(832, 56);
			lblRemaining.MinimumSize = new System.Drawing.Size(361, 41);
			lblRemaining.Name = "lblRemaining";
			lblRemaining.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblRemaining.Size = new System.Drawing.Size(361, 41);
			lblRemaining.TabIndex = 7;
			lblRemaining.Text = "$0.00";
			lblRemaining.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblRemaingTitle
			// 
			lblRemaingTitle.AllowDrop = true;
			lblRemaingTitle.BackColor = System.Drawing.Color.White;
			lblRemaingTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblRemaingTitle.Font = new System.Drawing.Font("Gin", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblRemaingTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblRemaingTitle.Location = new System.Drawing.Point(864, 8);
			lblRemaingTitle.MinimumSize = new System.Drawing.Size(329, 49);
			lblRemaingTitle.Name = "lblRemaingTitle";
			lblRemaingTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblRemaingTitle.Size = new System.Drawing.Size(329, 49);
			lblRemaingTitle.TabIndex = 0;
			lblRemaingTitle.Text = "Amount Remaining";
			lblRemaingTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// frmPayment
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(16, 31);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.White;
			ClientSize = new System.Drawing.Size(1219, 659);
			Controls.Add(gbPayments);
			Controls.Add(cbFinishPayment);
			Controls.Add(fgPayments);
			Controls.Add(cb_Cancel);
			Controls.Add(lblPaymentReady);
			Controls.Add(lblChange);
			Controls.Add(lblChangeTitle);
			Controls.Add(lblPaidSoFarTitle);
			Controls.Add(lblRemaining);
			Controls.Add(lblRemaingTitle);
			Font = new System.Drawing.Font("Brandon Grotesque Light", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Location = new System.Drawing.Point(4, 27);
			MaximizeBox = true;
			MinimizeBox = true;
			Name = "frmPayment";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Pay";
			commandButtonHelper1.SetStyle(cbCash, 1);
			commandButtonHelper1.SetStyle(cbCreditCard, 1);
			commandButtonHelper1.SetStyle(cbCheck, 1);
			commandButtonHelper1.SetStyle(cbGiftCard, 1);
			commandButtonHelper1.SetStyle(cbFinishPayment, 1);
			commandButtonHelper1.SetStyle(cb_Cancel, 1);
			Activated += new System.EventHandler(frmPayment_Activated);
			Closed += new System.EventHandler(Form_Closed);
			Load += new System.EventHandler(Form_Load);
			((System.ComponentModel.ISupportInitialize) fgPayments).EndInit();
			gbPayments.ResumeLayout(false);
			ResumeLayout(false);
		}
		#endregion
	}
}