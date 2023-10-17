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
            textBox1 = new TextBox();
            create = new Button();
            calculate = new Button();
            trupmena = new CheckBox();
            Pakeitus = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)X_cord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)y_cord).BeginInit();
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
            X_text.Text = "X";
            X_text.TextAlign = HorizontalAlignment.Center;
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
            Y_text.Text = "Y";
            Y_text.TextAlign = HorizontalAlignment.Center;
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
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(483, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(176, 16);
            textBox1.TabIndex = 11;
            textBox1.Text = "* Visi langai turi buti uzpildyti\r\n";
            textBox1.TextChanged += textBox1_TextChanged_1;
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
            // 
            // Pakeitus
            // 
            Pakeitus.BackColor = SystemColors.Control;
            Pakeitus.BorderStyle = BorderStyle.None;
            Pakeitus.ForeColor = Color.Red;
            Pakeitus.Location = new Point(251, 458);
            Pakeitus.Name = "Pakeitus";
            Pakeitus.ReadOnly = true;
            Pakeitus.Size = new Size(414, 16);
            Pakeitus.TabIndex = 10;
            Pakeitus.Text = "* Pakeitus pasirinkimus arba matricos dydi pernauja sukurti matrica";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = Color.Red;
            textBox2.Location = new Point(15, 345);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(176, 16);
            textBox2.TabIndex = 12;
            textBox2.Text = "* Didziausias x ir y verte 10";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.ForeColor = Color.Red;
            textBox3.Location = new Point(483, 94);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(176, 16);
            textBox3.TabIndex = 13;
            textBox3.Text = "* Rezultatai rasomi i konsole";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 491);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Pakeitus);
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
        private TextBox Pakeitus;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}