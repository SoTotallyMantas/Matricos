
using System.Collections;
using System.Drawing.Drawing2D;
using System.Security.Cryptography.X509Certificates;
using MathNet.Numerics.LinearAlgebra;
using System;
using Fractions;
using MathNet.Numerics;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;
using MathNet.Numerics.LinearAlgebra.Solvers;
using MathNet.Numerics.LinearAlgebra.Factorization;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra.Double.Solvers;
using MathNet.Symbolics;
using MathNet.Numerics.RootFinding;
using static Microsoft.FSharp.Core.ByRefKinds;
using NCalc;
using System.Diagnostics;
using MathNet.Numerics.Interpolation;

namespace Matricav2
{
    public partial class Form1 : Form
    {
        private int x;
        private int y;

        public Form1()
        {
            InitializeComponent();

        }

        private void X_cord_ValueChanged(object sender, EventArgs e)
        {

        }

        private void y_cord_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {


            Sarasai(0);

        }
        private void Sarasai(int tikrinimas)
        {
            var metodailist = new List<metodai>();
            var Gausolist = new List<Gauso>();
            var iteraciniailist = new List<Gauso>();
            var netiesiniailist = new List<Gauso>();
            var interpoliavimaslist = new List<Gauso>();
            if (tikrinimas == 0)
            {

                metodailist.Add(new metodai { tekstas = "Pasirinkti", pasirinkimas = 0 });
                metodailist.Add(new metodai { tekstas = "Gauso Metodas", pasirinkimas = 1 });
                metodailist.Add(new metodai { tekstas = "Pagrindinio elemento Metodas", pasirinkimas = 2 });
                metodailist.Add(new metodai { tekstas = "iteraciniai sprendimo metodai", pasirinkimas = 3 });
                metodailist.Add(new metodai { tekstas = "Netiesiniø lygèiø metodai", pasirinkimas = 4 });
                metodailist.Add(new metodai { tekstas = "Interpoliavimas", pasirinkimas = 5 });
                Method.DataSource = metodailist;
                Method.DisplayMember = "tekstas";
                Method.ValueMember = "pasirinkimas";

                Goal.Enabled = false;
            }
            else
            {
                switch (tikrinimas)
                {
                    case 1:
                        Gausolist.Add(new Gauso { tekstas = "Pasirinkti", pasirinkimas = 0 });
                        Gausolist.Add(new Gauso { tekstas = "neþinomøjø eliminavimas", pasirinkimas = 1 });
                        Gausolist.Add(new Gauso { tekstas = "Determinantas", pasirinkimas = 2 });
                        Gausolist.Add(new Gauso { tekstas = "atvirkðtinë matrica", pasirinkimas = 3 });
                        Goal.DataSource = Gausolist;
                        Goal.DisplayMember = "tekstas";
                        Goal.ValueMember = "pasirinkimas";
                        Goal.Enabled = true;
                        Goal.SelectedIndex = 0;
                        break;
                    case 2:

                        Goal.Enabled = false;
                        break;
                    case 3:
                        iteraciniailist.Add(new Gauso { tekstas = "Pasirinkti", pasirinkimas = 0 });
                        iteraciniailist.Add(new Gauso { tekstas = "nuosekliø artiniø metodas", pasirinkimas = 1 });
                        iteraciniailist.Add(new Gauso { tekstas = "zeidelio metodas", pasirinkimas = 2 });
                        Goal.DataSource = iteraciniailist;
                        Goal.DisplayMember = "tekstas";
                        Goal.ValueMember = "pasirinkimas";
                        Goal.Enabled = true;
                        Goal.SelectedIndex = 0;
                        break;
                    case 4:
                        netiesiniailist.Add(new Gauso { tekstas = "Pasirinkti", pasirinkimas = 0 });
                        netiesiniailist.Add(new Gauso { tekstas = "Bandymu metodas", pasirinkimas = 1 });
                        netiesiniailist.Add(new Gauso { tekstas = "Kirstiniu metodas", pasirinkimas = 2 });
                        netiesiniailist.Add(new Gauso { tekstas = "Niutono  metodas", pasirinkimas = 3 });
                        Goal.DataSource = netiesiniailist;
                        Goal.DisplayMember = "tekstas";
                        Goal.ValueMember = "pasirinkimas";
                        Goal.Enabled = true;
                        Goal.SelectedIndex = 0;
                        break;
                    case 5:
                        interpoliavimaslist.Add(new Gauso { tekstas = "Pasirinkti", pasirinkimas = 0 });
                        interpoliavimaslist.Add(new Gauso { tekstas = "Tiesinis", pasirinkimas = 1 });
                        interpoliavimaslist.Add(new Gauso { tekstas = "Kvadratinis", pasirinkimas = 2 });
                        Goal.DataSource = interpoliavimaslist;
                        Goal.DisplayMember = "tekstas";
                        Goal.ValueMember = "pasirinkimas";
                        Goal.Enabled = true;
                        Goal.SelectedIndex = 0;
                        break;
                    default:
                        Goal.Enabled = false;

                        break;
                }
            }

        }


