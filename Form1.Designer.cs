namespace Matricav2
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
            X_cord = new NumericUpDown();
            y_cord = new NumericUpDown();
            X_text = new TextBox();
            Y_text = new TextBox();
            Method = new ComboBox();
            Goal = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lygtis = new TextBox();
            ispejimas1 = new TextBox();
            create = new Button();
            calculate = new Button();
            trupmena = new CheckBox();
            ispejimas_pakeitus = new TextBox();
            ispejimas2 = new TextBox();
            ispejimas3 = new TextBox();
            ispejimas4 = new TextBox();
            max = new TextBox();
            min = new TextBox();
            Min_text = new TextBox();
            Max_text = new TextBox();
            lygtis2 = new TextBox();
            interpol_ix3 = new TextBox();
            interpol_ix1 = new TextBox();
            interpol_ix2 = new TextBox();
            interpol_iy1 = new TextBox();
            interpol_iy2 = new TextBox();
            interpol_iy3 = new TextBox();
            interpol_y = new TextBox();
            interpol_x = new TextBox();
            interpol_1 = new TextBox();
            interpol_2 = new TextBox();
            interpol_3 = new TextBox();
            interpol_ix4 = new TextBox();
            interpol_4 = new TextBox();
            interpolgroup = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)X_cord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)y_cord).BeginInit();
            interpolgroup.SuspendLayout();
            SuspendLayout();
            // 
            // X_cord
            // 
            X_cord.BackColor = SystemColors.Window;
            X_cord.Location = new Point(12, 397);
            X_cord.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            X_cord.Name = "X_cord";
            X_cord.ReadOnly = true;
            X_cord.Size = new Size(33, 23);
            X_cord.TabIndex = 0;
            X_cord.TabStop = false;
            X_cord.Visible = false;
            X_cord.ValueChanged += X_cord_ValueChanged;
            // 
            // y_cord
            // 
            y_cord.BackColor = SystemColors.Window;
            y_cord.Location = new Point(51, 397);
            y_cord.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            y_cord.Name = "y_cord";
            y_cord.ReadOnly = true;
            y_cord.Size = new Size(33, 23);
            y_cord.TabIndex = 1;
            y_cord.TabStop = false;
            y_cord.Visible = false;
            y_cord.ValueChanged += y_cord_ValueChanged;
            // 
            // X_text
            // 
            X_text.BackColor = SystemColors.Control;
            X_text.BorderStyle = BorderStyle.None;
            X_text.Location = new Point(15, 370);
            X_text.Name = "X_text";
            X_text.ReadOnly = true;
            X_text.Size = new Size(15, 16);
            X_text.TabIndex = 2;
            X_text.TabStop = false;
            X_text.Text = "X";
            X_text.TextAlign = HorizontalAlignment.Center;
            X_text.Visible = false;
            X_text.TextChanged += textBox1_TextChanged;
            // 
            // Y_text
            // 
            Y_text.BackColor = SystemColors.Control;
            Y_text.BorderStyle = BorderStyle.None;
            Y_text.Location = new Point(51, 370);
            Y_text.Name = "Y_text";
            Y_text.ReadOnly = true;
            Y_text.Size = new Size(15, 16);
            Y_text.TabIndex = 3;
            Y_text.TabStop = false;
            Y_text.Text = "Y";
            Y_text.TextAlign = HorizontalAlignment.Center;
            Y_text.Visible = false;
            // 
            // Method
            // 
            Method.DropDownStyle = ComboBoxStyle.DropDownList;
            Method.FormattingEnabled = true;
            Method.Location = new Point(12, 426);
            Method.Name = "Method";
            Method.Size = new Size(223, 23);
            Method.TabIndex = 4;
            Method.SelectedIndexChanged += Method_SelectedIndexChanged;
            // 
            // Goal
            // 
            Goal.DropDownStyle = ComboBoxStyle.DropDownList;
            Goal.FormattingEnabled = true;
            Goal.Location = new Point(12, 455);
            Goal.Name = "Goal";
            Goal.Size = new Size(223, 23);
            Goal.TabIndex = 5;
            Goal.SelectedIndexChanged += Goal_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(15, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(462, 327);
            flowLayoutPanel1.TabIndex = 6;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // lygtis
            // 
            lygtis.Anchor = AnchorStyles.None;
            lygtis.Location = new Point(51, 46);
            lygtis.Name = "lygtis";
            lygtis.Size = new Size(195, 23);
            lygtis.TabIndex = 14;
            lygtis.Visible = false;
            // 
            // ispejimas1
            // 
            ispejimas1.BackColor = SystemColors.Control;
            ispejimas1.BorderStyle = BorderStyle.None;
            ispejimas1.ForeColor = Color.Red;
            ispejimas1.Location = new Point(483, 12);
            ispejimas1.Name = "ispejimas1";
            ispejimas1.ReadOnly = true;
            ispejimas1.Size = new Size(176, 16);
            ispejimas1.TabIndex = 11;
            ispejimas1.TabStop = false;
            ispejimas1.Text = "* Visi langai turi buti uzpildyti\r\n";
            ispejimas1.Visible = false;
            ispejimas1.TextChanged += textBox1_TextChanged_1;
            // 
            // create
            // 
            create.Location = new Point(90, 397);
            create.Name = "create";
            create.Size = new Size(75, 23);
            create.TabIndex = 7;
            create.Text = "Sukurti";
            create.UseVisualStyleBackColor = true;
            create.Click += create_Click;
            // 
            // calculate
            // 
            calculate.Location = new Point(171, 397);
            calculate.Name = "calculate";
            calculate.Size = new Size(75, 23);
            calculate.TabIndex = 8;
            calculate.Text = "Skaiciuoti";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // trupmena
            // 
            trupmena.AutoSize = true;
            trupmena.Location = new Point(251, 428);
            trupmena.Name = "trupmena";
            trupmena.Size = new Size(150, 19);
            trupmena.TabIndex = 9;
            trupmena.Text = "Atvirkstine Trupmenom";
            trupmena.UseVisualStyleBackColor = true;
            trupmena.Visible = false;
            // 
            // ispejimas_pakeitus
            // 
            ispejimas_pakeitus.BackColor = SystemColors.Control;
            ispejimas_pakeitus.BorderStyle = BorderStyle.None;
            ispejimas_pakeitus.ForeColor = Color.Red;
            ispejimas_pakeitus.Location = new Point(251, 458);
            ispejimas_pakeitus.Name = "ispejimas_pakeitus";
            ispejimas_pakeitus.ReadOnly = true;
            ispejimas_pakeitus.Size = new Size(414, 16);
            ispejimas_pakeitus.TabIndex = 10;
            ispejimas_pakeitus.Text = "* Pakeitus pasirinkimus arba matricos dydi pernauja sukurti matrica";
            ispejimas_pakeitus.Visible = false;
            // 
            // ispejimas2
            // 
            ispejimas2.BackColor = SystemColors.Control;
            ispejimas2.BorderStyle = BorderStyle.None;
            ispejimas2.ForeColor = Color.Red;
            ispejimas2.Location = new Point(15, 345);
            ispejimas2.Name = "ispejimas2";
            ispejimas2.ReadOnly = true;
            ispejimas2.Size = new Size(176, 16);
            ispejimas2.TabIndex = 12;
            ispejimas2.TabStop = false;
            ispejimas2.Text = "* Didziausias x ir y verte 10";
            ispejimas2.Visible = false;
            // 
            // ispejimas3
            // 
            ispejimas3.BackColor = SystemColors.Control;
            ispejimas3.BorderStyle = BorderStyle.None;
            ispejimas3.ForeColor = Color.Red;
            ispejimas3.Location = new Point(483, 94);
            ispejimas3.Name = "ispejimas3";
            ispejimas3.ReadOnly = true;
            ispejimas3.Size = new Size(176, 16);
            ispejimas3.TabIndex = 13;
            ispejimas3.TabStop = false;
            ispejimas3.Text = "* Rezultatai rasomi i konsole";
            ispejimas3.Visible = false;
            // 
            // ispejimas4
            // 
            ispejimas4.BackColor = SystemColors.Control;
            ispejimas4.BorderStyle = BorderStyle.None;
            ispejimas4.ForeColor = Color.Red;
            ispejimas4.Location = new Point(483, 53);
            ispejimas4.Name = "ispejimas4";
            ispejimas4.ReadOnly = true;
            ispejimas4.Size = new Size(176, 16);
            ispejimas4.TabIndex = 15;
            ispejimas4.TabStop = false;
            ispejimas4.Text = "*Pvz: a^3+3*a^2-3";
            ispejimas4.Visible = false;
            ispejimas4.TextChanged += ispejimas4_TextChanged;
            // 
            // max
            // 
            max.Location = new Point(90, 116);
            max.Name = "max";
            max.Size = new Size(35, 23);
            max.TabIndex = 16;
            max.Visible = false;
            // 
            // min
            // 
            min.Location = new Point(51, 116);
            min.Name = "min";
            min.Size = new Size(33, 23);
            min.TabIndex = 17;
            min.Visible = false;
            // 
            // Min_text
            // 
            Min_text.BackColor = SystemColors.Control;
            Min_text.BorderStyle = BorderStyle.None;
            Min_text.Location = new Point(51, 94);
            Min_text.Name = "Min_text";
            Min_text.ReadOnly = true;
            Min_text.Size = new Size(33, 16);
            Min_text.TabIndex = 18;
            Min_text.TabStop = false;
            Min_text.Text = "Min";
            Min_text.TextAlign = HorizontalAlignment.Center;
            Min_text.Visible = false;
            // 
            // Max_text
            // 
            Max_text.BackColor = SystemColors.Control;
            Max_text.BorderStyle = BorderStyle.None;
            Max_text.Location = new Point(90, 94);
            Max_text.Name = "Max_text";
            Max_text.ReadOnly = true;
            Max_text.Size = new Size(35, 16);
            Max_text.TabIndex = 19;
            Max_text.TabStop = false;
            Max_text.Text = "Max";
            Max_text.TextAlign = HorizontalAlignment.Center;
            Max_text.Visible = false;
            // 
            // lygtis2
            // 
            lygtis2.Anchor = AnchorStyles.None;
            lygtis2.Location = new Point(252, 46);
            lygtis2.Name = "lygtis2";
            lygtis2.Size = new Size(225, 23);
            lygtis2.TabIndex = 20;
            lygtis2.Visible = false;
            // 
            // interpol_ix3
            // 
            interpol_ix3.Location = new Point(157, 43);
            interpol_ix3.Name = "interpol_ix3";
            interpol_ix3.Size = new Size(56, 23);
            interpol_ix3.TabIndex = 21;
            // 
            // interpol_ix1
            // 
            interpol_ix1.Location = new Point(33, 43);
            interpol_ix1.Name = "interpol_ix1";
            interpol_ix1.Size = new Size(56, 23);
            interpol_ix1.TabIndex = 22;
            // 
            // interpol_ix2
            // 
            interpol_ix2.Location = new Point(95, 43);
            interpol_ix2.Name = "interpol_ix2";
            interpol_ix2.Size = new Size(56, 23);
            interpol_ix2.TabIndex = 23;
            // 
            // interpol_iy1
            // 
            interpol_iy1.Location = new Point(33, 72);
            interpol_iy1.Name = "interpol_iy1";
            interpol_iy1.Size = new Size(56, 23);
            interpol_iy1.TabIndex = 24;
            // 
            // interpol_iy2
            // 
            interpol_iy2.Location = new Point(95, 72);
            interpol_iy2.Name = "interpol_iy2";
            interpol_iy2.Size = new Size(56, 23);
            interpol_iy2.TabIndex = 25;
            // 
            // interpol_iy3
            // 
            interpol_iy3.Location = new Point(157, 72);
            interpol_iy3.Name = "interpol_iy3";
            interpol_iy3.Size = new Size(56, 23);
            interpol_iy3.TabIndex = 26;
            // 
            // interpol_y
            // 
            interpol_y.BackColor = SystemColors.Control;
            interpol_y.BorderStyle = BorderStyle.None;
            interpol_y.Location = new Point(12, 75);
            interpol_y.Name = "interpol_y";
            interpol_y.ReadOnly = true;
            interpol_y.Size = new Size(15, 16);
            interpol_y.TabIndex = 27;
            interpol_y.TabStop = false;
            interpol_y.Text = "Y";
            interpol_y.TextAlign = HorizontalAlignment.Center;
            // 
            // interpol_x
            // 
            interpol_x.AcceptsTab = true;
            interpol_x.BackColor = SystemColors.Control;
            interpol_x.BorderStyle = BorderStyle.None;
            interpol_x.Location = new Point(13, 43);
            interpol_x.Name = "interpol_x";
            interpol_x.ReadOnly = true;
            interpol_x.Size = new Size(15, 16);
            interpol_x.TabIndex = 28;
            interpol_x.TabStop = false;
            interpol_x.Text = "X";
            interpol_x.TextAlign = HorizontalAlignment.Center;
            // 
            // interpol_1
            // 
            interpol_1.BackColor = SystemColors.Control;
            interpol_1.BorderStyle = BorderStyle.None;
            interpol_1.Location = new Point(54, 21);
            interpol_1.Name = "interpol_1";
            interpol_1.ReadOnly = true;
            interpol_1.Size = new Size(15, 16);
            interpol_1.TabIndex = 29;
            interpol_1.TabStop = false;
            interpol_1.Text = "1";
            interpol_1.TextAlign = HorizontalAlignment.Center;
            // 
            // interpol_2
            // 
            interpol_2.BackColor = SystemColors.Control;
            interpol_2.BorderStyle = BorderStyle.None;
            interpol_2.Location = new Point(115, 21);
            interpol_2.Name = "interpol_2";
            interpol_2.ReadOnly = true;
            interpol_2.Size = new Size(15, 16);
            interpol_2.TabIndex = 30;
            interpol_2.TabStop = false;
            interpol_2.Text = "2";
            interpol_2.TextAlign = HorizontalAlignment.Center;
            // 
            // interpol_3
            // 
            interpol_3.BackColor = SystemColors.Control;
            interpol_3.BorderStyle = BorderStyle.None;
            interpol_3.Location = new Point(174, 21);
            interpol_3.Name = "interpol_3";
            interpol_3.ReadOnly = true;
            interpol_3.Size = new Size(15, 16);
            interpol_3.TabIndex = 31;
            interpol_3.TabStop = false;
            interpol_3.Text = "3";
            interpol_3.TextAlign = HorizontalAlignment.Center;
            // 
            // interpol_ix4
            // 
            interpol_ix4.Location = new Point(219, 43);
            interpol_ix4.Name = "interpol_ix4";
            interpol_ix4.Size = new Size(56, 23);
            interpol_ix4.TabIndex = 32;
            // 
            // interpol_4
            // 
            interpol_4.BackColor = SystemColors.Control;
            interpol_4.BorderStyle = BorderStyle.None;
            interpol_4.Location = new Point(236, 21);
            interpol_4.Name = "interpol_4";
            interpol_4.ReadOnly = true;
            interpol_4.Size = new Size(15, 16);
            interpol_4.TabIndex = 33;
            interpol_4.TabStop = false;
            interpol_4.Text = "4";
            interpol_4.TextAlign = HorizontalAlignment.Center;
            // 
            // interpolgroup
            // 
            interpolgroup.Controls.Add(interpol_ix2);
            interpolgroup.Controls.Add(interpol_4);
            interpolgroup.Controls.Add(interpol_ix3);
            interpolgroup.Controls.Add(interpol_ix4);
            interpolgroup.Controls.Add(interpol_ix1);
            interpolgroup.Controls.Add(interpol_3);
            interpolgroup.Controls.Add(interpol_iy1);
            interpolgroup.Controls.Add(interpol_2);
            interpolgroup.Controls.Add(interpol_iy2);
            interpolgroup.Controls.Add(interpol_1);
            interpolgroup.Controls.Add(interpol_iy3);
            interpolgroup.Controls.Add(interpol_x);
            interpolgroup.Controls.Add(interpol_y);
            interpolgroup.Location = new Point(51, 46);
            interpolgroup.Name = "interpolgroup";
            interpolgroup.Size = new Size(286, 120);
            interpolgroup.TabIndex = 34;
            interpolgroup.TabStop = false;
            interpolgroup.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 491);
            Controls.Add(interpolgroup);
            Controls.Add(lygtis2);
            Controls.Add(Max_text);
            Controls.Add(Min_text);
            Controls.Add(min);
            Controls.Add(max);
            Controls.Add(ispejimas4);
            Controls.Add(lygtis);
            Controls.Add(ispejimas3);
            Controls.Add(ispejimas2);
            Controls.Add(ispejimas1);
            Controls.Add(ispejimas_pakeitus);
            Controls.Add(trupmena);
            Controls.Add(calculate);
            Controls.Add(create);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Goal);
            Controls.Add(Method);
            Controls.Add(Y_text);
            Controls.Add(X_text);
            Controls.Add(y_cord);
            Controls.Add(X_cord);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)X_cord).EndInit();
            ((System.ComponentModel.ISupportInitialize)y_cord).EndInit();
            interpolgroup.ResumeLayout(false);
            interpolgroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown X_cord;
        private NumericUpDown y_cord;
        private TextBox X_text;
        private TextBox Y_text;
        private ComboBox Method;
        private ComboBox Goal;
        private TextBox Patikrinimas;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button create;
        private Button calculate;
        private CheckBox trupmena;
        private TextBox ispejimas_pakeitus;
        private TextBox ispejimas1;
        private TextBox ispejimas2;
        private TextBox ispejimas3;
        private TextBox lygtis;
        private TextBox ispejimas4;
        private TextBox max;
        private TextBox min;
        private TextBox Min_text;
        private TextBox Max_text;
        private TextBox lygtis2;
        private TextBox interpol_ix3;
        private TextBox interpol_ix1;
        private TextBox interpol_ix2;
        private TextBox interpol_iy1;
        private TextBox interpol_iy2;
        private TextBox interpol_iy3;
        private TextBox interpol_y;
        private TextBox interpol_x;
        private TextBox interpol_1;
        private TextBox interpol_2;
        private TextBox interpol_3;
        private TextBox interpol_ix4;
        private TextBox interpol_4;
        private GroupBox interpolgroup;
    }
}