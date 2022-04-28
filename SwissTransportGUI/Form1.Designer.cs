namespace SwissTransportGUI
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.verbindungenRButton = new System.Windows.Forms.RadioButton();
      this.selectionGroup = new System.Windows.Forms.GroupBox();
      this.karteRButton = new System.Windows.Forms.RadioButton();
      this.abfahrtstafelRButton = new System.Windows.Forms.RadioButton();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.verbindungenDataGridView = new System.Windows.Forms.DataGridView();
      this.DepartTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PlatformColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FromTrainstationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ToTrainstationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ArrivalTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PlatformArrivalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.searchButton = new System.Windows.Forms.Button();
      this.testBox = new System.Windows.Forms.TextBox();
      this.fromComboBox = new System.Windows.Forms.ComboBox();
      this.toComboBox = new System.Windows.Forms.ComboBox();
      this.selectionGroup.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.verbindungenDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
      this.SuspendLayout();
      // 
      // verbindungenRButton
      // 
      this.verbindungenRButton.Appearance = System.Windows.Forms.Appearance.Button;
      this.verbindungenRButton.AutoSize = true;
      this.verbindungenRButton.Checked = true;
      this.verbindungenRButton.Location = new System.Drawing.Point(0, 13);
      this.verbindungenRButton.Name = "verbindungenRButton";
      this.verbindungenRButton.Size = new System.Drawing.Size(162, 30);
      this.verbindungenRButton.TabIndex = 0;
      this.verbindungenRButton.TabStop = true;
      this.verbindungenRButton.Text = "Verbindungen Suchen";
      this.verbindungenRButton.UseVisualStyleBackColor = true;
      this.verbindungenRButton.Click += new System.EventHandler(this.VerbindungenRButton_Click);
      // 
      // selectionGroup
      // 
      this.selectionGroup.Controls.Add(this.karteRButton);
      this.selectionGroup.Controls.Add(this.abfahrtstafelRButton);
      this.selectionGroup.Controls.Add(this.verbindungenRButton);
      this.selectionGroup.Location = new System.Drawing.Point(3, 3);
      this.selectionGroup.Name = "selectionGroup";
      this.selectionGroup.Size = new System.Drawing.Size(349, 45);
      this.selectionGroup.TabIndex = 1;
      this.selectionGroup.TabStop = false;
      // 
      // karteRButton
      // 
      this.karteRButton.Appearance = System.Windows.Forms.Appearance.Button;
      this.karteRButton.AutoSize = true;
      this.karteRButton.Location = new System.Drawing.Point(279, 13);
      this.karteRButton.Name = "karteRButton";
      this.karteRButton.Size = new System.Drawing.Size(54, 30);
      this.karteRButton.TabIndex = 2;
      this.karteRButton.Text = "Karte";
      this.karteRButton.UseVisualStyleBackColor = true;
      // 
      // abfahrtstafelRButton
      // 
      this.abfahrtstafelRButton.Appearance = System.Windows.Forms.Appearance.Button;
      this.abfahrtstafelRButton.AutoSize = true;
      this.abfahrtstafelRButton.Location = new System.Drawing.Point(168, 13);
      this.abfahrtstafelRButton.Name = "abfahrtstafelRButton";
      this.abfahrtstafelRButton.Size = new System.Drawing.Size(105, 30);
      this.abfahrtstafelRButton.TabIndex = 1;
      this.abfahrtstafelRButton.Text = "Abfahrtstafel";
      this.abfahrtstafelRButton.UseVisualStyleBackColor = true;
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(3, 87);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(349, 27);
      this.dateTimePicker1.TabIndex = 4;
      // 
      // stationBindingSource
      // 
      this.stationBindingSource.DataSource = typeof(SwissTransport.Models.Station);
      // 
      // verbindungenDataGridView
      // 
      this.verbindungenDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.verbindungenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.verbindungenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartTimeColumn,
            this.PlatformColumn,
            this.FromTrainstationColumn,
            this.ToTrainstationColumn,
            this.ArrivalTimeColumn,
            this.PlatformArrivalColumn});
      this.verbindungenDataGridView.Location = new System.Drawing.Point(2, 126);
      this.verbindungenDataGridView.Name = "verbindungenDataGridView";
      this.verbindungenDataGridView.RowHeadersWidth = 51;
      this.verbindungenDataGridView.RowTemplate.Height = 29;
      this.verbindungenDataGridView.Size = new System.Drawing.Size(786, 188);
      this.verbindungenDataGridView.TabIndex = 5;
      // 
      // DepartTimeColumn
      // 
      this.DepartTimeColumn.HeaderText = "Abfahrtszeit";
      this.DepartTimeColumn.MinimumWidth = 6;
      this.DepartTimeColumn.Name = "DepartTimeColumn";
      this.DepartTimeColumn.ReadOnly = true;
      this.DepartTimeColumn.Width = 125;
      // 
      // PlatformColumn
      // 
      this.PlatformColumn.HeaderText = "Gleis";
      this.PlatformColumn.MinimumWidth = 6;
      this.PlatformColumn.Name = "PlatformColumn";
      this.PlatformColumn.ReadOnly = true;
      this.PlatformColumn.Width = 125;
      // 
      // FromTrainstationColumn
      // 
      this.FromTrainstationColumn.HeaderText = "Von";
      this.FromTrainstationColumn.MinimumWidth = 6;
      this.FromTrainstationColumn.Name = "FromTrainstationColumn";
      this.FromTrainstationColumn.ReadOnly = true;
      this.FromTrainstationColumn.Width = 125;
      // 
      // ToTrainstationColumn
      // 
      this.ToTrainstationColumn.HeaderText = "Nach";
      this.ToTrainstationColumn.MinimumWidth = 6;
      this.ToTrainstationColumn.Name = "ToTrainstationColumn";
      this.ToTrainstationColumn.ReadOnly = true;
      this.ToTrainstationColumn.Width = 125;
      // 
      // ArrivalTimeColumn
      // 
      this.ArrivalTimeColumn.HeaderText = "Ankunftszeit";
      this.ArrivalTimeColumn.MinimumWidth = 6;
      this.ArrivalTimeColumn.Name = "ArrivalTimeColumn";
      this.ArrivalTimeColumn.ReadOnly = true;
      this.ArrivalTimeColumn.Width = 125;
      // 
      // PlatformArrivalColumn
      // 
      this.PlatformArrivalColumn.HeaderText = "Gleis";
      this.PlatformArrivalColumn.MinimumWidth = 6;
      this.PlatformArrivalColumn.Name = "PlatformArrivalColumn";
      this.PlatformArrivalColumn.ReadOnly = true;
      this.PlatformArrivalColumn.Width = 125;
      // 
      // searchButton
      // 
      this.searchButton.Location = new System.Drawing.Point(358, 40);
      this.searchButton.Name = "searchButton";
      this.searchButton.Size = new System.Drawing.Size(187, 55);
      this.searchButton.TabIndex = 6;
      this.searchButton.Text = "Verbindungen suchen";
      this.searchButton.UseVisualStyleBackColor = true;
      this.searchButton.Click += new System.EventHandler(this.TestButton_Click);
      // 
      // testBox
      // 
      this.testBox.Location = new System.Drawing.Point(617, 23);
      this.testBox.Name = "testBox";
      this.testBox.Size = new System.Drawing.Size(125, 27);
      this.testBox.TabIndex = 7;
      // 
      // fromComboBox
      // 
      this.fromComboBox.AllowDrop = true;
      this.fromComboBox.FormattingEnabled = true;
      this.fromComboBox.Location = new System.Drawing.Point(2, 52);
      this.fromComboBox.Name = "fromComboBox";
      this.fromComboBox.Size = new System.Drawing.Size(163, 28);
      this.fromComboBox.TabIndex = 8;
      this.fromComboBox.Enter += new System.EventHandler(this.fromComboBox_Enter);
      this.fromComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FromKomboBox_KeyUp);
      this.fromComboBox.Leave += new System.EventHandler(this.fromComboBox_Leave);
      // 
      // toComboBox
      // 
      this.toComboBox.FormattingEnabled = true;
      this.toComboBox.Location = new System.Drawing.Point(171, 52);
      this.toComboBox.Name = "toComboBox";
      this.toComboBox.Size = new System.Drawing.Size(181, 28);
      this.toComboBox.TabIndex = 9;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.toComboBox);
      this.Controls.Add(this.fromComboBox);
      this.Controls.Add(this.testBox);
      this.Controls.Add(this.searchButton);
      this.Controls.Add(this.verbindungenDataGridView);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.selectionGroup);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.selectionGroup.ResumeLayout(false);
      this.selectionGroup.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.verbindungenDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private RadioButton verbindungenRButton;
    private GroupBox selectionGroup;
    private RadioButton karteRButton;
    private RadioButton abfahrtstafelRButton;
    private DateTimePicker dateTimePicker1;
    private BindingSource stationBindingSource;
    private DataGridView verbindungenDataGridView;
    private DataGridViewTextBoxColumn DepartTimeColumn;
    private DataGridViewTextBoxColumn PlatformColumn;
    private DataGridViewTextBoxColumn FromTrainstationColumn;
    private DataGridViewTextBoxColumn ToTrainstationColumn;
    private DataGridViewTextBoxColumn ArrivalTimeColumn;
    private DataGridViewTextBoxColumn PlatformArrivalColumn;
    private BindingSource bindingSource1;
    private Button searchButton;
    private TextBox testBox;
    private ComboBox fromComboBox;
    private ComboBox toComboBox;
  }
}