        class metodai
        {
            public string tekstas { get; set; }

            public int pasirinkimas { get; set; }
        }
        class Gauso
        {
            public string tekstas { get; set; }

            public int pasirinkimas { get; set; }
        }

        private void Patikrinimas_TextChanged(object sender, EventArgs e)
        {

        }

        private void Goal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Method.SelectedValue.ToString() != "3")
            {
                flowLayoutPanel1.Controls.Clear();
            }
            if (Method.SelectedValue.ToString() == "4")
            {
                switch (Goal.SelectedValue.ToString())
                {
                    case "1":
                        lygtis.Visible = true;
                        ispejimas4.Visible = true;
                        lygtis2.Visible = false;
                        min.Visible = true;
                        max.Visible = true;
                        Min_text.Visible = true;
                        Max_text.Visible = true;
                        accuracy.Visible = true;
                        epsilon.Visible = true;

                        break;
                    case "2":
                        lygtis.Visible = true;
                        lygtis2.Visible = false;
                        ispejimas4.Visible = true;
                        min.Visible = true;
                        max.Visible = true;
                        Min_text.Visible = true;
                        Max_text.Visible = true;
                        accuracy.Visible = true;
                        epsilon.Visible = true;

                        break;
                    case "3":
                        lygtis.Visible = true;
                        lygtis2.Visible = false;
                        ispejimas4.Visible = true;
                        min.Visible = true;
                        max.Visible = true;
                        Min_text.Visible = true;
                        Max_text.Visible = true;
                        accuracy.Visible = true;
                        epsilon.Visible = true;

                        break;
                }

            }
            if (Method.SelectedValue.ToString() == "5")
            {
                switch (Goal.SelectedValue.ToString())
                {
                    case "1":
                        interpol_iy3.Visible = false;
                        interpol_ix4.Visible = false;
                        interpol_4.Visible = false;
                        break;

                    case "2":
                        interpol_iy3.Visible = true;
                        interpol_ix4.Visible = true;
                        interpol_4.Visible = true;
                        break;

                }
            }
        }
        private void Method_SelectedIndexChanged(object sender, EventArgs e)
        {

            braizimolinkas.Visible = false;
            if (Method.SelectedValue.ToString() == "0")
            {
                Sarasai(0);
                create.Enabled = false;
                lygtis.Visible = false;
                lygtis2.Visible = false;
                ispejimas1.Visible = false;
                ispejimas2.Visible = false;
                ispejimas3.Visible = false;
                ispejimas4.Visible = false;
                X_cord.Visible = false;
                y_cord.Visible = false;
                Y_text.Visible = false;
                X_text.Visible = false;
                min.Visible = false;
                max.Visible = false;
                Min_text.Visible = false;
                Max_text.Visible = false;
                interpolgroup.Visible = false;
                accuracy.Visible = false;
                epsilon.Visible = false;

                flowLayoutPanel1.Controls.Clear();

            }
            if (Method.SelectedValue.ToString() == "1")
            {
                Sarasai(1);
                create.Enabled = true;
                lygtis.Visible = false;
                lygtis2.Visible = false;
                ispejimas1.Visible = true;
                ispejimas2.Visible = true;
                ispejimas3.Visible = true;
                ispejimas4.Visible = false;
                X_cord.Visible = true;
                y_cord.Visible = true;
                X_text.Visible = true;
                Y_text.Visible = true;
                min.Visible = false;
                max.Visible = false;
                Min_text.Visible = false;
                Max_text.Visible = false;
                accuracy.Visible = false;
                epsilon.Visible = false;
                interpolgroup.Visible = false;
            }
            if (Method.SelectedValue.ToString() == "2")
            {
                Sarasai(2);
                create.Enabled = true;
                lygtis.Visible = false;
                lygtis2.Visible = false;
                ispejimas1.Visible = true;
                ispejimas2.Visible = true;
                ispejimas3.Visible = true;
                ispejimas4.Visible = false;
                X_cord.Visible = true;
                y_cord.Visible = true;
                X_text.Visible = true;
                Y_text.Visible = true;
                min.Visible = false;
                max.Visible = false;
                Min_text.Visible = false;
                Max_text.Visible = false;
                interpolgroup.Visible = false;
                accuracy.Visible = false;
                epsilon.Visible = false;
                flowLayoutPanel1.Controls.Clear();
            }
            if (Method.SelectedValue.ToString() == "3")
            {
                Sarasai(3);
                create.Enabled = true;
                lygtis.Visible = false;
                lygtis2.Visible = false;
                ispejimas1.Visible = true;
                ispejimas2.Visible = true;
                ispejimas3.Visible = true;
                ispejimas4.Visible = false;
                X_cord.Visible = true;
                y_cord.Visible = true;
                X_text.Visible = true;
                Y_text.Visible = true;
                min.Visible = false;
                max.Visible = false;
                Min_text.Visible = false;
                Max_text.Visible = false;
                interpolgroup.Visible = false;
                accuracy.Visible = false;
                epsilon.Visible = false;
            }
            if (Method.SelectedValue.ToString() == "4")
            {
                Sarasai(4);
                create.Enabled = false;
                lygtis.Visible = false;
                lygtis2.Visible = false;
                ispejimas1.Visible = false;
                ispejimas2.Visible = false;
                ispejimas3.Visible = false;
                ispejimas4.Visible = false;
                X_cord.Visible = false;
                y_cord.Visible = false;
                X_text.Visible = false;
                Y_text.Visible = false;
                min.Visible = false;
                max.Visible = false;
                Min_text.Visible = false;
                Max_text.Visible = false;
                interpolgroup.Visible = false;
                accuracy.Visible = false;
                epsilon.Visible = false;
                braizimolinkas.Visible = true;
                flowLayoutPanel1.Controls.Clear();
            }
            if (Method.SelectedValue.ToString() == "5")
            {
                Sarasai(5);
                create.Enabled = false;
                lygtis.Visible = false;
                lygtis2.Visible = false;
                ispejimas1.Visible = false;
                ispejimas2.Visible = false;
                ispejimas3.Visible = false;
                ispejimas4.Visible = false;
                X_cord.Visible = false;
                y_cord.Visible = false;
                X_text.Visible = false;
                Y_text.Visible = false;
                min.Visible = false;
                max.Visible = false;
                Min_text.Visible = false;
                Max_text.Visible = false;
                interpolgroup.Visible = true;
                accuracy.Visible = false;
                epsilon.Visible = false;
                flowLayoutPanel1.Controls.Clear();
            }






        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            x = (int)X_cord.Value;
            y = (int)y_cord.Value;
            if (Method.SelectedValue.ToString() == "0")
            {
                MessageBox.Show(
                "Methodas nepasirinktas",
                "Klaida",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                   );
                return;
            }

            if (x != y)
            {
                MessageBox.Show(
                "Matrica turi buti kvadratine",
                "Klaida",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                   );
                return;
            }
            if (Method.SelectedIndex.ToString() != "2" && Goal.SelectedIndex.ToString() == "0")
            {

                MessageBox.Show(
                "Pasirinkimas neparinktas",
                "Klaida",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                   );
                return;

            }

            flowLayoutPanel1.Controls.Clear();

            switch (Method.SelectedValue.ToString())
            {
                case "1":
                    switch (Goal.SelectedValue.ToString())
                    {
                        case "1":

                            for (int i = 0; i < x; i++)
                            {
                                TextBox a = new TextBox();
                                a.Size = new Size(33, 23);
                                a.ReadOnly = true;
                                a.BorderStyle = BorderStyle.None;
                                a.TextAlign = HorizontalAlignment.Center;
                                a.Text = "a" + (i + 1).ToString();
                                flowLayoutPanel1.Controls.Add(a);
                                if (i + 1 == x && Goal.SelectedValue.ToString() != "1")
                                {
                                    flowLayoutPanel1.SetFlowBreak(a, true);
                                }
                            }
                            TextBox l = new TextBox();
                            l.Size = new Size(33, 23);
                            l.Text = "ln";
                            l.ReadOnly = true;
                            l.BorderStyle = BorderStyle.None;
                            l.TextAlign = HorizontalAlignment.Center;

                            flowLayoutPanel1.Controls.Add(l);

                            flowLayoutPanel1.SetFlowBreak(l, true);

                            for (int i = 0; i < y; i++)
                            {
                                for (int j = 0; j < x; j++)
                                {
                                    int name_text = (i + 1) * 10 + j + 1;
                                    TextBox a = new TextBox();
                                    a.Size = new Size(33, 23);
                                    a.Name = name_text.ToString();
                                    flowLayoutPanel1.Controls.Add(a);
                                    if (j + 1 == x && Goal.SelectedValue.ToString() != "1" && Method.SelectedValue.ToString() == "1")
                                    {
                                        flowLayoutPanel1.SetFlowBreak(a, true);
                                    }
                                }
                                if (Goal.SelectedValue.ToString() == "1")
                                {
                                    TextBox d = new TextBox();
                                    d.Size = new Size(33, 23);
                                    d.Name = (i + 1).ToString() + (x + 1).ToString();
                                    flowLayoutPanel1.Controls.Add(d);
                                    flowLayoutPanel1.SetFlowBreak(d, true);

                                }


                            }

                            break;
                        case "2":
                            for (int i = 0; i < x; i++)
                            {
                                TextBox a = new TextBox();
                                a.Size = new Size(33, 23);
                                a.ReadOnly = true;
                                a.BorderStyle = BorderStyle.None;
                                a.TextAlign = HorizontalAlignment.Center;
                                a.Text = "a" + (i + 1).ToString();
                                flowLayoutPanel1.Controls.Add(a);
                                if (i + 1 == x && Goal.SelectedValue.ToString() != "1")
                                {
                                    flowLayoutPanel1.SetFlowBreak(a, true);
                                }
                            }
                            for (int i = 0; i < y; i++)
                            {
                                for (int j = 0; j < x; j++)
                                {
                                    int name_text = (i + 1) * 10 + j + 1;
                                    TextBox a = new TextBox();
                                    a.Size = new Size(33, 23);
                                    a.Name = name_text.ToString();
                                    flowLayoutPanel1.Controls.Add(a);
                                    if (j + 1 == x && Goal.SelectedValue.ToString() != "1" && Method.SelectedValue.ToString() == "1")
                                    {
                                        flowLayoutPanel1.SetFlowBreak(a, true);
                                    }
                                }
                            }
                            break;
                        case "3":
                            for (int i = 0; i < x; i++)
                            {
                                TextBox a = new TextBox();
                                a.Size = new Size(33, 23);
                                a.ReadOnly = true;
                                a.BorderStyle = BorderStyle.None;
                                a.TextAlign = HorizontalAlignment.Center;
                                a.Text = "a" + (i + 1).ToString();
                                flowLayoutPanel1.Controls.Add(a);
                                if (i + 1 == x && Goal.SelectedValue.ToString() != "1")
                                {
                                    flowLayoutPanel1.SetFlowBreak(a, true);
                                }
                            }
                            for (int i = 0; i < y; i++)
                            {
                                for (int j = 0; j < x; j++)
                                {
                                    int name_text = (i + 1) * 10 + j + 1;
                                    TextBox a = new TextBox();
                                    a.Size = new Size(33, 23);
                                    a.Name = name_text.ToString();
                                    flowLayoutPanel1.Controls.Add(a);
                                    if (j + 1 == x && Goal.SelectedValue.ToString() != "1" && Method.SelectedValue.ToString() == "1")
                                    {
                                        flowLayoutPanel1.SetFlowBreak(a, true);
                                    }
                                }
                            }
                            break;

                    }
                    break;
                case "2":
                    for (int i = 0; i < x; i++)
                    {
                        TextBox a = new TextBox();
                        a.Size = new Size(33, 23);
                        a.ReadOnly = true;
                        a.BorderStyle = BorderStyle.None;
                        a.TextAlign = HorizontalAlignment.Center;
                        a.Text = "a" + (i + 1).ToString();
                        flowLayoutPanel1.Controls.Add(a);
                        if (i + 1 == x)
                        {
                            flowLayoutPanel1.SetFlowBreak(a, true);
                        }
                    }
                    for (int i = 0; i < y; i++)
                    {
                        for (int j = 0; j < x; j++)
                        {
                            int name_text = (i + 1) * 10 + j + 1;
                            TextBox a = new TextBox();
                            a.Size = new Size(33, 23);
                            a.Name = name_text.ToString();
                            flowLayoutPanel1.Controls.Add(a);
                            if (j + 1 == x)
                            {
                                flowLayoutPanel1.SetFlowBreak(a, true);
                            }
                        }
                    }
                    break;
                case "3":
                    for (int i = 0; i < x; i++)
                    {
                        TextBox a = new TextBox();
                        a.Size = new Size(33, 23);
                        a.ReadOnly = true;
                        a.BorderStyle = BorderStyle.None;
                        a.TextAlign = HorizontalAlignment.Center;
                        a.Text = "a" + (i + 1).ToString();
                        flowLayoutPanel1.Controls.Add(a);

                    }
                    TextBox b = new TextBox();
                    b.Size = new Size(33, 23);
                    b.Text = "x";
                    b.ReadOnly = true;
                    b.BorderStyle = BorderStyle.None;
                    b.TextAlign = HorizontalAlignment.Center;

                    flowLayoutPanel1.Controls.Add(b);




                    flowLayoutPanel1.SetFlowBreak(b, true);

                    for (int i = 0; i < y; i++)
                    {
                        for (int j = 0; j < x; j++)
                        {
                            int name_text = (i + 1) * 10 + j + 1;
                            TextBox a = new TextBox();
                            a.Size = new Size(33, 23);
                            a.Name = name_text.ToString();
                            flowLayoutPanel1.Controls.Add(a);

                        }

                        TextBox d = new TextBox();
                        d.Size = new Size(33, 23);
                        d.Name = (i + 1).ToString() + (x + 1).ToString();
                        flowLayoutPanel1.Controls.Add(d);

                        flowLayoutPanel1.SetFlowBreak(d, true);




                    }
                    break;
            }


        }

        private void calculate_Click(object sender, EventArgs e)
        {


            string[,] matrica = new string[11, 11];
            string[,] matrica2 = new string[11, 11];
            string[,] matrica3 = new string[11, 11];
            switch (Method.SelectedValue.ToString())
            {
                case "1":

                    switch (Goal.SelectedValue.ToString())
                    {
                        case "1":
                            for (int i = 0; i < y; i++)
                            {
                                for (int j = 0; j < x; j++)
                                {

                                    matrica[i, j] = flowLayoutPanel1.Controls.Find((i + 1).ToString() + (j + 1).ToString(), true)[0].Text;


                                }
                                matrica2[i, 0] = flowLayoutPanel1.Controls.Find((i + 1).ToString() + (x + 1).ToString(), true)[0].Text;
                            }
                            break;
                        case "2":
                            for (int i = 0; i < y; i++)
                            {
                                for (int j = 0; j < x; j++)
                                {

                                    matrica[i, j] = flowLayoutPanel1.Controls.Find((i + 1).ToString() + (j + 1).ToString(), true)[0].Text;

                                }
                            }
                            break;
                        case "3":
                            for (int i = 0; i < y; i++)
                            {
                                for (int j = 0; j < x; j++)
                                {

                                    matrica[i, j] = flowLayoutPanel1.Controls.Find((i + 1).ToString() + (j + 1).ToString(), true)[0].Text;

                                }
                            }

                            break;
                    }
                    break;
                case "2":
                    for (int i = 0; i < y; i++)
                    {
                        for (int j = 0; j < x - 1; j++)
                        {

                            matrica[i, j] = flowLayoutPanel1.Controls.Find((i + 1).ToString() + (j + 1).ToString(), true)[0].Text;


                        }
                        matrica2[i, 0] = flowLayoutPanel1.Controls.Find((i + 1).ToString() + (x).ToString(), true)[0].Text;
                    }
                    break;

                case "3":
                    for (int i = 0; i < y; i++)
                    {
                        for (int j = 0; j < x; j++)
                        {

                            matrica[i, j] = flowLayoutPanel1.Controls.Find((i + 1).ToString() + (j + 1).ToString(), true)[0].Text;


                        }
                        matrica2[i, 0] = flowLayoutPanel1.Controls.Find((i + 1).ToString() + (x + 1).ToString(), true)[0].Text;

                    }
                    break;

            }




            /*
            for (int i = 0; i < y; i++)
            {
                if (Method.SelectedValue.ToString() == "2")
                {
                    for (int j = 0; j < x - 1; j++)
                    {
                        if (matrica[i, j].Contains('/'))
                        {
                            matrica[i, j] = FractionToDouble(matrica[i, j]).ToString();

                        }
                    }
                }
                else
                    for (int j = 0; j < x; j++)
                    {
                        if (matrica[i, j].Contains('/'))
                        {
                            matrica[i, j] = FractionToDouble(matrica[i, j]).ToString();

                        }


                    }
                if (Goal.SelectedValue.ToString() == "1" || Method.SelectedValue.ToString() == "2")
                {
                    if (matrica2[i, 0].Contains('/'))
                    {
                        matrica2[i, 0] = FractionToDouble(matrica2[i, 0]).ToString();
                    }
                }
            }
            */
            double[,] matrica_double = new double[y, x];
            double[,] matrica_double2 = new double[y, 1];
            double[] matrica_double3 = new double[y];
            double[] matrica_double4 = new double[y];




            switch (Method.SelectedValue.ToString())
            {
                case "1":

                    switch (Goal.SelectedValue.ToString())
                    {
                        case "1":
                            for (int i = 0; i < y; i++)
                            {

                                for (int j = 0; j < x; j++)
                                {

                                    matrica_double[i, j] = Convert.ToDouble(matrica[i, j]);



                                }
                                matrica_double2[i, 0] = Convert.ToDouble(matrica2[i, 0]);

                            }
                            break;
                        case "2":
                            for (int i = 0; i < y; i++)
                            {

                                for (int j = 0; j < x; j++)
                                {

                                    matrica_double[i, j] = Convert.ToDouble(matrica[i, j]);



                                }
                                matrica_double2[i, 0] = Convert.ToDouble(matrica2[i, 0]);

                            }
                            break;
                        case "3":
                            for (int i = 0; i < y; i++)
                            {

                                for (int j = 0; j < x; j++)
                                {

                                    matrica_double[i, j] = Convert.ToDouble(matrica[i, j]);



                                }
                                matrica_double2[i, 0] = Convert.ToDouble(matrica2[i, 0]);

                            }

                            break;
                    }
                    break;
                case "2":
                    for (int i = 0; i < y; i++)
                    {

                        for (int j = 0; j < x - 1; j++)
                        {

                            matrica_double[i, j] = Convert.ToDouble(matrica[i, j]);



                        }
                        matrica_double2[i, 0] = Convert.ToDouble(matrica2[i, 0]);

                    }
                    break;

                case "3":
                    for (int i = 0; i < y; i++)
                    {

                        for (int j = 0; j < x; j++)
                        {

                            matrica_double[i, j] = Convert.ToDouble(matrica[i, j]);



                        }
                        matrica_double3[i] = Convert.ToDouble(matrica2[i, 0]);
                        matrica_double4[i] = Convert.ToDouble(matrica3[i, 0]);

                    }
                    break;

            }
            var A = Matrix<double>.Build.DenseOfArray(matrica_double);
            var B = Matrix<double>.Build.DenseOfArray(matrica_double2);
            Vector<double> C = Vector<double>.Build.DenseOfArray(matrica_double3);
            Vector<double> G = Vector<double>.Build.DenseOfArray(matrica_double4);
            var metodo_patikra = Method.SelectedValue.ToString();
            if (Convert.ToDouble(metodo_patikra.ToString()) < 4)
            {

                //Console.WriteLine(A);
                // Console.WriteLine(B);
                // Console.WriteLine(C);
                //Console.WriteLine(G);
            }
            switch (Method.SelectedValue.ToString())
            {
                case "1":

                    switch (Goal.SelectedValue.ToString())
                    {
                        case "1":
                            Console.WriteLine("Gauso metodas");
                            Console.WriteLine(A.Solve(B));
                            break;
                        case "2":
                            Console.WriteLine("Determinantas");
                            var determinant = A.Determinant();
                            Console.WriteLine(determinant);
                            break;
                        case "3":
                            Console.WriteLine("Atvirkstine matrica");
                            var D = A.Inverse();
                            for (int i = 0; i < y; i++)
                            {
                                // matrica_test[i] = ;
                                for (int j = 0; j < x; j++)
                                {
                                    D[i, j] = Math.Round(D[i, j], 3);
                                    if (D[i, j] == -0)
                                    {
                                        D[i, j] = 0;
                                    }
                                }
                            }
                            Console.WriteLine(D);
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine("Pagrindinio elemento metodas");
                    Console.WriteLine(A.Solve(B));
                    break;

                case "3":

                    IIterativeSolver<double> solver = new TFQMR();
                    IPreconditioner<double> DiagonalPreconditioner = new DiagonalPreconditioner();
                    Iterator<double> iter = new Iterator<double>();
                    var O = C;
                    try
                    {
                        O = A.SolveIterative(C, solver, iter, DiagonalPreconditioner);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Failed");
                    }
                    Console.WriteLine("Iteracijos sprendinis");
                    var O_size = O.Count;
                    for (int i = 0; i <= O_size - 1; i++)
                    {
                        Console.WriteLine(O[i].ToString("F4"));
                    }


                    break;

                case "4":
                    var a = SymbolicExpression.Variable("x");

                    //Func<double, double> test = y => y * y * y + 3 * y * y - 3;

                    // var root = Bisection.FindRootExpand(test,0,2);
                    // 
                    // Console.WriteLine(root);
                    // Func<double, double> equation = y => Math.Pow(2, y);
                    // Func<double, double> equation2 = y => -5 * (y * y) + 3;
                    // root = NewtonRaphson.FindRoot(equation,equation2,1,0);
                    string funkcija = lygtis.Text;
                    String.Join(" ", funkcija.ToList());
                    SymbolicExpression expression = SymbolicExpression.Parse(funkcija);


                    //SymbolicExpression expression2 = SymbolicExpression.Parse(funkcija2);

                    SymbolicExpression expression2 = expression.Differentiate(a);
                    //Console.WriteLine(expression2.ToString());
                    //Console.WriteLine(derivative.ToString());

                    //Console.WriteLine("Isvestine");
                    //Console.WriteLine(isvestine);

                    // Func<double, double> function = l => isvestine;

                    // var root = FindRoots.OfFunction(function, 0, 10);
                    // Func<double, double> function = a => Convert.ToDouble(lygtis.Text);

                    
                    double min_double = 0;
                    double max_double = 0;
                    double acc = 0.001;
                    int decimalPlaces = 0;


                    try
                    {
                        min_double = Convert.ToDouble(min.Text);
                        max_double = Convert.ToDouble(max.Text);
                        acc = Convert.ToDouble(accuracy.Text);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Min , Max arba Epsilon langai nera uzpildyti");
                    }

                    int iterations = 30;
                    double root = 0;
                    var value = root;

                    //Console.WriteLine(function);
                    // a* a *a + 3 * a * a - 3;
                    switch (Goal.SelectedValue.ToString())
                    {
                        case "1":
                            Func<double, double> function2 = expression.Compile("x");
                            try
                            {
                                root = Bisection.FindRoot(function2, min_double, max_double, acc, iterations);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Failed");
                            }
                            //var root = Bisection.FindRoot(function, min_double, max_double);

                            value = root;
                            while (acc < 1)
                            {
                                acc *= 10;
                                decimalPlaces++;
                            }
                            Console.WriteLine(root.ToString("F" + decimalPlaces));
                            break;

                        case "2":

                            Func<double, double> function3 = expression.Compile("x");
                            Func<double, double> function4 = expression2.Compile("x");
                            try
                            {
                                root = RobustNewtonRaphson.FindRoot(function3, function4, min_double, max_double, acc, iterations);
                               
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Failed");
                            }
                            
                            //Console.WriteLine(root.ToString("F3"));
                            value = root;
                            while (acc < 1)
                            {
                                acc *= 10;
                                decimalPlaces++;
                            }
                            Console.WriteLine(root.ToString("F" + decimalPlaces));

                            break;

                        case "3":



                            Func<double, double> function5 = expression.Compile("x");
                            Func<double, double> function6 = expression2.Compile("x");
                            try
                            {
                                root = RobustNewtonRaphson.FindRoot(function5, function6, min_double, max_double, acc, iterations);
                                
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Failed");
                            }
                            
                            //Console.WriteLine(root.ToString("F3"));
                            value = root;
                            while (acc < 1)
                            {
                                acc *= 10;
                                decimalPlaces++;
                            }
                            Console.WriteLine(root.ToString("F" + decimalPlaces));
                            break;






                    }
                    break;
                case "5":

                    //Interpoliavimas
                    switch (Goal.SelectedValue.ToString())
                    {
                        case "2":

                            var ix1 = Convert.ToDouble(interpol_ix1.Text.ToString());
                            var ix2 = Convert.ToDouble(interpol_ix2.Text.ToString());
                            var ix3 = Convert.ToDouble(interpol_ix3.Text.ToString());
                            var iy1 = Convert.ToDouble(interpol_iy1.Text.ToString());
                            var iy2 = Convert.ToDouble(interpol_iy2.Text.ToString());
                            var iy3 = Convert.ToDouble(interpol_iy3.Text.ToString());
                            double xd = Convert.ToDouble(interpol_ix4.Text.ToString());
                            double[] iy = { iy1, iy2, iy3 };
                            Matrix<double> M = DenseMatrix.OfArray(new double[,]
                            {
                               { ix1 * ix1, ix1, 1 },
                               { ix2 * ix2, ix2, 1 },
                               { ix3 * ix3, ix3, 1 }
                             });
                            Vector<double> vectorY = Vector<double>.Build.Dense(iy);
                            Vector<double> koff = M.Solve(vectorY);


                            double a1 = koff[0];
                            double b1 = koff[1];
                            double c1 = koff[2];

                            double kvadratinterpoliavimas = (a1 * xd * xd) + (b1 * xd) + c1;
                            Console.WriteLine(kvadratinterpoliavimas.ToString("F3"));
                            break;

                        case "1":

                            ix1 = Convert.ToDouble(interpol_ix1.Text.ToString());
                            ix2 = Convert.ToDouble(interpol_ix2.Text.ToString());
                            iy1 = Convert.ToDouble(interpol_iy1.Text.ToString());
                            iy2 = Convert.ToDouble(interpol_iy2.Text.ToString());
                            xd = Convert.ToDouble(interpol_ix3.Text.ToString());
                            double tiesinisinterpol = iy1 + (xd - ix1) * (iy2 - iy1) / (ix2 - ix1);
                            Console.WriteLine(tiesinisinterpol.ToString("F3"));
                            break;

                    }
                    break;


            }
            /*
             if (Method.SelectedValue.ToString() == "1")
             {
                 if (Goal.SelectedValue.ToString() == "1")
                 {
                     Console.WriteLine("Gauso metodas");
                     Console.WriteLine(A.Solve(B));
                 }
                 if (Goal.SelectedValue.ToString() == "2")
                 {
                     Console.WriteLine("Determinantas");
                     var determinant = A.Determinant();
                     Console.WriteLine(determinant);
                 }
                 if (Goal.SelectedValue.ToString() == "3")
                 {
                     var D = A.Inverse();
                     if (trupmena.Checked == false)
                     {
                         Console.WriteLine("Atvirkstine matrica");

                         for (int i = 0; i < y; i++)
                         {
                             // matrica_test[i] = ;
                             for (int j = 0; j < x; j++)
                             {


                                 D[i, j] = Math.Round(D[i, j], 3);
                                 if (D[i, j] == -0)
                                 {
                                     D[i, j] = 0;
                                 }


                             }
                         }

                         Console.WriteLine(D);
                     }
                     else
                     {
                         Console.WriteLine("Atvirkstine matrica su Trupmena");
                         for (int i = 0; i < y; i++)
                         {

                             for (int j = 0; j < x; j++)
                             {


                                 D[i, j] = Math.Round(D[i, j], 3);
                                 var rounded = Fraction.FromDoubleRounded(D[i, j]);
                                 Console.Write(rounded);
                                 Console.Write(" ");
                             }
                             Console.WriteLine();
                         }
                     }

                 }
             }
             if (Method.SelectedValue.ToString() == "2")
             {
                 Console.WriteLine("Pagrindinio elemento metodas");
                 Console.WriteLine(A.Solve(B));
             }
            */






        }

        private static double FractionToDouble(string fraction)
        {
            double result;

            if (double.TryParse(fraction, out result))
            {
                return result;
            }

            string[] split = fraction.Split(new char[] { ' ', '/' });

            if (split.Length == 2 || split.Length == 3)
            {
                int a, b;

                if (int.TryParse(split[0], out a) && int.TryParse(split[1], out b))
                {
                    if (split.Length == 2)
                    {
                        return (double)a / b;
                    }

                    int c;

                    if (int.TryParse(split[2], out c))
                    {
                        return a + (double)b / c;
                    }
                }
            }

            throw new FormatException("Not a valid fraction.");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ispejimas4_TextChanged(object sender, EventArgs e)
        {

        }

        private void braizimolinkas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.mat.lt/irankiai/grafikas.html") { UseShellExecute = true });
        }
    }
}