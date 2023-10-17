
using System.Collections;
using System.Drawing.Drawing2D;
using System.Security.Cryptography.X509Certificates;
using MathNet.Numerics.LinearAlgebra;
using System;
using Fractions;
using MathNet.Numerics;
using System.Text.RegularExpressions;

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
            if (tikrinimas == 0)
            {

                metodailist.Add(new metodai { tekstas = "Pasirinkti", pasirinkimas = 0 });
                metodailist.Add(new metodai { tekstas = "Gauso Metodas", pasirinkimas = 1 });
                metodailist.Add(new metodai { tekstas = "Pagrindinio elemento Metodas", pasirinkimas = 2 });
                metodailist.Add(new metodai { tekstas = "iteraciniai sprendimo metodai", pasirinkimas = 3 });
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
            flowLayoutPanel1.Controls.Clear();
        }
        private void Method_SelectedIndexChanged(object sender, EventArgs e)
        {


           
            if (Method.SelectedValue.ToString() == "1")
            {
                Sarasai(1);
            }
            if (Method.SelectedValue.ToString() == "2")
            {
                Sarasai(2);
            }   
            if (Method.SelectedValue.ToString() == "3")
            {
                Sarasai(3);
            }
            flowLayoutPanel1.Controls.Clear();




        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            
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
            x = (int)X_cord.Value;
            y = (int)y_cord.Value;
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
                    
                   
                    TextBox c = new TextBox();
                    c.Size = new Size(33, 23);
                    c.Text = "b";
                    c.ReadOnly = true;
                    c.BorderStyle = BorderStyle.None;
                    c.TextAlign = HorizontalAlignment.Center;

                    flowLayoutPanel1.Controls.Add(c);
                    
                    flowLayoutPanel1.SetFlowBreak(c, true);

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
                            TextBox g = new TextBox();
                             g.Size = new Size(33, 23);
                             g.Name = (i + 2).ToString() + (x + 2).ToString();
                              flowLayoutPanel1.Controls.Add(g);
                              flowLayoutPanel1.SetFlowBreak(g, true);




                    }
                    break;
            }


        }
        
        private void calculate_Click(object sender, EventArgs e)
        {
            
           
            string[,] matrica = new string[11, 11];
            string[,] matrica2 = new string[11, 11];
            if (Goal.SelectedValue.ToString() == "1")
            {


                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {

                        matrica[i, j] = flowLayoutPanel1.Controls.Find((i + 1).ToString() + (j + 1).ToString(), true)[0].Text;


                    }
                    matrica2[i, 0] = flowLayoutPanel1.Controls.Find((i + 1).ToString() + (x + 1).ToString(), true)[0].Text;
                }

            }
            if (Method.SelectedValue.ToString() == "2")
            {


                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x - 1; j++)
                    {

                        matrica[i, j] = flowLayoutPanel1.Controls.Find((i + 1).ToString() + (j + 1).ToString(), true)[0].Text;


                    }
                    matrica2[i, 0] = flowLayoutPanel1.Controls.Find((i + 1).ToString() + (x).ToString(), true)[0].Text;
                }

            }
            else
            {


                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {

                        matrica[i, j] = flowLayoutPanel1.Controls.Find((i + 1).ToString() + (j + 1).ToString(), true)[0].Text;

                    }
                }
            }

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

            if (Method.SelectedValue.ToString() == "2")
            {

                x = x - 1;
            }
            double[,] matrica_double = new double[y, x];
            double[,] matrica_double2 = new double[y, 1];

            for (int i = 0; i < y; i++)
            {

                for (int j = 0; j < x; j++)
                {

                    matrica_double[i, j] = Convert.ToDouble(matrica[i, j]);
                    //Console.WriteLine(matrica_double[i,j]);


                }
                matrica_double2[i, 0] = Convert.ToDouble(matrica2[i, 0]);
                //Console.WriteLine(matrica_double2[i, 0]);
                //Console.WriteLine("LN");
            }
            var A = Matrix<double>.Build.DenseOfArray(matrica_double);
            var B = Matrix<double>.Build.DenseOfArray(matrica_double2);
             Console.WriteLine(A);
            // Console.WriteLine(" MATRIX A");
            // Console.WriteLine(B);
            //  Console.WriteLine(" MATRIX B");
            //A.Solve(B);
            //  Console.WriteLine(A.Solve(B));
            //   var determinant = A.Determinant();
            //  Console.WriteLine(determinant);
           
            //var D = A.Inverse();
            // Console.WriteLine(D);
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
            if (Method.SelectedValue.ToString() == "2")
            {

                x = x + 1;
            }





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
    }
}