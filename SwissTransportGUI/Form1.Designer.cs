namespace SwissTransportGUI
{
    partial class MyTransportation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyTransportation));
            this.Fahrplan = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Von = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verbindungenBox = new System.Windows.Forms.GroupBox();
            this.nachComboBox = new System.Windows.Forms.ComboBox();
            this.vonComboBox = new System.Windows.Forms.ComboBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nachLabel = new System.Windows.Forms.Label();
            this.vonLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Fahrplan.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.verbindungenBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fahrplan
            // 
            this.Fahrplan.Controls.Add(this.tabPage1);
            this.Fahrplan.Controls.Add(this.tabPage2);
            this.Fahrplan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fahrplan.Location = new System.Drawing.Point(0, 0);
            this.Fahrplan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Fahrplan.Name = "Fahrplan";
            this.Fahrplan.SelectedIndex = 0;
            this.Fahrplan.Size = new System.Drawing.Size(914, 600);
            this.Fahrplan.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.verbindungenBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(906, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fahrplan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Von,
            this.Nach,
            this.abfahrt,
            this.ankunft,
            this.gleis});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 228);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(900, 335);
            this.dataGridView1.TabIndex = 1;
            // 
            // Von
            // 
            this.Von.HeaderText = "Von";
            this.Von.Name = "Von";
            this.Von.Width = 343;
            // 
            // Nach
            // 
            this.Nach.HeaderText = "Nach";
            this.Nach.Name = "Nach";
            // 
            // abfahrt
            // 
            this.abfahrt.HeaderText = "Abfahrt";
            this.abfahrt.Name = "abfahrt";
            // 
            // ankunft
            // 
            this.ankunft.HeaderText = "Ankunft";
            this.ankunft.Name = "ankunft";
            // 
            // gleis
            // 
            this.gleis.HeaderText = "Gleis";
            this.gleis.Name = "gleis";
            // 
            // verbindungenBox
            // 
            this.verbindungenBox.Controls.Add(this.nachComboBox);
            this.verbindungenBox.Controls.Add(this.vonComboBox);
            this.verbindungenBox.Controls.Add(this.timePicker);
            this.verbindungenBox.Controls.Add(this.button1);
            this.verbindungenBox.Controls.Add(this.label2);
            this.verbindungenBox.Controls.Add(this.label1);
            this.verbindungenBox.Controls.Add(this.dateTimePicker1);
            this.verbindungenBox.Controls.Add(this.nachLabel);
            this.verbindungenBox.Controls.Add(this.vonLabel);
            this.verbindungenBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.verbindungenBox.Location = new System.Drawing.Point(3, 4);
            this.verbindungenBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.verbindungenBox.Name = "verbindungenBox";
            this.verbindungenBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.verbindungenBox.Size = new System.Drawing.Size(900, 224);
            this.verbindungenBox.TabIndex = 0;
            this.verbindungenBox.TabStop = false;
            this.verbindungenBox.Text = "Verbindungen anzeigen";
            // 
            // nachComboBox
            // 
            this.nachComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nachComboBox.FormattingEnabled = true;
            this.nachComboBox.Location = new System.Drawing.Point(427, 39);
            this.nachComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nachComboBox.Name = "nachComboBox";
            this.nachComboBox.Size = new System.Drawing.Size(252, 28);
            this.nachComboBox.TabIndex = 11;
            this.nachComboBox.TextUpdate += new System.EventHandler(this.VoerschlaegeNach);
            // 
            // vonComboBox
            // 
            this.vonComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vonComboBox.FormattingEnabled = true;
            this.vonComboBox.Location = new System.Drawing.Point(70, 39);
            this.vonComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vonComboBox.Name = "vonComboBox";
            this.vonComboBox.Size = new System.Drawing.Size(265, 28);
            this.vonComboBox.TabIndex = 10;
            this.vonComboBox.TextUpdate += new System.EventHandler(this.Vorschlage);
            // 
            // timePicker
            // 
            this.timePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timePicker.Location = new System.Drawing.Point(427, 103);
            this.timePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(93, 27);
            this.timePicker.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(18, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Verbindungen anzeigen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(364, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zeit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tag";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(70, 103);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 27);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // nachLabel
            // 
            this.nachLabel.AutoSize = true;
            this.nachLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nachLabel.Location = new System.Drawing.Point(364, 43);
            this.nachLabel.Name = "nachLabel";
            this.nachLabel.Size = new System.Drawing.Size(43, 20);
            this.nachLabel.TabIndex = 2;
            this.nachLabel.Text = "Nach";
            // 
            // vonLabel
            // 
            this.vonLabel.AutoSize = true;
            this.vonLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vonLabel.Location = new System.Drawing.Point(18, 40);
            this.vonLabel.Name = "vonLabel";
            this.vonLabel.Size = new System.Drawing.Size(34, 20);
            this.vonLabel.TabIndex = 0;
            this.vonLabel.Text = "Von";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(906, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stationssuche";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MyTransportation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.Fahrplan);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MyTransportation";
            this.Text = "MyTransportation";
            this.Load += new System.EventHandler(this.MyTransportation_Load);
            this.Fahrplan.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.verbindungenBox.ResumeLayout(false);
            this.verbindungenBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl Fahrplan;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox verbindungenBox;
        private Label nachLabel;
        private Label vonLabel;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private DateTimePicker timePicker;
        private DataGridViewTextBoxColumn Von;
        private DataGridViewTextBoxColumn Nach;
        private DataGridViewTextBoxColumn abfahrt;
        private DataGridViewTextBoxColumn ankunft;
        private DataGridViewTextBoxColumn gleis;
        private ComboBox vonComboBox;
        private ComboBox nachComboBox;
    }
}