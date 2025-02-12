namespace Jared_Daniels_CPT_206_Lab_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.stateDBDataSet = new Jared_Daniels_CPT_206_Lab_3.StateDBDataSet();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statesTableAdapter = new Jared_Daniels_CPT_206_Lab_3.StateDBDataSetTableAdapters.StatesTableAdapter();
            this.tableAdapterManager = new Jared_Daniels_CPT_206_Lab_3.StateDBDataSetTableAdapters.TableAdapterManager();
            this.statesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.statesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStateDetails = new System.Windows.Forms.Button();
            this.cmbBxState = new System.Windows.Forms.ComboBox();
            this.lblStateInfo = new System.Windows.Forms.Label();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.panelStateInfo = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.rdoBtnID = new System.Windows.Forms.RadioButton();
            this.rdoBtnFlag = new System.Windows.Forms.RadioButton();
            this.rdoBtnBird = new System.Windows.Forms.RadioButton();
            this.rdoBtnColor = new System.Windows.Forms.RadioButton();
            this.rdoBtnFlower = new System.Windows.Forms.RadioButton();
            this.rdoBtnCity = new System.Windows.Forms.RadioButton();
            this.rdoBtnState = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelSort = new System.Windows.Forms.Panel();
            this.btnSortDesc = new System.Windows.Forms.Button();
            this.rdoBtnSortCities = new System.Windows.Forms.RadioButton();
            this.rdoBtnSortJobs = new System.Windows.Forms.RadioButton();
            this.rdoBtnSortInc = new System.Windows.Forms.RadioButton();
            this.rdoBtnSortPop = new System.Windows.Forms.RadioButton();
            this.rdoBtnSortFlag = new System.Windows.Forms.RadioButton();
            this.rdoBtnSortID = new System.Windows.Forms.RadioButton();
            this.btnSortAsc = new System.Windows.Forms.Button();
            this.rdoBtnSortBird = new System.Windows.Forms.RadioButton();
            this.lblSort = new System.Windows.Forms.Label();
            this.rdoBtnSortColors = new System.Windows.Forms.RadioButton();
            this.rdoBtnSortState = new System.Windows.Forms.RadioButton();
            this.rdoBtnSortFlower = new System.Windows.Forms.RadioButton();
            this.rdoBtnSortCap = new System.Windows.Forms.RadioButton();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.txtBoxFilter = new System.Windows.Forms.TextBox();
            this.cmbBxFilterOperator = new System.Windows.Forms.ComboBox();
            this.lblOption = new System.Windows.Forms.Label();
            this.cmbBxFilterOption = new System.Windows.Forms.ComboBox();
            this.lblBy = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingNavigator)).BeginInit();
            this.statesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesDataGridView)).BeginInit();
            this.panelStateInfo.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelSort.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // stateDBDataSet
            // 
            this.stateDBDataSet.DataSetName = "StateDBDataSet";
            this.stateDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.stateDBDataSet;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StatesTableAdapter = this.statesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Jared_Daniels_CPT_206_Lab_3.StateDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // statesBindingNavigator
            // 
            this.statesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.statesBindingNavigator.BindingSource = this.statesBindingSource;
            this.statesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.statesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.statesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.statesBindingNavigatorSaveItem});
            this.statesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.statesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.statesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.statesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.statesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.statesBindingNavigator.Name = "statesBindingNavigator";
            this.statesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.statesBindingNavigator.Size = new System.Drawing.Size(934, 25);
            this.statesBindingNavigator.TabIndex = 0;
            this.statesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(45, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statesBindingNavigatorSaveItem
            // 
            this.statesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.statesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("statesBindingNavigatorSaveItem.Image")));
            this.statesBindingNavigatorSaveItem.Name = "statesBindingNavigatorSaveItem";
            this.statesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.statesBindingNavigatorSaveItem.Text = "Save Data";
            this.statesBindingNavigatorSaveItem.Click += new System.EventHandler(this.statesBindingNavigatorSaveItem_Click);
            // 
            // statesDataGridView
            // 
            this.statesDataGridView.AutoGenerateColumns = false;
            this.statesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.statesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.statesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.statesDataGridView.DataSource = this.statesBindingSource;
            this.statesDataGridView.Location = new System.Drawing.Point(454, 27);
            this.statesDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statesDataGridView.Name = "statesDataGridView";
            this.statesDataGridView.Size = new System.Drawing.Size(469, 646);
            this.statesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 45;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn2.HeaderText = "State";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 68;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Population";
            this.dataGridViewTextBoxColumn3.HeaderText = "Population";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 106;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Capital";
            this.dataGridViewTextBoxColumn4.HeaderText = "Capital";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 81;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Median Income";
            this.dataGridViewTextBoxColumn5.HeaderText = "Median Income";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Computer Jobs Percentage";
            this.dataGridViewTextBoxColumn6.HeaderText = "Computer Jobs Percentage";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "State Flower";
            this.dataGridViewTextBoxColumn7.HeaderText = "State Flower";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 108;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "State Bird";
            this.dataGridViewTextBoxColumn8.HeaderText = "State Bird";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 92;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Colors";
            this.dataGridViewTextBoxColumn9.HeaderText = "Colors";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 77;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Largest Cities";
            this.dataGridViewTextBoxColumn10.HeaderText = "Largest Cities";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 116;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Flag Description";
            this.dataGridViewTextBoxColumn11.HeaderText = "Flag Description";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 133;
            // 
            // btnStateDetails
            // 
            this.btnStateDetails.Location = new System.Drawing.Point(28, 76);
            this.btnStateDetails.Name = "btnStateDetails";
            this.btnStateDetails.Size = new System.Drawing.Size(161, 30);
            this.btnStateDetails.TabIndex = 2;
            this.btnStateDetails.Text = "Show State &Details";
            this.btnStateDetails.UseVisualStyleBackColor = true;
            this.btnStateDetails.Click += new System.EventHandler(this.btnStateDetails_Click);
            // 
            // cmbBxState
            // 
            this.cmbBxState.FormattingEnabled = true;
            this.cmbBxState.Location = new System.Drawing.Point(28, 46);
            this.cmbBxState.Name = "cmbBxState";
            this.cmbBxState.Size = new System.Drawing.Size(161, 24);
            this.cmbBxState.TabIndex = 3;
            // 
            // lblStateInfo
            // 
            this.lblStateInfo.AutoSize = true;
            this.lblStateInfo.Location = new System.Drawing.Point(16, 18);
            this.lblStateInfo.Name = "lblStateInfo";
            this.lblStateInfo.Size = new System.Drawing.Size(180, 16);
            this.lblStateInfo.TabIndex = 4;
            this.lblStateInfo.Text = "Display State Information";
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(29, 66);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(358, 22);
            this.txtBoxSearch.TabIndex = 5;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(181, 11);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(56, 16);
            this.lblSearchBy.TabIndex = 6;
            this.lblSearchBy.Text = "Search";
            // 
            // panelStateInfo
            // 
            this.panelStateInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStateInfo.Controls.Add(this.lblStateInfo);
            this.panelStateInfo.Controls.Add(this.btnStateDetails);
            this.panelStateInfo.Controls.Add(this.cmbBxState);
            this.panelStateInfo.Location = new System.Drawing.Point(110, 37);
            this.panelStateInfo.Name = "panelStateInfo";
            this.panelStateInfo.Size = new System.Drawing.Size(215, 129);
            this.panelStateInfo.TabIndex = 7;
            // 
            // panelSearch
            // 
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.rdoBtnID);
            this.panelSearch.Controls.Add(this.rdoBtnFlag);
            this.panelSearch.Controls.Add(this.rdoBtnBird);
            this.panelSearch.Controls.Add(this.rdoBtnColor);
            this.panelSearch.Controls.Add(this.rdoBtnFlower);
            this.panelSearch.Controls.Add(this.rdoBtnCity);
            this.panelSearch.Controls.Add(this.rdoBtnState);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.lblSearchBy);
            this.panelSearch.Controls.Add(this.txtBoxSearch);
            this.panelSearch.Location = new System.Drawing.Point(12, 181);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(425, 132);
            this.panelSearch.TabIndex = 8;
            // 
            // rdoBtnID
            // 
            this.rdoBtnID.AutoSize = true;
            this.rdoBtnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnID.Location = new System.Drawing.Point(16, 40);
            this.rdoBtnID.Name = "rdoBtnID";
            this.rdoBtnID.Size = new System.Drawing.Size(38, 17);
            this.rdoBtnID.TabIndex = 14;
            this.rdoBtnID.TabStop = true;
            this.rdoBtnID.Text = "ID";
            this.rdoBtnID.UseVisualStyleBackColor = true;
            // 
            // rdoBtnFlag
            // 
            this.rdoBtnFlag.AutoSize = true;
            this.rdoBtnFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnFlag.Location = new System.Drawing.Point(360, 40);
            this.rdoBtnFlag.Name = "rdoBtnFlag";
            this.rdoBtnFlag.Size = new System.Drawing.Size(49, 17);
            this.rdoBtnFlag.TabIndex = 13;
            this.rdoBtnFlag.TabStop = true;
            this.rdoBtnFlag.Text = "Flag";
            this.rdoBtnFlag.UseVisualStyleBackColor = true;
            // 
            // rdoBtnBird
            // 
            this.rdoBtnBird.AutoSize = true;
            this.rdoBtnBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnBird.Location = new System.Drawing.Point(241, 40);
            this.rdoBtnBird.Name = "rdoBtnBird";
            this.rdoBtnBird.Size = new System.Drawing.Size(47, 17);
            this.rdoBtnBird.TabIndex = 11;
            this.rdoBtnBird.TabStop = true;
            this.rdoBtnBird.Text = "Bird";
            this.rdoBtnBird.UseVisualStyleBackColor = true;
            // 
            // rdoBtnColor
            // 
            this.rdoBtnColor.AutoSize = true;
            this.rdoBtnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnColor.Location = new System.Drawing.Point(294, 40);
            this.rdoBtnColor.Name = "rdoBtnColor";
            this.rdoBtnColor.Size = new System.Drawing.Size(60, 17);
            this.rdoBtnColor.TabIndex = 12;
            this.rdoBtnColor.TabStop = true;
            this.rdoBtnColor.Text = "Colors";
            this.rdoBtnColor.UseVisualStyleBackColor = true;
            // 
            // rdoBtnFlower
            // 
            this.rdoBtnFlower.AutoSize = true;
            this.rdoBtnFlower.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnFlower.Location = new System.Drawing.Point(173, 40);
            this.rdoBtnFlower.Name = "rdoBtnFlower";
            this.rdoBtnFlower.Size = new System.Drawing.Size(62, 17);
            this.rdoBtnFlower.TabIndex = 10;
            this.rdoBtnFlower.TabStop = true;
            this.rdoBtnFlower.Text = "Flower";
            this.rdoBtnFlower.UseVisualStyleBackColor = true;
            // 
            // rdoBtnCity
            // 
            this.rdoBtnCity.AutoSize = true;
            this.rdoBtnCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnCity.Location = new System.Drawing.Point(121, 40);
            this.rdoBtnCity.Name = "rdoBtnCity";
            this.rdoBtnCity.Size = new System.Drawing.Size(46, 17);
            this.rdoBtnCity.TabIndex = 9;
            this.rdoBtnCity.TabStop = true;
            this.rdoBtnCity.Text = "City";
            this.rdoBtnCity.UseVisualStyleBackColor = true;
            // 
            // rdoBtnState
            // 
            this.rdoBtnState.AutoSize = true;
            this.rdoBtnState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnState.Location = new System.Drawing.Point(60, 40);
            this.rdoBtnState.Name = "rdoBtnState";
            this.rdoBtnState.Size = new System.Drawing.Size(55, 17);
            this.rdoBtnState.TabIndex = 7;
            this.rdoBtnState.TabStop = true;
            this.rdoBtnState.Text = "State";
            this.rdoBtnState.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(174, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(653, 678);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 30);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelSort
            // 
            this.panelSort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSort.Controls.Add(this.btnSortDesc);
            this.panelSort.Controls.Add(this.rdoBtnSortCities);
            this.panelSort.Controls.Add(this.rdoBtnSortJobs);
            this.panelSort.Controls.Add(this.rdoBtnSortInc);
            this.panelSort.Controls.Add(this.rdoBtnSortPop);
            this.panelSort.Controls.Add(this.rdoBtnSortFlag);
            this.panelSort.Controls.Add(this.rdoBtnSortID);
            this.panelSort.Controls.Add(this.btnSortAsc);
            this.panelSort.Controls.Add(this.rdoBtnSortBird);
            this.panelSort.Controls.Add(this.lblSort);
            this.panelSort.Controls.Add(this.rdoBtnSortColors);
            this.panelSort.Controls.Add(this.rdoBtnSortState);
            this.panelSort.Controls.Add(this.rdoBtnSortFlower);
            this.panelSort.Controls.Add(this.rdoBtnSortCap);
            this.panelSort.Location = new System.Drawing.Point(12, 333);
            this.panelSort.Name = "panelSort";
            this.panelSort.Size = new System.Drawing.Size(425, 132);
            this.panelSort.TabIndex = 15;
            // 
            // btnSortDesc
            // 
            this.btnSortDesc.Location = new System.Drawing.Point(228, 97);
            this.btnSortDesc.Name = "btnSortDesc";
            this.btnSortDesc.Size = new System.Drawing.Size(84, 30);
            this.btnSortDesc.TabIndex = 26;
            this.btnSortDesc.Text = "Sort &Desc";
            this.btnSortDesc.UseVisualStyleBackColor = true;
            this.btnSortDesc.Click += new System.EventHandler(this.btnSortDesc_Click);
            // 
            // rdoBtnSortCities
            // 
            this.rdoBtnSortCities.AutoSize = true;
            this.rdoBtnSortCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnSortCities.Location = new System.Drawing.Point(244, 64);
            this.rdoBtnSortCities.Name = "rdoBtnSortCities";
            this.rdoBtnSortCities.Size = new System.Drawing.Size(56, 17);
            this.rdoBtnSortCities.TabIndex = 25;
            this.rdoBtnSortCities.TabStop = true;
            this.rdoBtnSortCities.Text = "Cities";
            this.rdoBtnSortCities.UseVisualStyleBackColor = true;
            // 
            // rdoBtnSortJobs
            // 
            this.rdoBtnSortJobs.AutoSize = true;
            this.rdoBtnSortJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnSortJobs.Location = new System.Drawing.Point(348, 35);
            this.rdoBtnSortJobs.Name = "rdoBtnSortJobs";
            this.rdoBtnSortJobs.Size = new System.Drawing.Size(51, 17);
            this.rdoBtnSortJobs.TabIndex = 24;
            this.rdoBtnSortJobs.TabStop = true;
            this.rdoBtnSortJobs.Text = "Jobs";
            this.rdoBtnSortJobs.UseVisualStyleBackColor = true;
            // 
            // rdoBtnSortInc
            // 
            this.rdoBtnSortInc.AutoSize = true;
            this.rdoBtnSortInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnSortInc.Location = new System.Drawing.Point(276, 35);
            this.rdoBtnSortInc.Name = "rdoBtnSortInc";
            this.rdoBtnSortInc.Size = new System.Drawing.Size(66, 17);
            this.rdoBtnSortInc.TabIndex = 23;
            this.rdoBtnSortInc.TabStop = true;
            this.rdoBtnSortInc.Text = "Income";
            this.rdoBtnSortInc.UseVisualStyleBackColor = true;
            // 
            // rdoBtnSortPop
            // 
            this.rdoBtnSortPop.AutoSize = true;
            this.rdoBtnSortPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnSortPop.Location = new System.Drawing.Point(115, 35);
            this.rdoBtnSortPop.Name = "rdoBtnSortPop";
            this.rdoBtnSortPop.Size = new System.Drawing.Size(85, 17);
            this.rdoBtnSortPop.TabIndex = 22;
            this.rdoBtnSortPop.TabStop = true;
            this.rdoBtnSortPop.Text = "Population";
            this.rdoBtnSortPop.UseVisualStyleBackColor = true;
            // 
            // rdoBtnSortFlag
            // 
            this.rdoBtnSortFlag.AutoSize = true;
            this.rdoBtnSortFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnSortFlag.Location = new System.Drawing.Point(306, 64);
            this.rdoBtnSortFlag.Name = "rdoBtnSortFlag";
            this.rdoBtnSortFlag.Size = new System.Drawing.Size(49, 17);
            this.rdoBtnSortFlag.TabIndex = 20;
            this.rdoBtnSortFlag.TabStop = true;
            this.rdoBtnSortFlag.Text = "Flag";
            this.rdoBtnSortFlag.UseVisualStyleBackColor = true;
            // 
            // rdoBtnSortID
            // 
            this.rdoBtnSortID.AutoSize = true;
            this.rdoBtnSortID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnSortID.Location = new System.Drawing.Point(10, 35);
            this.rdoBtnSortID.Name = "rdoBtnSortID";
            this.rdoBtnSortID.Size = new System.Drawing.Size(38, 17);
            this.rdoBtnSortID.TabIndex = 21;
            this.rdoBtnSortID.TabStop = true;
            this.rdoBtnSortID.Text = "ID";
            this.rdoBtnSortID.UseVisualStyleBackColor = true;
            // 
            // btnSortAsc
            // 
            this.btnSortAsc.Location = new System.Drawing.Point(100, 97);
            this.btnSortAsc.Name = "btnSortAsc";
            this.btnSortAsc.Size = new System.Drawing.Size(84, 30);
            this.btnSortAsc.TabIndex = 5;
            this.btnSortAsc.Text = "Sort &Asc";
            this.btnSortAsc.UseVisualStyleBackColor = true;
            this.btnSortAsc.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // rdoBtnSortBird
            // 
            this.rdoBtnSortBird.AutoSize = true;
            this.rdoBtnSortBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnSortBird.Location = new System.Drawing.Point(125, 64);
            this.rdoBtnSortBird.Name = "rdoBtnSortBird";
            this.rdoBtnSortBird.Size = new System.Drawing.Size(47, 17);
            this.rdoBtnSortBird.TabIndex = 18;
            this.rdoBtnSortBird.TabStop = true;
            this.rdoBtnSortBird.Text = "Bird";
            this.rdoBtnSortBird.UseVisualStyleBackColor = true;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(191, 10);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(35, 16);
            this.lblSort.TabIndex = 6;
            this.lblSort.Text = "Sort";
            // 
            // rdoBtnSortColors
            // 
            this.rdoBtnSortColors.AutoSize = true;
            this.rdoBtnSortColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnSortColors.Location = new System.Drawing.Point(178, 64);
            this.rdoBtnSortColors.Name = "rdoBtnSortColors";
            this.rdoBtnSortColors.Size = new System.Drawing.Size(60, 17);
            this.rdoBtnSortColors.TabIndex = 19;
            this.rdoBtnSortColors.TabStop = true;
            this.rdoBtnSortColors.Text = "Colors";
            this.rdoBtnSortColors.UseVisualStyleBackColor = true;
            // 
            // rdoBtnSortState
            // 
            this.rdoBtnSortState.AutoSize = true;
            this.rdoBtnSortState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnSortState.Location = new System.Drawing.Point(54, 35);
            this.rdoBtnSortState.Name = "rdoBtnSortState";
            this.rdoBtnSortState.Size = new System.Drawing.Size(55, 17);
            this.rdoBtnSortState.TabIndex = 15;
            this.rdoBtnSortState.TabStop = true;
            this.rdoBtnSortState.Text = "State";
            this.rdoBtnSortState.UseVisualStyleBackColor = true;
            // 
            // rdoBtnSortFlower
            // 
            this.rdoBtnSortFlower.AutoSize = true;
            this.rdoBtnSortFlower.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnSortFlower.Location = new System.Drawing.Point(57, 64);
            this.rdoBtnSortFlower.Name = "rdoBtnSortFlower";
            this.rdoBtnSortFlower.Size = new System.Drawing.Size(62, 17);
            this.rdoBtnSortFlower.TabIndex = 17;
            this.rdoBtnSortFlower.TabStop = true;
            this.rdoBtnSortFlower.Text = "Flower";
            this.rdoBtnSortFlower.UseVisualStyleBackColor = true;
            // 
            // rdoBtnSortCap
            // 
            this.rdoBtnSortCap.AutoSize = true;
            this.rdoBtnSortCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnSortCap.Location = new System.Drawing.Point(206, 35);
            this.rdoBtnSortCap.Name = "rdoBtnSortCap";
            this.rdoBtnSortCap.Size = new System.Drawing.Size(64, 17);
            this.rdoBtnSortCap.TabIndex = 16;
            this.rdoBtnSortCap.TabStop = true;
            this.rdoBtnSortCap.Text = "Capital";
            this.rdoBtnSortCap.UseVisualStyleBackColor = true;
            // 
            // panelFilter
            // 
            this.panelFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilter.Controls.Add(this.txtBoxFilter);
            this.panelFilter.Controls.Add(this.cmbBxFilterOperator);
            this.panelFilter.Controls.Add(this.lblOption);
            this.panelFilter.Controls.Add(this.cmbBxFilterOption);
            this.panelFilter.Controls.Add(this.lblBy);
            this.panelFilter.Controls.Add(this.btnFilter);
            this.panelFilter.Controls.Add(this.lblFilter);
            this.panelFilter.Location = new System.Drawing.Point(12, 483);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(425, 225);
            this.panelFilter.TabIndex = 26;
            // 
            // txtBoxFilter
            // 
            this.txtBoxFilter.Location = new System.Drawing.Point(29, 143);
            this.txtBoxFilter.Name = "txtBoxFilter";
            this.txtBoxFilter.Size = new System.Drawing.Size(358, 22);
            this.txtBoxFilter.TabIndex = 15;
            // 
            // cmbBxFilterOperator
            // 
            this.cmbBxFilterOperator.FormattingEnabled = true;
            this.cmbBxFilterOperator.Items.AddRange(new object[] {
            ">",
            "<",
            "="});
            this.cmbBxFilterOperator.Location = new System.Drawing.Point(121, 93);
            this.cmbBxFilterOperator.Name = "cmbBxFilterOperator";
            this.cmbBxFilterOperator.Size = new System.Drawing.Size(234, 24);
            this.cmbBxFilterOperator.TabIndex = 28;
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.Location = new System.Drawing.Point(35, 51);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(56, 16);
            this.lblOption.TabIndex = 27;
            this.lblOption.Text = "Option:";
            // 
            // cmbBxFilterOption
            // 
            this.cmbBxFilterOption.FormattingEnabled = true;
            this.cmbBxFilterOption.Items.AddRange(new object[] {
            "Population",
            "Median Income",
            "Computer Jobs"});
            this.cmbBxFilterOption.Location = new System.Drawing.Point(121, 48);
            this.cmbBxFilterOption.Name = "cmbBxFilterOption";
            this.cmbBxFilterOption.Size = new System.Drawing.Size(234, 24);
            this.cmbBxFilterOption.TabIndex = 26;
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Location = new System.Drawing.Point(11, 96);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(80, 16);
            this.lblBy.TabIndex = 25;
            this.lblBy.Text = "Operators:";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(174, 182);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(81, 30);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(191, 10);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(42, 16);
            this.lblFilter.TabIndex = 6;
            this.lblFilter.Text = "Filter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 712);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelSort);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelStateInfo);
            this.Controls.Add(this.statesDataGridView);
            this.Controls.Add(this.statesBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingNavigator)).EndInit();
            this.statesBindingNavigator.ResumeLayout(false);
            this.statesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesDataGridView)).EndInit();
            this.panelStateInfo.ResumeLayout(false);
            this.panelStateInfo.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelSort.ResumeLayout(false);
            this.panelSort.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StateDBDataSet stateDBDataSet;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private StateDBDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
        private StateDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator statesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton statesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView statesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button btnStateDetails;
        private System.Windows.Forms.ComboBox cmbBxState;
        private System.Windows.Forms.Label lblStateInfo;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.Panel panelStateInfo;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdoBtnFlower;
        private System.Windows.Forms.RadioButton rdoBtnCity;
        private System.Windows.Forms.RadioButton rdoBtnState;
        private System.Windows.Forms.RadioButton rdoBtnBird;
        private System.Windows.Forms.RadioButton rdoBtnColor;
        private System.Windows.Forms.RadioButton rdoBtnFlag;
        private System.Windows.Forms.RadioButton rdoBtnID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelSort;
        private System.Windows.Forms.Button btnSortAsc;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.RadioButton rdoBtnSortPop;
        private System.Windows.Forms.RadioButton rdoBtnSortID;
        private System.Windows.Forms.RadioButton rdoBtnSortBird;
        private System.Windows.Forms.RadioButton rdoBtnSortColors;
        private System.Windows.Forms.RadioButton rdoBtnSortState;
        private System.Windows.Forms.RadioButton rdoBtnSortFlower;
        private System.Windows.Forms.RadioButton rdoBtnSortCap;
        private System.Windows.Forms.RadioButton rdoBtnSortFlag;
        private System.Windows.Forms.RadioButton rdoBtnSortInc;
        private System.Windows.Forms.RadioButton rdoBtnSortJobs;
        private System.Windows.Forms.RadioButton rdoBtnSortCities;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbBxFilterOperator;
        private System.Windows.Forms.Label lblOption;
        private System.Windows.Forms.ComboBox cmbBxFilterOption;
        private System.Windows.Forms.TextBox txtBoxFilter;
        private System.Windows.Forms.Button btnSortDesc;
    }
}

