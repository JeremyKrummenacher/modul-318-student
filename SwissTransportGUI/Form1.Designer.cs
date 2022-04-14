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
            this.moreConnections = new System.Windows.Forms.Button();
            this.emailBtn = new System.Windows.Forms.Button();
            this.nachComboBox = new System.Windows.Forms.ComboBox();
            this.vonComboBox = new System.Windows.Forms.ComboBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.btnVerbindungAnzeigen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nachLabel = new System.Windows.Forms.Label();
            this.vonLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.bahnhof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.aufkarteBtn = new System.Windows.Forms.Button();
            this.stationcomboBox = new System.Windows.Forms.ComboBox();
            this.abfahrtensuchen = new System.Windows.Forms.Button();
            this.Fahrplan.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.verbindungenBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
            this.gleis.HeaderText = "Gleis/Kante";
            this.gleis.Name = "gleis";
            // 
            // verbindungenBox
            // 
            this.verbindungenBox.Controls.Add(this.moreConnections);
            this.verbindungenBox.Controls.Add(this.emailBtn);
            this.verbindungenBox.Controls.Add(this.nachComboBox);
            this.verbindungenBox.Controls.Add(this.vonComboBox);
            this.verbindungenBox.Controls.Add(this.timePicker);
            this.verbindungenBox.Controls.Add(this.btnVerbindungAnzeigen);
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
            // moreConnections
            // 
            this.moreConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.moreConnections.Location = new System.Drawing.Point(688, 191);
            this.moreConnections.Name = "moreConnections";
            this.moreConnections.Size = new System.Drawing.Size(212, 33);
            this.moreConnections.TabIndex = 7;
            this.moreConnections.Text = "weitere Verbindungen sehen";
            this.moreConnections.UseVisualStyleBackColor = true;
            this.moreConnections.Click += new System.EventHandler(this.moreConnections_Click);
            // 
            // emailBtn
            // 
            this.emailBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.emailBtn.Location = new System.Drawing.Point(231, 171);
            this.emailBtn.Name = "emailBtn";
            this.emailBtn.Size = new System.Drawing.Size(143, 40);
            this.emailBtn.TabIndex = 6;
            this.emailBtn.Text = "Teilen 📧";
            this.emailBtn.UseVisualStyleBackColor = true;
            this.emailBtn.Click += new System.EventHandler(this.emailBtn_Click);
            // 
            // nachComboBox
            // 
            this.nachComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nachComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nachComboBox.FormattingEnabled = true;
            this.nachComboBox.Location = new System.Drawing.Point(427, 39);
            this.nachComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nachComboBox.Name = "nachComboBox";
            this.nachComboBox.Size = new System.Drawing.Size(252, 28);
            this.nachComboBox.TabIndex = 2;
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
            this.vonComboBox.TabIndex = 0;
            this.vonComboBox.TextUpdate += new System.EventHandler(this.Vorschlage);
            // 
            // timePicker
            // 
            this.timePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timePicker.Location = new System.Drawing.Point(427, 103);
            this.timePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(93, 27);
            this.timePicker.TabIndex = 4;
            // 
            // btnVerbindungAnzeigen
            // 
            this.btnVerbindungAnzeigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVerbindungAnzeigen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerbindungAnzeigen.Location = new System.Drawing.Point(18, 171);
            this.btnVerbindungAnzeigen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVerbindungAnzeigen.Name = "btnVerbindungAnzeigen";
            this.btnVerbindungAnzeigen.Size = new System.Drawing.Size(207, 40);
            this.btnVerbindungAnzeigen.TabIndex = 5;
            this.btnVerbindungAnzeigen.Text = "Verbindungen anzeigen";
            this.btnVerbindungAnzeigen.UseVisualStyleBackColor = true;
            this.btnVerbindungAnzeigen.Click += new System.EventHandler(this.btnVerbindungenAnzeigen_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.dateTimePicker1.TabIndex = 3;
            // 
            // nachLabel
            // 
            this.nachLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(906, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Station-Abfahrtspan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nummer,
            this.name});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 199);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(900, 364);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nach";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // nummer
            // 
            this.nummer.HeaderText = "Zug Nr.";
            this.nummer.Name = "nummer";
            // 
            // name
            // 
            this.name.HeaderText = "Operator";
            this.name.Name = "name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.aufkarteBtn);
            this.groupBox1.Controls.Add(this.stationcomboBox);
            this.groupBox1.Controls.Add(this.abfahrtensuchen);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Station suchen";
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bahnhof,
            this.distanz});
            this.dataGridView3.Location = new System.Drawing.Point(624, 45);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(259, 150);
            this.dataGridView3.TabIndex = 5;
            // 
            // bahnhof
            // 
            this.bahnhof.HeaderText = "Bahnhof";
            this.bahnhof.Name = "bahnhof";
            // 
            // distanz
            // 
            this.distanz.HeaderText = "Distanz";
            this.distanz.Name = "distanz";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(624, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Die nächst gelegene Station suchen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // aufkarteBtn
            // 
            this.aufkarteBtn.Location = new System.Drawing.Point(18, 78);
            this.aufkarteBtn.Name = "aufkarteBtn";
            this.aufkarteBtn.Size = new System.Drawing.Size(259, 28);
            this.aufkarteBtn.TabIndex = 3;
            this.aufkarteBtn.Text = "Station auf der Karte sehen";
            this.aufkarteBtn.UseVisualStyleBackColor = true;
            this.aufkarteBtn.Click += new System.EventHandler(this.aufkarteBtn_Click);
            // 
            // stationcomboBox
            // 
            this.stationcomboBox.FormattingEnabled = true;
            this.stationcomboBox.Location = new System.Drawing.Point(18, 44);
            this.stationcomboBox.Name = "stationcomboBox";
            this.stationcomboBox.Size = new System.Drawing.Size(259, 28);
            this.stationcomboBox.TabIndex = 1;
            this.stationcomboBox.TextUpdate += new System.EventHandler(this.VorschlageStation);
            // 
            // abfahrtensuchen
            // 
            this.abfahrtensuchen.Location = new System.Drawing.Point(283, 45);
            this.abfahrtensuchen.Name = "abfahrtensuchen";
            this.abfahrtensuchen.Size = new System.Drawing.Size(154, 27);
            this.abfahrtensuchen.TabIndex = 2;
            this.abfahrtensuchen.Text = "suche Abfahrten";
            this.abfahrtensuchen.UseVisualStyleBackColor = true;
            this.abfahrtensuchen.Click += new System.EventHandler(this.abfahrtensuchen_Click);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyTransportation";
            this.Load += new System.EventHandler(this.MyTransportation_Load);
            this.Fahrplan.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.verbindungenBox.ResumeLayout(false);
            this.verbindungenBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
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
        private Button btnVerbindungAnzeigen;
        private DataGridView dataGridView1;
        private DateTimePicker timePicker;
        private ComboBox vonComboBox;
        private ComboBox nachComboBox;
        private GroupBox groupBox1;
        private DataGridView dataGridView2;
        private Button abfahrtensuchen;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nummer;
        private DataGridViewTextBoxColumn name;
        private ComboBox stationcomboBox;
        private Button aufkarteBtn;
        private Button button2;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn bahnhof;
        private DataGridViewTextBoxColumn distanz;
        private DataGridViewTextBoxColumn Von;
        private DataGridViewTextBoxColumn Nach;
        private DataGridViewTextBoxColumn abfahrt;
        private DataGridViewTextBoxColumn ankunft;
        private DataGridViewTextBoxColumn gleis;
        private Button emailBtn;
        private Button moreConnections;
    }
}