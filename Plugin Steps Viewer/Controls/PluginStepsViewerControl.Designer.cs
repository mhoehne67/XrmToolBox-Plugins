namespace mho.PluginStepsViewer
{
	partial class PluginStepsViewerControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginStepsViewerControl));
			this.splitContainerMain = new System.Windows.Forms.SplitContainer();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.statusLabelNumAssemblies = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusLabelNumTypes = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusLabelNumSteps = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusLabelNumDisplayedSteps = new System.Windows.Forms.ToolStripStatusLabel();
			this.dataGridViewPluginStepsDisplay = new System.Windows.Forms.DataGridView();
			this.splitContainerFilterAndProperties = new System.Windows.Forms.SplitContainer();
			this.tabs = new System.Windows.Forms.TabControl();
			this.tabPageFilter = new System.Windows.Forms.TabPage();
			this.comboFilterSecondaryEntity = new System.Windows.Forms.ComboBox();
			this.labelFilterSecondaryEntity = new System.Windows.Forms.Label();
			this.comboFilterPrimaryEntity = new System.Windows.Forms.ComboBox();
			this.labelFilterPrimaryEntity = new System.Windows.Forms.Label();
			this.comboFilterMode = new System.Windows.Forms.ComboBox();
			this.labelFilterMode = new System.Windows.Forms.Label();
			this.comboFilterAssembly = new System.Windows.Forms.ComboBox();
			this.comboFilterType = new System.Windows.Forms.ComboBox();
			this.labelFilterAssembly = new System.Windows.Forms.Label();
			this.comboFilterMessage = new System.Windows.Forms.ComboBox();
			this.labelFilterType = new System.Windows.Forms.Label();
			this.labelFilterMessage = new System.Windows.Forms.Label();
			this.comboFilterStage = new System.Windows.Forms.ComboBox();
			this.labelFilterName = new System.Windows.Forms.Label();
			this.textFilterName = new System.Windows.Forms.TextBox();
			this.labelFilterStage = new System.Windows.Forms.Label();
			this.tabPageSettings = new System.Windows.Forms.TabPage();
			this.toolStripSettings = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripButtonExecute = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonResetToLastSavedState = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSaveSettings = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonDiscardSettings = new System.Windows.Forms.ToolStripButton();
			this.textBoxExcludedAssemblies = new System.Windows.Forms.TextBox();
			this.propertyGridPluginStep = new System.Windows.Forms.PropertyGrid();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.assemblyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.modeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.primaryEntityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.secondaryEntityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pluginStepDisplayBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.comboFilterSecondaryEntityOperator = new mho.PluginStepsViewer.FilterComboBox();
			this.comboFilterPrimaryEntityOperator = new mho.PluginStepsViewer.FilterComboBox();
			this.comboFilterModeOperator = new mho.PluginStepsViewer.FilterComboBox();
			this.comboFilterAssemblyOperator = new mho.PluginStepsViewer.FilterComboBox();
			this.comboFilterMessageOperator = new mho.PluginStepsViewer.FilterComboBox();
			this.comboFilterTypeOperator = new mho.PluginStepsViewer.FilterComboBox();
			this.comboFilterStageOperator = new mho.PluginStepsViewer.FilterComboBox();
			this.comboFilterNameOperator = new mho.PluginStepsViewer.FilterComboBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
			this.splitContainerMain.Panel1.SuspendLayout();
			this.splitContainerMain.Panel2.SuspendLayout();
			this.splitContainerMain.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPluginStepsDisplay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerFilterAndProperties)).BeginInit();
			this.splitContainerFilterAndProperties.Panel1.SuspendLayout();
			this.splitContainerFilterAndProperties.Panel2.SuspendLayout();
			this.splitContainerFilterAndProperties.SuspendLayout();
			this.tabs.SuspendLayout();
			this.tabPageFilter.SuspendLayout();
			this.tabPageSettings.SuspendLayout();
			this.toolStripSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pluginStepDisplayBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainerMain
			// 
			this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
			this.splitContainerMain.Margin = new System.Windows.Forms.Padding(4);
			this.splitContainerMain.Name = "splitContainerMain";
			// 
			// splitContainerMain.Panel1
			// 
			this.splitContainerMain.Panel1.Controls.Add(this.statusStrip1);
			this.splitContainerMain.Panel1.Controls.Add(this.dataGridViewPluginStepsDisplay);
			this.splitContainerMain.Panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// splitContainerMain.Panel2
			// 
			this.splitContainerMain.Panel2.Controls.Add(this.splitContainerFilterAndProperties);
			this.splitContainerMain.Size = new System.Drawing.Size(1794, 1063);
			this.splitContainerMain.SplitterDistance = 1253;
			this.splitContainerMain.SplitterWidth = 6;
			this.splitContainerMain.TabIndex = 1;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelNumAssemblies,
            this.statusLabelNumTypes,
            this.statusLabelNumSteps,
            this.statusLabelNumDisplayedSteps});
			this.statusStrip1.Location = new System.Drawing.Point(0, 1041);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1253, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// statusLabelNumAssemblies
			// 
			this.statusLabelNumAssemblies.Name = "statusLabelNumAssemblies";
			this.statusLabelNumAssemblies.Size = new System.Drawing.Size(78, 17);
			this.statusLabelNumAssemblies.Text = "Assemblies: 0";
			// 
			// statusLabelNumTypes
			// 
			this.statusLabelNumTypes.Name = "statusLabelNumTypes";
			this.statusLabelNumTypes.Size = new System.Drawing.Size(48, 17);
			this.statusLabelNumTypes.Text = "Types: 0";
			// 
			// statusLabelNumSteps
			// 
			this.statusLabelNumSteps.Name = "statusLabelNumSteps";
			this.statusLabelNumSteps.Size = new System.Drawing.Size(47, 17);
			this.statusLabelNumSteps.Text = "Steps: 0";
			// 
			// statusLabelNumDisplayedSteps
			// 
			this.statusLabelNumDisplayedSteps.Name = "statusLabelNumDisplayedSteps";
			this.statusLabelNumDisplayedSteps.Size = new System.Drawing.Size(101, 17);
			this.statusLabelNumDisplayedSteps.Text = "Displayed Steps: 0";
			// 
			// dataGridViewPluginStepsDisplay
			// 
			this.dataGridViewPluginStepsDisplay.AllowUserToAddRows = false;
			this.dataGridViewPluginStepsDisplay.AllowUserToDeleteRows = false;
			this.dataGridViewPluginStepsDisplay.AutoGenerateColumns = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewPluginStepsDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewPluginStepsDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPluginStepsDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.assemblyDataGridViewTextBoxColumn,
            this.modeDataGridViewTextBoxColumn,
            this.stageDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn,
            this.rankDataGridViewTextBoxColumn,
            this.primaryEntityDataGridViewTextBoxColumn,
            this.secondaryEntityDataGridViewTextBoxColumn});
			this.dataGridViewPluginStepsDisplay.DataSource = this.pluginStepDisplayBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewPluginStepsDisplay.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewPluginStepsDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewPluginStepsDisplay.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewPluginStepsDisplay.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewPluginStepsDisplay.MultiSelect = false;
			this.dataGridViewPluginStepsDisplay.Name = "dataGridViewPluginStepsDisplay";
			this.dataGridViewPluginStepsDisplay.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewPluginStepsDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewPluginStepsDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewPluginStepsDisplay.Size = new System.Drawing.Size(1253, 1063);
			this.dataGridViewPluginStepsDisplay.TabIndex = 1;
			this.dataGridViewPluginStepsDisplay.SelectionChanged += new System.EventHandler(this.dataGridViewPluginStepsDisplay_SelectionChanged);
			// 
			// splitContainerFilterAndProperties
			// 
			this.splitContainerFilterAndProperties.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerFilterAndProperties.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainerFilterAndProperties.Location = new System.Drawing.Point(0, 0);
			this.splitContainerFilterAndProperties.Name = "splitContainerFilterAndProperties";
			this.splitContainerFilterAndProperties.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainerFilterAndProperties.Panel1
			// 
			this.splitContainerFilterAndProperties.Panel1.Controls.Add(this.tabs);
			// 
			// splitContainerFilterAndProperties.Panel2
			// 
			this.splitContainerFilterAndProperties.Panel2.Controls.Add(this.propertyGridPluginStep);
			this.splitContainerFilterAndProperties.Size = new System.Drawing.Size(535, 1063);
			this.splitContainerFilterAndProperties.SplitterDistance = 275;
			this.splitContainerFilterAndProperties.TabIndex = 1;
			// 
			// tabs
			// 
			this.tabs.Controls.Add(this.tabPageFilter);
			this.tabs.Controls.Add(this.tabPageSettings);
			this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs.Location = new System.Drawing.Point(0, 0);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new System.Drawing.Size(535, 275);
			this.tabs.TabIndex = 19;
			// 
			// tabPageFilter
			// 
			this.tabPageFilter.Controls.Add(this.comboFilterSecondaryEntity);
			this.tabPageFilter.Controls.Add(this.comboFilterSecondaryEntityOperator);
			this.tabPageFilter.Controls.Add(this.labelFilterSecondaryEntity);
			this.tabPageFilter.Controls.Add(this.comboFilterPrimaryEntity);
			this.tabPageFilter.Controls.Add(this.comboFilterPrimaryEntityOperator);
			this.tabPageFilter.Controls.Add(this.labelFilterPrimaryEntity);
			this.tabPageFilter.Controls.Add(this.comboFilterMode);
			this.tabPageFilter.Controls.Add(this.labelFilterMode);
			this.tabPageFilter.Controls.Add(this.comboFilterModeOperator);
			this.tabPageFilter.Controls.Add(this.comboFilterAssembly);
			this.tabPageFilter.Controls.Add(this.comboFilterType);
			this.tabPageFilter.Controls.Add(this.labelFilterAssembly);
			this.tabPageFilter.Controls.Add(this.comboFilterMessage);
			this.tabPageFilter.Controls.Add(this.comboFilterAssemblyOperator);
			this.tabPageFilter.Controls.Add(this.comboFilterMessageOperator);
			this.tabPageFilter.Controls.Add(this.labelFilterType);
			this.tabPageFilter.Controls.Add(this.labelFilterMessage);
			this.tabPageFilter.Controls.Add(this.comboFilterTypeOperator);
			this.tabPageFilter.Controls.Add(this.comboFilterStage);
			this.tabPageFilter.Controls.Add(this.labelFilterName);
			this.tabPageFilter.Controls.Add(this.textFilterName);
			this.tabPageFilter.Controls.Add(this.comboFilterStageOperator);
			this.tabPageFilter.Controls.Add(this.comboFilterNameOperator);
			this.tabPageFilter.Controls.Add(this.labelFilterStage);
			this.tabPageFilter.Location = new System.Drawing.Point(4, 24);
			this.tabPageFilter.Name = "tabPageFilter";
			this.tabPageFilter.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageFilter.Size = new System.Drawing.Size(527, 247);
			this.tabPageFilter.TabIndex = 0;
			this.tabPageFilter.Text = "Filter";
			this.tabPageFilter.UseVisualStyleBackColor = true;
			// 
			// comboFilterSecondaryEntity
			// 
			this.comboFilterSecondaryEntity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboFilterSecondaryEntity.BackColor = System.Drawing.SystemColors.Window;
			this.comboFilterSecondaryEntity.FormattingEnabled = true;
			this.comboFilterSecondaryEntity.Location = new System.Drawing.Point(211, 218);
			this.comboFilterSecondaryEntity.Name = "comboFilterSecondaryEntity";
			this.comboFilterSecondaryEntity.Size = new System.Drawing.Size(310, 23);
			this.comboFilterSecondaryEntity.TabIndex = 91;
			this.comboFilterSecondaryEntity.TextChanged += new System.EventHandler(this.FilterChanged);
			// 
			// labelFilterSecondaryEntity
			// 
			this.labelFilterSecondaryEntity.AutoSize = true;
			this.labelFilterSecondaryEntity.Location = new System.Drawing.Point(6, 224);
			this.labelFilterSecondaryEntity.Name = "labelFilterSecondaryEntity";
			this.labelFilterSecondaryEntity.Size = new System.Drawing.Size(95, 15);
			this.labelFilterSecondaryEntity.TabIndex = 75;
			this.labelFilterSecondaryEntity.Text = "Secondary Entity";
			// 
			// comboFilterPrimaryEntity
			// 
			this.comboFilterPrimaryEntity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboFilterPrimaryEntity.BackColor = System.Drawing.SystemColors.Window;
			this.comboFilterPrimaryEntity.FormattingEnabled = true;
			this.comboFilterPrimaryEntity.Location = new System.Drawing.Point(211, 189);
			this.comboFilterPrimaryEntity.Name = "comboFilterPrimaryEntity";
			this.comboFilterPrimaryEntity.Size = new System.Drawing.Size(310, 23);
			this.comboFilterPrimaryEntity.TabIndex = 81;
			this.comboFilterPrimaryEntity.TextChanged += new System.EventHandler(this.FilterChanged);
			// 
			// labelFilterPrimaryEntity
			// 
			this.labelFilterPrimaryEntity.AutoSize = true;
			this.labelFilterPrimaryEntity.Location = new System.Drawing.Point(6, 195);
			this.labelFilterPrimaryEntity.Name = "labelFilterPrimaryEntity";
			this.labelFilterPrimaryEntity.Size = new System.Drawing.Size(81, 15);
			this.labelFilterPrimaryEntity.TabIndex = 72;
			this.labelFilterPrimaryEntity.Text = "Primary Entity";
			// 
			// comboFilterMode
			// 
			this.comboFilterMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboFilterMode.BackColor = System.Drawing.SystemColors.Window;
			this.comboFilterMode.FormattingEnabled = true;
			this.comboFilterMode.Location = new System.Drawing.Point(211, 99);
			this.comboFilterMode.Name = "comboFilterMode";
			this.comboFilterMode.Size = new System.Drawing.Size(310, 23);
			this.comboFilterMode.TabIndex = 51;
			this.comboFilterMode.TextChanged += new System.EventHandler(this.FilterChanged);
			// 
			// labelFilterMode
			// 
			this.labelFilterMode.AutoSize = true;
			this.labelFilterMode.Location = new System.Drawing.Point(6, 105);
			this.labelFilterMode.Name = "labelFilterMode";
			this.labelFilterMode.Size = new System.Drawing.Size(38, 15);
			this.labelFilterMode.TabIndex = 62;
			this.labelFilterMode.Text = "Mode";
			// 
			// comboFilterAssembly
			// 
			this.comboFilterAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboFilterAssembly.BackColor = System.Drawing.SystemColors.Window;
			this.comboFilterAssembly.FormattingEnabled = true;
			this.comboFilterAssembly.Location = new System.Drawing.Point(211, 6);
			this.comboFilterAssembly.Name = "comboFilterAssembly";
			this.comboFilterAssembly.Size = new System.Drawing.Size(310, 23);
			this.comboFilterAssembly.TabIndex = 21;
			this.comboFilterAssembly.TextChanged += new System.EventHandler(this.FilterChanged);
			// 
			// comboFilterType
			// 
			this.comboFilterType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboFilterType.BackColor = System.Drawing.SystemColors.Window;
			this.comboFilterType.FormattingEnabled = true;
			this.comboFilterType.Location = new System.Drawing.Point(211, 38);
			this.comboFilterType.Name = "comboFilterType";
			this.comboFilterType.Size = new System.Drawing.Size(310, 23);
			this.comboFilterType.TabIndex = 31;
			this.comboFilterType.TextChanged += new System.EventHandler(this.FilterChanged);
			// 
			// labelFilterAssembly
			// 
			this.labelFilterAssembly.AutoSize = true;
			this.labelFilterAssembly.Location = new System.Drawing.Point(6, 12);
			this.labelFilterAssembly.Name = "labelFilterAssembly";
			this.labelFilterAssembly.Size = new System.Drawing.Size(58, 15);
			this.labelFilterAssembly.TabIndex = 0;
			this.labelFilterAssembly.Text = "Assembly";
			// 
			// comboFilterMessage
			// 
			this.comboFilterMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboFilterMessage.BackColor = System.Drawing.SystemColors.Window;
			this.comboFilterMessage.FormattingEnabled = true;
			this.comboFilterMessage.Location = new System.Drawing.Point(211, 160);
			this.comboFilterMessage.Name = "comboFilterMessage";
			this.comboFilterMessage.Size = new System.Drawing.Size(310, 23);
			this.comboFilterMessage.TabIndex = 71;
			this.comboFilterMessage.TextChanged += new System.EventHandler(this.FilterChanged);
			// 
			// labelFilterType
			// 
			this.labelFilterType.AutoSize = true;
			this.labelFilterType.Location = new System.Drawing.Point(6, 44);
			this.labelFilterType.Name = "labelFilterType";
			this.labelFilterType.Size = new System.Drawing.Size(31, 15);
			this.labelFilterType.TabIndex = 3;
			this.labelFilterType.Text = "Type";
			// 
			// labelFilterMessage
			// 
			this.labelFilterMessage.AutoSize = true;
			this.labelFilterMessage.Location = new System.Drawing.Point(6, 166);
			this.labelFilterMessage.Name = "labelFilterMessage";
			this.labelFilterMessage.Size = new System.Drawing.Size(53, 15);
			this.labelFilterMessage.TabIndex = 14;
			this.labelFilterMessage.Text = "Message";
			// 
			// comboFilterStage
			// 
			this.comboFilterStage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboFilterStage.BackColor = System.Drawing.SystemColors.Window;
			this.comboFilterStage.FormattingEnabled = true;
			this.comboFilterStage.Location = new System.Drawing.Point(211, 128);
			this.comboFilterStage.Name = "comboFilterStage";
			this.comboFilterStage.Size = new System.Drawing.Size(310, 23);
			this.comboFilterStage.TabIndex = 61;
			this.comboFilterStage.TextChanged += new System.EventHandler(this.FilterChanged);
			// 
			// labelFilterName
			// 
			this.labelFilterName.AutoSize = true;
			this.labelFilterName.Location = new System.Drawing.Point(6, 76);
			this.labelFilterName.Name = "labelFilterName";
			this.labelFilterName.Size = new System.Drawing.Size(39, 15);
			this.labelFilterName.TabIndex = 6;
			this.labelFilterName.Text = "Name";
			// 
			// textFilterName
			// 
			this.textFilterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textFilterName.Location = new System.Drawing.Point(211, 70);
			this.textFilterName.Name = "textFilterName";
			this.textFilterName.Size = new System.Drawing.Size(310, 23);
			this.textFilterName.TabIndex = 41;
			this.textFilterName.TextChanged += new System.EventHandler(this.FilterChanged);
			// 
			// labelFilterStage
			// 
			this.labelFilterStage.AutoSize = true;
			this.labelFilterStage.Location = new System.Drawing.Point(6, 134);
			this.labelFilterStage.Name = "labelFilterStage";
			this.labelFilterStage.Size = new System.Drawing.Size(36, 15);
			this.labelFilterStage.TabIndex = 9;
			this.labelFilterStage.Text = "Stage";
			// 
			// tabPageSettings
			// 
			this.tabPageSettings.Controls.Add(this.toolStripSettings);
			this.tabPageSettings.Controls.Add(this.textBoxExcludedAssemblies);
			this.tabPageSettings.Location = new System.Drawing.Point(4, 24);
			this.tabPageSettings.Name = "tabPageSettings";
			this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSettings.Size = new System.Drawing.Size(527, 247);
			this.tabPageSettings.TabIndex = 1;
			this.tabPageSettings.Text = "Settings";
			this.tabPageSettings.UseVisualStyleBackColor = true;
			// 
			// toolStripSettings
			// 
			this.toolStripSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButtonExecute,
            this.toolStripButtonResetToLastSavedState,
            this.toolStripButtonSaveSettings,
            this.toolStripButtonDiscardSettings});
			this.toolStripSettings.Location = new System.Drawing.Point(3, 3);
			this.toolStripSettings.Name = "toolStripSettings";
			this.toolStripSettings.Size = new System.Drawing.Size(521, 25);
			this.toolStripSettings.TabIndex = 10;
			this.toolStripSettings.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(176, 22);
			this.toolStripLabel1.Text = "Assemblies to exclude (prefixes)";
			// 
			// toolStripButtonExecute
			// 
			this.toolStripButtonExecute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonExecute.Image = global::mho.PluginStepsViewer.Images16x16.Refresh;
			this.toolStripButtonExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonExecute.Name = "toolStripButtonExecute";
			this.toolStripButtonExecute.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonExecute.Text = "toolStripButton1";
			this.toolStripButtonExecute.ToolTipText = "Reload steps using current exclusion list";
			this.toolStripButtonExecute.Click += new System.EventHandler(this.toolStripButtonExecute_Click);
			// 
			// toolStripButtonResetToLastSavedState
			// 
			this.toolStripButtonResetToLastSavedState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonResetToLastSavedState.Image = global::mho.PluginStepsViewer.Images16x16.Open;
			this.toolStripButtonResetToLastSavedState.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonResetToLastSavedState.Name = "toolStripButtonResetToLastSavedState";
			this.toolStripButtonResetToLastSavedState.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonResetToLastSavedState.Text = "toolStripButton1";
			this.toolStripButtonResetToLastSavedState.ToolTipText = "Reset to last saved state";
			this.toolStripButtonResetToLastSavedState.Click += new System.EventHandler(this.toolStripButtonResetToLastSavedState_Click);
			// 
			// toolStripButtonSaveSettings
			// 
			this.toolStripButtonSaveSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonSaveSettings.Image = global::mho.PluginStepsViewer.Images16x16.Save;
			this.toolStripButtonSaveSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSaveSettings.Name = "toolStripButtonSaveSettings";
			this.toolStripButtonSaveSettings.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonSaveSettings.Text = "toolStripButton1";
			this.toolStripButtonSaveSettings.ToolTipText = "Save settings (affects all environments)";
			this.toolStripButtonSaveSettings.Click += new System.EventHandler(this.toolStripButtonSaveSettings_Click);
			// 
			// toolStripButtonDiscardSettings
			// 
			this.toolStripButtonDiscardSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonDiscardSettings.Image = global::mho.PluginStepsViewer.Images16x16.Delete;
			this.toolStripButtonDiscardSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonDiscardSettings.Name = "toolStripButtonDiscardSettings";
			this.toolStripButtonDiscardSettings.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonDiscardSettings.Text = "toolStripButton1";
			this.toolStripButtonDiscardSettings.ToolTipText = "Discards any changes you made and restore the default exclusion list.";
			this.toolStripButtonDiscardSettings.Click += new System.EventHandler(this.toolStripButtonDiscardSettings_Click);
			// 
			// textBoxExcludedAssemblies
			// 
			this.textBoxExcludedAssemblies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxExcludedAssemblies.Location = new System.Drawing.Point(9, 24);
			this.textBoxExcludedAssemblies.Multiline = true;
			this.textBoxExcludedAssemblies.Name = "textBoxExcludedAssemblies";
			this.textBoxExcludedAssemblies.Size = new System.Drawing.Size(512, 260);
			this.textBoxExcludedAssemblies.TabIndex = 9;
			// 
			// propertyGridPluginStep
			// 
			this.propertyGridPluginStep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertyGridPluginStep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.propertyGridPluginStep.Location = new System.Drawing.Point(0, 0);
			this.propertyGridPluginStep.Name = "propertyGridPluginStep";
			this.propertyGridPluginStep.Size = new System.Drawing.Size(535, 784);
			this.propertyGridPluginStep.TabIndex = 100;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// typeDataGridViewTextBoxColumn
			// 
			this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
			this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
			this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
			this.typeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// assemblyDataGridViewTextBoxColumn
			// 
			this.assemblyDataGridViewTextBoxColumn.DataPropertyName = "Assembly";
			this.assemblyDataGridViewTextBoxColumn.HeaderText = "Assembly";
			this.assemblyDataGridViewTextBoxColumn.Name = "assemblyDataGridViewTextBoxColumn";
			this.assemblyDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// modeDataGridViewTextBoxColumn
			// 
			this.modeDataGridViewTextBoxColumn.DataPropertyName = "Mode";
			this.modeDataGridViewTextBoxColumn.HeaderText = "Mode";
			this.modeDataGridViewTextBoxColumn.Name = "modeDataGridViewTextBoxColumn";
			this.modeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// stageDataGridViewTextBoxColumn
			// 
			this.stageDataGridViewTextBoxColumn.DataPropertyName = "Stage";
			this.stageDataGridViewTextBoxColumn.HeaderText = "Stage";
			this.stageDataGridViewTextBoxColumn.Name = "stageDataGridViewTextBoxColumn";
			this.stageDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// messageDataGridViewTextBoxColumn
			// 
			this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
			this.messageDataGridViewTextBoxColumn.HeaderText = "Message";
			this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
			this.messageDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// rankDataGridViewTextBoxColumn
			// 
			this.rankDataGridViewTextBoxColumn.DataPropertyName = "Rank";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.rankDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.rankDataGridViewTextBoxColumn.HeaderText = "Rank";
			this.rankDataGridViewTextBoxColumn.Name = "rankDataGridViewTextBoxColumn";
			this.rankDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// primaryEntityDataGridViewTextBoxColumn
			// 
			this.primaryEntityDataGridViewTextBoxColumn.DataPropertyName = "PrimaryEntity";
			this.primaryEntityDataGridViewTextBoxColumn.HeaderText = "Primary Entity";
			this.primaryEntityDataGridViewTextBoxColumn.Name = "primaryEntityDataGridViewTextBoxColumn";
			this.primaryEntityDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// secondaryEntityDataGridViewTextBoxColumn
			// 
			this.secondaryEntityDataGridViewTextBoxColumn.DataPropertyName = "SecondaryEntity";
			this.secondaryEntityDataGridViewTextBoxColumn.HeaderText = "Secondary Entity";
			this.secondaryEntityDataGridViewTextBoxColumn.Name = "secondaryEntityDataGridViewTextBoxColumn";
			this.secondaryEntityDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// pluginStepDisplayBindingSource
			// 
			this.pluginStepDisplayBindingSource.DataSource = typeof(mho.PluginStepsViewer.Display.PluginStepSummary);
			// 
			// comboFilterSecondaryEntityOperator
			// 
			this.comboFilterSecondaryEntityOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboFilterSecondaryEntityOperator.FilteredPropertyName = "SecondaryEntity";
			this.comboFilterSecondaryEntityOperator.FilteringComboBox = this.comboFilterSecondaryEntity;
			this.comboFilterSecondaryEntityOperator.FilteringTextBox = null;
			this.comboFilterSecondaryEntityOperator.FilterOperator = mho.PluginStepsViewer.FilterOperator.Contains;
			this.comboFilterSecondaryEntityOperator.FormattingEnabled = true;
			this.comboFilterSecondaryEntityOperator.Items.AddRange(new object[] {
            "contains",
            "begins with",
            "is"});
			this.comboFilterSecondaryEntityOperator.Location = new System.Drawing.Point(107, 218);
			this.comboFilterSecondaryEntityOperator.Name = "comboFilterSecondaryEntityOperator";
			this.comboFilterSecondaryEntityOperator.Size = new System.Drawing.Size(98, 23);
			this.comboFilterSecondaryEntityOperator.TabIndex = 90;
			this.comboFilterSecondaryEntityOperator.SelectedIndexChanged += new System.EventHandler(this.FilterChanged);
			// 
			// comboFilterPrimaryEntityOperator
			// 
			this.comboFilterPrimaryEntityOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboFilterPrimaryEntityOperator.FilteredPropertyName = "PrimaryEntity";
			this.comboFilterPrimaryEntityOperator.FilteringComboBox = this.comboFilterPrimaryEntity;
			this.comboFilterPrimaryEntityOperator.FilteringTextBox = null;
			this.comboFilterPrimaryEntityOperator.FilterOperator = mho.PluginStepsViewer.FilterOperator.Contains;
			this.comboFilterPrimaryEntityOperator.FormattingEnabled = true;
			this.comboFilterPrimaryEntityOperator.Items.AddRange(new object[] {
            "contains",
            "begins with",
            "is"});
			this.comboFilterPrimaryEntityOperator.Location = new System.Drawing.Point(107, 189);
			this.comboFilterPrimaryEntityOperator.Name = "comboFilterPrimaryEntityOperator";
			this.comboFilterPrimaryEntityOperator.Size = new System.Drawing.Size(98, 23);
			this.comboFilterPrimaryEntityOperator.TabIndex = 80;
			this.comboFilterPrimaryEntityOperator.SelectedIndexChanged += new System.EventHandler(this.FilterChanged);
			// 
			// comboFilterModeOperator
			// 
			this.comboFilterModeOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboFilterModeOperator.FilteredPropertyName = "Mode";
			this.comboFilterModeOperator.FilteringComboBox = this.comboFilterMode;
			this.comboFilterModeOperator.FilteringTextBox = null;
			this.comboFilterModeOperator.FilterOperator = mho.PluginStepsViewer.FilterOperator.Contains;
			this.comboFilterModeOperator.FormattingEnabled = true;
			this.comboFilterModeOperator.Items.AddRange(new object[] {
            "contains",
            "begins with",
            "is"});
			this.comboFilterModeOperator.Location = new System.Drawing.Point(107, 99);
			this.comboFilterModeOperator.Name = "comboFilterModeOperator";
			this.comboFilterModeOperator.Size = new System.Drawing.Size(98, 23);
			this.comboFilterModeOperator.TabIndex = 50;
			this.comboFilterModeOperator.SelectedIndexChanged += new System.EventHandler(this.FilterChanged);
			// 
			// comboFilterAssemblyOperator
			// 
			this.comboFilterAssemblyOperator.BackColor = System.Drawing.SystemColors.Window;
			this.comboFilterAssemblyOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboFilterAssemblyOperator.FilteredPropertyName = "Assembly";
			this.comboFilterAssemblyOperator.FilteringComboBox = this.comboFilterAssembly;
			this.comboFilterAssemblyOperator.FilteringTextBox = null;
			this.comboFilterAssemblyOperator.FilterOperator = mho.PluginStepsViewer.FilterOperator.Contains;
			this.comboFilterAssemblyOperator.FormattingEnabled = true;
			this.comboFilterAssemblyOperator.Items.AddRange(new object[] {
            "contains",
            "begins with",
            "is"});
			this.comboFilterAssemblyOperator.Location = new System.Drawing.Point(107, 6);
			this.comboFilterAssemblyOperator.Name = "comboFilterAssemblyOperator";
			this.comboFilterAssemblyOperator.Size = new System.Drawing.Size(98, 23);
			this.comboFilterAssemblyOperator.TabIndex = 20;
			this.comboFilterAssemblyOperator.SelectedIndexChanged += new System.EventHandler(this.FilterChanged);
			// 
			// comboFilterMessageOperator
			// 
			this.comboFilterMessageOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboFilterMessageOperator.FilteredPropertyName = "Message";
			this.comboFilterMessageOperator.FilteringComboBox = this.comboFilterMessage;
			this.comboFilterMessageOperator.FilteringTextBox = null;
			this.comboFilterMessageOperator.FilterOperator = mho.PluginStepsViewer.FilterOperator.Contains;
			this.comboFilterMessageOperator.FormattingEnabled = true;
			this.comboFilterMessageOperator.Items.AddRange(new object[] {
            "contains",
            "begins with",
            "is"});
			this.comboFilterMessageOperator.Location = new System.Drawing.Point(107, 160);
			this.comboFilterMessageOperator.Name = "comboFilterMessageOperator";
			this.comboFilterMessageOperator.Size = new System.Drawing.Size(98, 23);
			this.comboFilterMessageOperator.TabIndex = 70;
			this.comboFilterMessageOperator.SelectedIndexChanged += new System.EventHandler(this.FilterChanged);
			// 
			// comboFilterTypeOperator
			// 
			this.comboFilterTypeOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboFilterTypeOperator.FilteredPropertyName = "Type";
			this.comboFilterTypeOperator.FilteringComboBox = this.comboFilterType;
			this.comboFilterTypeOperator.FilteringTextBox = null;
			this.comboFilterTypeOperator.FilterOperator = mho.PluginStepsViewer.FilterOperator.Contains;
			this.comboFilterTypeOperator.FormattingEnabled = true;
			this.comboFilterTypeOperator.Items.AddRange(new object[] {
            "contains",
            "begins with",
            "is"});
			this.comboFilterTypeOperator.Location = new System.Drawing.Point(107, 38);
			this.comboFilterTypeOperator.Name = "comboFilterTypeOperator";
			this.comboFilterTypeOperator.Size = new System.Drawing.Size(98, 23);
			this.comboFilterTypeOperator.TabIndex = 30;
			this.comboFilterTypeOperator.SelectedIndexChanged += new System.EventHandler(this.FilterChanged);
			// 
			// comboFilterStageOperator
			// 
			this.comboFilterStageOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboFilterStageOperator.FilteredPropertyName = "Stage";
			this.comboFilterStageOperator.FilteringComboBox = this.comboFilterStage;
			this.comboFilterStageOperator.FilteringTextBox = null;
			this.comboFilterStageOperator.FilterOperator = mho.PluginStepsViewer.FilterOperator.Contains;
			this.comboFilterStageOperator.FormattingEnabled = true;
			this.comboFilterStageOperator.Items.AddRange(new object[] {
            "contains",
            "begins with",
            "is"});
			this.comboFilterStageOperator.Location = new System.Drawing.Point(107, 128);
			this.comboFilterStageOperator.Name = "comboFilterStageOperator";
			this.comboFilterStageOperator.Size = new System.Drawing.Size(98, 23);
			this.comboFilterStageOperator.TabIndex = 60;
			this.comboFilterStageOperator.SelectedIndexChanged += new System.EventHandler(this.FilterChanged);
			// 
			// comboFilterNameOperator
			// 
			this.comboFilterNameOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboFilterNameOperator.FilteredPropertyName = "Name";
			this.comboFilterNameOperator.FilteringComboBox = null;
			this.comboFilterNameOperator.FilteringTextBox = this.textFilterName;
			this.comboFilterNameOperator.FilterOperator = mho.PluginStepsViewer.FilterOperator.Contains;
			this.comboFilterNameOperator.FormattingEnabled = true;
			this.comboFilterNameOperator.Items.AddRange(new object[] {
            "contains",
            "begins with",
            "is"});
			this.comboFilterNameOperator.Location = new System.Drawing.Point(107, 70);
			this.comboFilterNameOperator.Name = "comboFilterNameOperator";
			this.comboFilterNameOperator.Size = new System.Drawing.Size(98, 23);
			this.comboFilterNameOperator.TabIndex = 40;
			this.comboFilterNameOperator.SelectedIndexChanged += new System.EventHandler(this.FilterChanged);
			// 
			// PluginStepsViewerControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainerMain);
			this.Name = "PluginStepsViewerControl";
			this.PluginIcon = ((System.Drawing.Icon)(resources.GetObject("$this.PluginIcon")));
			this.Size = new System.Drawing.Size(1794, 1063);
			this.splitContainerMain.Panel1.ResumeLayout(false);
			this.splitContainerMain.Panel1.PerformLayout();
			this.splitContainerMain.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
			this.splitContainerMain.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPluginStepsDisplay)).EndInit();
			this.splitContainerFilterAndProperties.Panel1.ResumeLayout(false);
			this.splitContainerFilterAndProperties.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerFilterAndProperties)).EndInit();
			this.splitContainerFilterAndProperties.ResumeLayout(false);
			this.tabs.ResumeLayout(false);
			this.tabPageFilter.ResumeLayout(false);
			this.tabPageFilter.PerformLayout();
			this.tabPageSettings.ResumeLayout(false);
			this.tabPageSettings.PerformLayout();
			this.toolStripSettings.ResumeLayout(false);
			this.toolStripSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pluginStepDisplayBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainerMain;
		private System.Windows.Forms.DataGridView dataGridViewPluginStepsDisplay;
		private System.Windows.Forms.SplitContainer splitContainerFilterAndProperties;
		private System.Windows.Forms.ComboBox comboFilterStage;
		private System.Windows.Forms.ComboBox comboFilterAssembly;
		private mho.PluginStepsViewer.FilterComboBox comboFilterStageOperator;
		private System.Windows.Forms.Label labelFilterStage;
		private mho.PluginStepsViewer.FilterComboBox comboFilterNameOperator;
		private System.Windows.Forms.TextBox textFilterName;
		private System.Windows.Forms.Label labelFilterName;
		private mho.PluginStepsViewer.FilterComboBox comboFilterTypeOperator;
		private System.Windows.Forms.Label labelFilterType;
		private mho.PluginStepsViewer.FilterComboBox comboFilterAssemblyOperator;
		private System.Windows.Forms.Label labelFilterAssembly;
		private System.Windows.Forms.PropertyGrid propertyGridPluginStep;
		private System.Windows.Forms.ComboBox comboFilterMessage;
		private mho.PluginStepsViewer.FilterComboBox comboFilterMessageOperator;
		private System.Windows.Forms.Label labelFilterMessage;
		private System.Windows.Forms.ComboBox comboFilterType;
		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage tabPageFilter;
		private System.Windows.Forms.TabPage tabPageSettings;
		private System.Windows.Forms.TextBox textBoxExcludedAssemblies;
		private System.Windows.Forms.ToolStrip toolStripSettings;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripButton toolStripButtonSaveSettings;
		private System.Windows.Forms.ToolStripButton toolStripButtonExecute;
		private System.Windows.Forms.ToolStripButton toolStripButtonResetToLastSavedState;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel statusLabelNumAssemblies;
		private System.Windows.Forms.ToolStripStatusLabel statusLabelNumTypes;
		private System.Windows.Forms.ToolStripStatusLabel statusLabelNumSteps;
		private System.Windows.Forms.ToolStripStatusLabel statusLabelNumDisplayedSteps;
		private System.Windows.Forms.Label labelFilterMode;
		private mho.PluginStepsViewer.FilterComboBox comboFilterModeOperator;
		private System.Windows.Forms.ComboBox comboFilterMode;
		private System.Windows.Forms.BindingSource pluginStepDisplayBindingSource;
		private System.Windows.Forms.ComboBox comboFilterSecondaryEntity;
		private FilterComboBox comboFilterSecondaryEntityOperator;
		private System.Windows.Forms.Label labelFilterSecondaryEntity;
		private System.Windows.Forms.ComboBox comboFilterPrimaryEntity;
		private FilterComboBox comboFilterPrimaryEntityOperator;
		private System.Windows.Forms.Label labelFilterPrimaryEntity;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonDiscardSettings;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn assemblyDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn modeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn stageDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn primaryEntityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn secondaryEntityDataGridViewTextBoxColumn;
	}
}
