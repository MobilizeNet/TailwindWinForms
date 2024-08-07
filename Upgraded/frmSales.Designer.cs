
namespace TailwindPOS
{
	partial class frmSales
	{

		#region "Upgrade Support "
		private static frmSales m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmSales DefInstance
		{
			get
			{
				if (m_vb6FormDefInstance is null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new frmSales();
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
		private string[] visualControls = new string[]{"components", "ToolTipMain", "cbRePrint", "ucNumericKeyPad", "cbQuantity", "fgItems", "lblCustomerInfo", "gbCustomerInfo", "cbBreak", "cbLogOff", "cbVoidTransaction", "cbVoidItem", "cbAddCustomer", "cbCustomerSearch", "cbPayment", "lblTotal", "lblTax", "lblSubTotal", "lblTotalTitle", "lblTaxTitle", "lblSubTotalTitle", "frSubTotals", "picLogo", "lblPOS", "lblPOSTitle", "lblCashier", "lblCashierTitle", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button cbRePrint;
		public ucNumbersPad ucNumericKeyPad;
		public System.Windows.Forms.Button cbQuantity;
		public UpgradeHelpers.DataGridViewFlex fgItems;
		public System.Windows.Forms.Label lblCustomerInfo;
		public System.Windows.Forms.GroupBox gbCustomerInfo;
		public System.Windows.Forms.Button cbBreak;
		public System.Windows.Forms.Button cbLogOff;
		public System.Windows.Forms.Button cbVoidTransaction;
		public System.Windows.Forms.Button cbVoidItem;
		public System.Windows.Forms.Button cbAddCustomer;
		public System.Windows.Forms.Button cbCustomerSearch;
		public System.Windows.Forms.Button cbPayment;
		public System.Windows.Forms.Label lblTotal;
		public System.Windows.Forms.Label lblTax;
		public System.Windows.Forms.Label lblSubTotal;
		public System.Windows.Forms.Label lblTotalTitle;
		public System.Windows.Forms.Label lblTaxTitle;
		public System.Windows.Forms.Label lblSubTotalTitle;
		public System.Windows.Forms.GroupBox frSubTotals;
		public System.Windows.Forms.PictureBox picLogo;
		public System.Windows.Forms.Label lblPOS;
		public System.Windows.Forms.Label lblPOSTitle;
		public System.Windows.Forms.Label lblCashier;
		public System.Windows.Forms.Label lblCashierTitle;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			cbRePrint = new System.Windows.Forms.Button();
			ucNumericKeyPad = new ucNumbersPad();
			cbQuantity = new System.Windows.Forms.Button();
			fgItems = new UpgradeHelpers.DataGridViewFlex(components);
			gbCustomerInfo = new System.Windows.Forms.GroupBox();
			lblCustomerInfo = new System.Windows.Forms.Label();
			cbBreak = new System.Windows.Forms.Button();
			cbLogOff = new System.Windows.Forms.Button();
			cbVoidTransaction = new System.Windows.Forms.Button();
			cbVoidItem = new System.Windows.Forms.Button();
			cbAddCustomer = new System.Windows.Forms.Button();
			cbCustomerSearch = new System.Windows.Forms.Button();
			cbPayment = new System.Windows.Forms.Button();
			frSubTotals = new System.Windows.Forms.GroupBox();
			lblTotal = new System.Windows.Forms.Label();
			lblTax = new System.Windows.Forms.Label();
			lblSubTotal = new System.Windows.Forms.Label();
			lblTotalTitle = new System.Windows.Forms.Label();
			lblTaxTitle = new System.Windows.Forms.Label();
			lblSubTotalTitle = new System.Windows.Forms.Label();
			picLogo = new System.Windows.Forms.PictureBox();
			lblPOS = new System.Windows.Forms.Label();
			lblPOSTitle = new System.Windows.Forms.Label();
			lblCashier = new System.Windows.Forms.Label();
			lblCashierTitle = new System.Windows.Forms.Label();
			gbCustomerInfo.SuspendLayout();
			frSubTotals.SuspendLayout();
			SuspendLayout();
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			((System.ComponentModel.ISupportInitialize) fgItems).BeginInit();
			// 
			// cbRePrint
			// 
			cbRePrint.AllowDrop = true;
			cbRePrint.BackColor = System.Drawing.Color.White;
			cbRePrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbRePrint.ForeColor = System.Drawing.SystemColors.ControlText;
			cbRePrint.Location = new System.Drawing.Point(800, 384);
			cbRePrint.Name = "cbRePrint";
			cbRePrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cbRePrint.Size = new System.Drawing.Size(185, 114);
			cbRePrint.TabIndex = 7;
			cbRePrint.Text = "PRINT LAST TICKET";
			cbRePrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbRePrint.UseVisualStyleBackColor = false;
			cbRePrint.Click += new System.EventHandler(cbRePrint_Click);
			// 
			// ucNumericKeyPad
			// 
			ucNumericKeyPad.AllowDrop = true;
			ucNumericKeyPad.Location = new System.Drawing.Point(8, 464);
			ucNumericKeyPad.Name = "ucNumericKeyPad";
			ucNumericKeyPad.Size = new System.Drawing.Size(337, 417);
			ucNumericKeyPad.TabIndex = 9;
			ucNumericKeyPad.OnEnterEvent += new ucNumbersPad.OnEnterEventHandler(ucNumericKeyPad_OnEnterEvent);
			// 
			// cbQuantity
			// 
			cbQuantity.AllowDrop = true;
			cbQuantity.BackColor = System.Drawing.Color.White;
			cbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
			cbQuantity.Location = new System.Drawing.Point(800, 264);
			cbQuantity.Name = "cbQuantity";
			cbQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cbQuantity.Size = new System.Drawing.Size(185, 114);
			cbQuantity.TabIndex = 5;
			cbQuantity.Text = "CHANGE QUANTITY";
			cbQuantity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbQuantity.UseVisualStyleBackColor = false;
			cbQuantity.Click += new System.EventHandler(cbQuantity_Click);
			// 
			// fgItems
			// 
			fgItems.AllowDrop = true;
			fgItems.AllowUserToAddRows = false;
			fgItems.AllowUserToDeleteRows = false;
			fgItems.AllowUserToResizeColumns = false;
			fgItems.AllowUserToResizeRows = false;
			fgItems.BackgroundColor = System.Drawing.Color.White;
			fgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			fgItems.ColumnsCount = 6;
			fgItems.FixedColumns = 0;
			fgItems.FixedRows = 1;
			fgItems.FocusRect = UpgradeHelpers.FocusRectSettings.FocusNone;
			fgItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			fgItems.Location = new System.Drawing.Point(8, 8);
			fgItems.Name = "fgItems";
			fgItems.ReadOnly = true;
			fgItems.RowsCount = 1;
			fgItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			fgItems.ShowCellToolTips = false;
			fgItems.Size = new System.Drawing.Size(777, 449);
			fgItems.StandardTab = true;
			fgItems.TabIndex = 0;
			// 
			// gbCustomerInfo
			// 
			gbCustomerInfo.AllowDrop = true;
			gbCustomerInfo.BackColor = System.Drawing.Color.White;
			gbCustomerInfo.Controls.Add(lblCustomerInfo);
			gbCustomerInfo.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
			gbCustomerInfo.Enabled = true;
			gbCustomerInfo.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			gbCustomerInfo.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			gbCustomerInfo.Location = new System.Drawing.Point(800, 136);
			gbCustomerInfo.Name = "gbCustomerInfo";
			gbCustomerInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			gbCustomerInfo.Size = new System.Drawing.Size(393, 114);
			gbCustomerInfo.TabIndex = 3;
			gbCustomerInfo.Text = "Customer Info";
			gbCustomerInfo.Visible = true;
			// 
			// lblCustomerInfo
			// 
			lblCustomerInfo.AllowDrop = true;
			lblCustomerInfo.BackColor = System.Drawing.Color.White;
			lblCustomerInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblCustomerInfo.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblCustomerInfo.Location = new System.Drawing.Point(24, 40);
			lblCustomerInfo.MinimumSize = new System.Drawing.Size(337, 49);
			lblCustomerInfo.Name = "lblCustomerInfo";
			lblCustomerInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblCustomerInfo.Size = new System.Drawing.Size(337, 49);
			lblCustomerInfo.TabIndex = 4;
			// 
			// cbBreak
			// 
			cbBreak.AllowDrop = true;
			cbBreak.BackColor = System.Drawing.Color.White;
			cbBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbBreak.ForeColor = System.Drawing.SystemColors.ControlText;
			cbBreak.Location = new System.Drawing.Point(800, 504);
			cbBreak.Name = "cbBreak";
			cbBreak.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cbBreak.Size = new System.Drawing.Size(185, 114);
			cbBreak.TabIndex = 17;
			cbBreak.Text = "PAUSE";
			cbBreak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbBreak.UseVisualStyleBackColor = false;
			cbBreak.Click += new System.EventHandler(cbBreak_Click);
			// 
			// cbLogOff
			// 
			cbLogOff.AllowDrop = true;
			cbLogOff.BackColor = System.Drawing.Color.White;
			cbLogOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbLogOff.ForeColor = System.Drawing.SystemColors.ControlText;
			cbLogOff.Location = new System.Drawing.Point(1008, 504);
			cbLogOff.Name = "cbLogOff";
			cbLogOff.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cbLogOff.Size = new System.Drawing.Size(185, 114);
			cbLogOff.TabIndex = 18;
			cbLogOff.Text = "LOG OFF";
			cbLogOff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbLogOff.UseVisualStyleBackColor = false;
			cbLogOff.Click += new System.EventHandler(cbLogOff_Click);
			// 
			// cbVoidTransaction
			// 
			cbVoidTransaction.AllowDrop = true;
			cbVoidTransaction.BackColor = System.Drawing.Color.White;
			cbVoidTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbVoidTransaction.ForeColor = System.Drawing.SystemColors.ControlText;
			cbVoidTransaction.Location = new System.Drawing.Point(1008, 384);
			cbVoidTransaction.Name = "cbVoidTransaction";
			cbVoidTransaction.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cbVoidTransaction.Size = new System.Drawing.Size(185, 114);
			cbVoidTransaction.TabIndex = 8;
			cbVoidTransaction.Text = "VOID TRANSACTION";
			cbVoidTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbVoidTransaction.UseVisualStyleBackColor = false;
			cbVoidTransaction.Click += new System.EventHandler(cbVoidTransaction_Click);
			// 
			// cbVoidItem
			// 
			cbVoidItem.AllowDrop = true;
			cbVoidItem.BackColor = System.Drawing.Color.White;
			cbVoidItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbVoidItem.ForeColor = System.Drawing.SystemColors.ControlText;
			cbVoidItem.Location = new System.Drawing.Point(1008, 264);
			cbVoidItem.Name = "cbVoidItem";
			cbVoidItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cbVoidItem.Size = new System.Drawing.Size(185, 114);
			cbVoidItem.TabIndex = 6;
			cbVoidItem.Text = "VOID ITEM";
			cbVoidItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbVoidItem.UseVisualStyleBackColor = false;
			cbVoidItem.Click += new System.EventHandler(cbVoidItem_Click);
			// 
			// cbAddCustomer
			// 
			cbAddCustomer.AllowDrop = true;
			cbAddCustomer.BackColor = System.Drawing.Color.White;
			cbAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbAddCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
			cbAddCustomer.Location = new System.Drawing.Point(800, 8);
			cbAddCustomer.Name = "cbAddCustomer";
			cbAddCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cbAddCustomer.Size = new System.Drawing.Size(185, 114);
			cbAddCustomer.TabIndex = 1;
			cbAddCustomer.Text = "ADD CUSTOMER";
			cbAddCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbAddCustomer.UseVisualStyleBackColor = false;
			cbAddCustomer.Click += new System.EventHandler(cbAddCustomer_Click);
			// 
			// cbCustomerSearch
			// 
			cbCustomerSearch.AllowDrop = true;
			cbCustomerSearch.BackColor = System.Drawing.Color.White;
			cbCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbCustomerSearch.ForeColor = System.Drawing.SystemColors.ControlText;
			cbCustomerSearch.Location = new System.Drawing.Point(1008, 8);
			cbCustomerSearch.Name = "cbCustomerSearch";
			cbCustomerSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cbCustomerSearch.Size = new System.Drawing.Size(185, 114);
			cbCustomerSearch.TabIndex = 2;
			cbCustomerSearch.Text = "CUSTOMER SEARCH";
			cbCustomerSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbCustomerSearch.UseVisualStyleBackColor = false;
			cbCustomerSearch.Click += new System.EventHandler(cbCustomerSearch_Click);
			// 
			// cbPayment
			// 
			cbPayment.AllowDrop = true;
			cbPayment.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
			cbPayment.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbPayment.ForeColor = System.Drawing.SystemColors.ControlText;
			cbPayment.Location = new System.Drawing.Point(360, 688);
			cbPayment.Name = "cbPayment";
			cbPayment.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cbPayment.Size = new System.Drawing.Size(353, 73);
			cbPayment.TabIndex = 21;
			cbPayment.Text = "PAY";
			cbPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbPayment.UseVisualStyleBackColor = false;
			cbPayment.Click += new System.EventHandler(cbPayment_Click);
			// 
			// frSubTotals
			// 
			frSubTotals.AllowDrop = true;
			frSubTotals.BackColor = System.Drawing.Color.White;
			frSubTotals.Controls.Add(lblTotal);
			frSubTotals.Controls.Add(lblTax);
			frSubTotals.Controls.Add(lblSubTotal);
			frSubTotals.Controls.Add(lblTotalTitle);
			frSubTotals.Controls.Add(lblTaxTitle);
			frSubTotals.Controls.Add(lblSubTotalTitle);
			frSubTotals.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
			frSubTotals.Enabled = true;
			frSubTotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			frSubTotals.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			frSubTotals.Location = new System.Drawing.Point(360, 464);
			frSubTotals.Name = "frSubTotals";
			frSubTotals.RightToLeft = System.Windows.Forms.RightToLeft.No;
			frSubTotals.Size = new System.Drawing.Size(353, 217);
			frSubTotals.TabIndex = 10;
			frSubTotals.Visible = true;
			// 
			// lblTotal
			// 
			lblTotal.AllowDrop = true;
			lblTotal.BackColor = System.Drawing.Color.White;
			lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblTotal.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblTotal.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblTotal.Location = new System.Drawing.Point(168, 128);
			lblTotal.MinimumSize = new System.Drawing.Size(129, 33);
			lblTotal.Name = "lblTotal";
			lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblTotal.Size = new System.Drawing.Size(129, 33);
			lblTotal.TabIndex = 16;
			lblTotal.Text = "0.00";
			lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblTax
			// 
			lblTax.AllowDrop = true;
			lblTax.BackColor = System.Drawing.Color.White;
			lblTax.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblTax.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblTax.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblTax.Location = new System.Drawing.Point(168, 80);
			lblTax.MinimumSize = new System.Drawing.Size(129, 33);
			lblTax.Name = "lblTax";
			lblTax.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblTax.Size = new System.Drawing.Size(129, 33);
			lblTax.TabIndex = 14;
			lblTax.Text = "0.00";
			lblTax.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblSubTotal
			// 
			lblSubTotal.AllowDrop = true;
			lblSubTotal.BackColor = System.Drawing.Color.White;
			lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblSubTotal.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblSubTotal.Location = new System.Drawing.Point(168, 32);
			lblSubTotal.MinimumSize = new System.Drawing.Size(129, 33);
			lblSubTotal.Name = "lblSubTotal";
			lblSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblSubTotal.Size = new System.Drawing.Size(129, 33);
			lblSubTotal.TabIndex = 12;
			lblSubTotal.Text = "0.00";
			lblSubTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblTotalTitle
			// 
			lblTotalTitle.AllowDrop = true;
			lblTotalTitle.BackColor = System.Drawing.Color.White;
			lblTotalTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblTotalTitle.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblTotalTitle.Location = new System.Drawing.Point(16, 128);
			lblTotalTitle.MinimumSize = new System.Drawing.Size(97, 41);
			lblTotalTitle.Name = "lblTotalTitle";
			lblTotalTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblTotalTitle.Size = new System.Drawing.Size(97, 41);
			lblTotalTitle.TabIndex = 15;
			lblTotalTitle.Text = "Total:";
			// 
			// lblTaxTitle
			// 
			lblTaxTitle.AllowDrop = true;
			lblTaxTitle.BackColor = System.Drawing.Color.White;
			lblTaxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblTaxTitle.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblTaxTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblTaxTitle.Location = new System.Drawing.Point(16, 80);
			lblTaxTitle.MinimumSize = new System.Drawing.Size(81, 41);
			lblTaxTitle.Name = "lblTaxTitle";
			lblTaxTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblTaxTitle.Size = new System.Drawing.Size(81, 41);
			lblTaxTitle.TabIndex = 13;
			lblTaxTitle.Text = "Tax:";
			// 
			// lblSubTotalTitle
			// 
			lblSubTotalTitle.AllowDrop = true;
			lblSubTotalTitle.BackColor = System.Drawing.Color.White;
			lblSubTotalTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblSubTotalTitle.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblSubTotalTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblSubTotalTitle.Location = new System.Drawing.Point(16, 32);
			lblSubTotalTitle.MinimumSize = new System.Drawing.Size(129, 33);
			lblSubTotalTitle.Name = "lblSubTotalTitle";
			lblSubTotalTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblSubTotalTitle.Size = new System.Drawing.Size(129, 33);
			lblSubTotalTitle.TabIndex = 11;
			lblSubTotalTitle.Text = "SubTotal:";
			// 
			// picLogo
			// 
			picLogo.AllowDrop = true;
			picLogo.BackColor = System.Drawing.SystemColors.Window;
			picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			picLogo.CausesValidation = true;
			picLogo.Dock = System.Windows.Forms.DockStyle.None;
			picLogo.Enabled = true;
			picLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			picLogo.Image = (System.Drawing.Image) resources.GetObject("picLogo.Image");
			picLogo.Location = new System.Drawing.Point(960, 696);
			picLogo.Name = "picLogo";
			picLogo.Size = new System.Drawing.Size(230, 206);
			picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			picLogo.TabIndex = 24;
			picLogo.TabStop = true;
			picLogo.Visible = true;
			// 
			// lblPOS
			// 
			lblPOS.AllowDrop = true;
			lblPOS.BackColor = System.Drawing.Color.White;
			lblPOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblPOS.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblPOS.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblPOS.Location = new System.Drawing.Point(752, 768);
			lblPOS.MinimumSize = new System.Drawing.Size(153, 49);
			lblPOS.Name = "lblPOS";
			lblPOS.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblPOS.Size = new System.Drawing.Size(153, 49);
			lblPOS.TabIndex = 23;
			lblPOS.Text = "POSName";
			// 
			// lblPOSTitle
			// 
			lblPOSTitle.AllowDrop = true;
			lblPOSTitle.BackColor = System.Drawing.Color.White;
			lblPOSTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblPOSTitle.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblPOSTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblPOSTitle.Location = new System.Drawing.Point(752, 704);
			lblPOSTitle.MinimumSize = new System.Drawing.Size(105, 57);
			lblPOSTitle.Name = "lblPOSTitle";
			lblPOSTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblPOSTitle.Size = new System.Drawing.Size(105, 57);
			lblPOSTitle.TabIndex = 22;
			lblPOSTitle.Text = "POS:";
			// 
			// lblCashier
			// 
			lblCashier.AllowDrop = true;
			lblCashier.BackColor = System.Drawing.Color.White;
			lblCashier.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblCashier.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblCashier.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblCashier.Location = new System.Drawing.Point(960, 632);
			lblCashier.MinimumSize = new System.Drawing.Size(185, 57);
			lblCashier.Name = "lblCashier";
			lblCashier.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblCashier.Size = new System.Drawing.Size(185, 57);
			lblCashier.TabIndex = 20;
			lblCashier.Text = "CashierID";
			// 
			// lblCashierTitle
			// 
			lblCashierTitle.AllowDrop = true;
			lblCashierTitle.BackColor = System.Drawing.Color.White;
			lblCashierTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblCashierTitle.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblCashierTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblCashierTitle.Location = new System.Drawing.Point(752, 632);
			lblCashierTitle.MinimumSize = new System.Drawing.Size(145, 49);
			lblCashierTitle.Name = "lblCashierTitle";
			lblCashierTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblCashierTitle.Size = new System.Drawing.Size(145, 49);
			lblCashierTitle.TabIndex = 19;
			lblCashierTitle.Text = "Cashier:";
			// 
			// frmSales
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(16, 31);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.White;
			ClientSize = new System.Drawing.Size(1202, 909);
			ControlBox = false;
			Controls.Add(cbRePrint);
			Controls.Add(ucNumericKeyPad);
			Controls.Add(cbQuantity);
			Controls.Add(fgItems);
			Controls.Add(gbCustomerInfo);
			Controls.Add(cbBreak);
			Controls.Add(cbLogOff);
			Controls.Add(cbVoidTransaction);
			Controls.Add(cbVoidItem);
			Controls.Add(cbAddCustomer);
			Controls.Add(cbCustomerSearch);
			Controls.Add(cbPayment);
			Controls.Add(frSubTotals);
			Controls.Add(picLogo);
			Controls.Add(lblPOS);
			Controls.Add(lblPOSTitle);
			Controls.Add(lblCashier);
			Controls.Add(lblCashierTitle);
			Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			Location = new System.Drawing.Point(3, 26);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmSales";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			ShowInTaskbar = false;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Sales";
			commandButtonHelper1.SetStyle(cbRePrint, 1);
			commandButtonHelper1.SetStyle(cbQuantity, 1);
			commandButtonHelper1.SetStyle(cbBreak, 1);
			commandButtonHelper1.SetStyle(cbLogOff, 1);
			commandButtonHelper1.SetStyle(cbVoidTransaction, 1);
			commandButtonHelper1.SetStyle(cbVoidItem, 1);
			commandButtonHelper1.SetStyle(cbAddCustomer, 1);
			commandButtonHelper1.SetStyle(cbCustomerSearch, 1);
			commandButtonHelper1.SetStyle(cbPayment, 1);
			Activated += new System.EventHandler(frmSales_Activated);
			Closed += new System.EventHandler(Form_Closed);
			Load += new System.EventHandler(Form_Load);
			((System.ComponentModel.ISupportInitialize) fgItems).EndInit();
			gbCustomerInfo.ResumeLayout(false);
			frSubTotals.ResumeLayout(false);
			ResumeLayout(false);
		}
		#endregion
	}
}