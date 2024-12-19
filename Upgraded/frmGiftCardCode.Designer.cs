
namespace TailwindPOS
{
	partial class frmGiftCardCode
	{

		#region "Upgrade Support "
		private static frmGiftCardCode m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmGiftCardCode DefInstance
		{
			get
			{
				if (m_vb6FormDefInstance is null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new frmGiftCardCode();
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
		private string[] visualControls = new string[]{"components", "ToolTipMain", "cbCancel", "cbOK", "txtCode", "lblMessage", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button cbCancel;
		public System.Windows.Forms.Button cbOK;
		public System.Windows.Forms.TextBox txtCode;
		public System.Windows.Forms.Label lblMessage;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiftCardCode));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			cbCancel = new System.Windows.Forms.Button();
			cbOK = new System.Windows.Forms.Button();
			txtCode = new System.Windows.Forms.TextBox();
			lblMessage = new System.Windows.Forms.Label();
			SuspendLayout();
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			// 
			// cbCancel
			// 
			cbCancel.AllowDrop = true;
			cbCancel.BackColor = System.Drawing.Color.White;
			cbCancel.Font = new System.Drawing.Font("Brandon Grotesque Light", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbCancel.ForeColor = System.Drawing.SystemColors.ControlText;
			cbCancel.Location = new System.Drawing.Point(360, 128);
			cbCancel.Name = "cbCancel";
			cbCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cbCancel.Size = new System.Drawing.Size(265, 65);
			cbCancel.TabIndex = 3;
			cbCancel.Text = "Cancel";
			cbCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbCancel.UseVisualStyleBackColor = false;
			cbCancel.Click += new System.EventHandler(cbCancel_Click);
			// 
			// cbOK
			// 
			cbOK.AllowDrop = true;
			cbOK.BackColor = System.Drawing.Color.FromArgb(97, 44, 67);
			cbOK.Font = new System.Drawing.Font("Brandon Grotesque Light", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbOK.ForeColor = System.Drawing.SystemColors.ControlText;
			cbOK.Location = new System.Drawing.Point(72, 128);
			cbOK.Name = "cbOK";
			cbOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cbOK.Size = new System.Drawing.Size(265, 65);
			cbOK.TabIndex = 2;
			cbOK.Text = "OK";
			cbOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbOK.UseVisualStyleBackColor = false;
			cbOK.Click += new System.EventHandler(cbOK_Click);
			// 
			// txtCode
			// 
			txtCode.AcceptsReturn = true;
			txtCode.AllowDrop = true;
			txtCode.BackColor = System.Drawing.SystemColors.Window;
			txtCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtCode.Font = new System.Drawing.Font("Brandon Grotesque Light", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtCode.ForeColor = System.Drawing.SystemColors.WindowText;
			txtCode.Location = new System.Drawing.Point(24, 72);
			txtCode.MaxLength = 0;
			txtCode.Name = "txtCode";
			txtCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtCode.Size = new System.Drawing.Size(633, 49);
			txtCode.TabIndex = 1;
			// 
			// lblMessage
			// 
			lblMessage.AllowDrop = true;
			lblMessage.BackColor = System.Drawing.Color.White;
			lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblMessage.Font = new System.Drawing.Font("Gin", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblMessage.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblMessage.Location = new System.Drawing.Point(40, 24);
			lblMessage.MinimumSize = new System.Drawing.Size(313, 41);
			lblMessage.Name = "lblMessage";
			lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblMessage.Size = new System.Drawing.Size(313, 41);
			lblMessage.TabIndex = 0;
			lblMessage.Text = "Enter GIFT CARD CODE";
			// 
			// frmGiftCardCode
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(17, 31);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.White;
			ClientSize = new System.Drawing.Size(688, 213);
			ControlBox = false;
			Controls.Add(cbCancel);
			Controls.Add(cbOK);
			Controls.Add(txtCode);
			Controls.Add(lblMessage);
			Font = new System.Drawing.Font("Brandon Grotesque Light", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			Location = new System.Drawing.Point(184, 250);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmGiftCardCode";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			ShowInTaskbar = false;
			Text = "Enter Gift Card Code";
			commandButtonHelper1.SetStyle(cbCancel, 1);
			commandButtonHelper1.SetStyle(cbOK, 1);
			Activated += new System.EventHandler(frmGiftCardCode_Activated);
			Closed += new System.EventHandler(Form_Closed);
			ResumeLayout(false);
		}
		#endregion
	}
}