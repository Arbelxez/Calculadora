namespace Calculadora
{
    public partial class Calculator : Form

    {
        Double first;
        Double second;
        string operador;
        public Calculator()
        {
            InitializeComponent();
        }

        Classes.ClsSum Obj = new Classes.ClsSum();
        Classes.ClsRest Obj2 = new Classes.ClsRest();
        Classes.ClsMultiplication Obj3 = new Classes.ClsMultiplication();
        Classes.ClsDivision Obj4 = new Classes.ClsDivision();


        private void But0_Click_1(object sender, EventArgs e)
        {
            if (TbScreen.Text != "0")
            {
                if (TbScreen.Text == "Error")
                {
                    TbScreen.Clear();
                    TbScreen.Text = TbScreen.Text + "0";

                }
                else
                {
                    TbScreen.Text = TbScreen.Text + "0";

                }
            }
        }

        private void But1_Click(object sender, EventArgs e)
        {
            if (TbScreen.Text != "0")
            {
                if (TbScreen.Text == "Error")
                {
                    TbScreen.Clear();
                    TbScreen.Text = TbScreen.Text + "1";

                }
                else
                {
                    TbScreen.Text = TbScreen.Text + "1";

                }
            }
            else
            {
                TbScreen.Clear();
                TbScreen.Text = TbScreen.Text + "1";
            }
        }

        private void But2_Click(object sender, EventArgs e)
        {
            if (TbScreen.Text != "0")
            {
                if (TbScreen.Text == "Error")
                {
                    TbScreen.Clear();
                    TbScreen.Text = TbScreen.Text + "2";

                }
                else
                {
                    TbScreen.Text = TbScreen.Text + "2";

                }
            }
            else
            {
                TbScreen.Clear();
                TbScreen.Text = TbScreen.Text + "2";
            }
        }

        private void But3_Click(object sender, EventArgs e)
        {
            if (TbScreen.Text != "0")
            {
                if (TbScreen.Text == "Error")
                {
                    TbScreen.Clear();
                    TbScreen.Text = TbScreen.Text + "3";

                }
                else
                {
                    TbScreen.Text = TbScreen.Text + "3";

                }
            }
            else
            {
                TbScreen.Clear();
                TbScreen.Text = TbScreen.Text + "3";
            }
        }

        private void But4_Click(object sender, EventArgs e)
        {
            if (TbScreen.Text != "0")
            {
                if (TbScreen.Text == "Error")
                {
                    TbScreen.Clear();
                    TbScreen.Text = TbScreen.Text + "4";

                }
                else
                {
                    TbScreen.Text = TbScreen.Text + "4";

                }
            }
            else
            {
                TbScreen.Clear();
                TbScreen.Text = TbScreen.Text + "4";
            }
        }

        private void But5_Click(object sender, EventArgs e)
        {
            if (TbScreen.Text != "0")
            {
                if (TbScreen.Text == "Error")
                {
                    TbScreen.Clear();
                    TbScreen.Text = TbScreen.Text + "5";

                }
                else
                {
                    TbScreen.Text = TbScreen.Text + "5";

                }
            }
            else
            {
                TbScreen.Clear();
                TbScreen.Text = TbScreen.Text + "5";
            }
        }

        private void But6_Click(object sender, EventArgs e)
        {
            if (TbScreen.Text != "0")
            {
                if (TbScreen.Text == "Error")
                {
                    TbScreen.Clear();
                    TbScreen.Text = TbScreen.Text + "6";

                }
                else
                {
                    TbScreen.Text = TbScreen.Text + "6";

                }
            }
            else
            {
                TbScreen.Clear();
                TbScreen.Text = TbScreen.Text + "6";
            }
        }

        private void But7_Click(object sender, EventArgs e)
        {
            if (TbScreen.Text != "0")
            {
                if (TbScreen.Text == "Error")
                {
                    TbScreen.Clear();
                    TbScreen.Text = TbScreen.Text + "7";

                }
                else
                {
                    TbScreen.Text = TbScreen.Text + "7";

                }
            }
            else
            {
                TbScreen.Clear();
                TbScreen.Text = TbScreen.Text + "7";
            }
        }

        private void But8_Click(object sender, EventArgs e)
        {
            if (TbScreen.Text != "0")
            {
                if (TbScreen.Text == "Error")
                {
                    TbScreen.Clear();
                    TbScreen.Text = TbScreen.Text + "8";

                }
                else
                {
                    TbScreen.Text = TbScreen.Text + "8";

                }
            }
            else
            {
                TbScreen.Clear();
                TbScreen.Text = TbScreen.Text + "8";
            }
        }

        private void But9_Click(object sender, EventArgs e)
        {
            if (TbScreen.Text != "0")
            {
                if (TbScreen.Text == "Error")
                {
                    TbScreen.Clear();
                    TbScreen.Text = TbScreen.Text + "9";

                }
                else
                {
                    TbScreen.Text = TbScreen.Text + "9";

                }
            }
            else
            {
                TbScreen.Clear();
                TbScreen.Text = TbScreen.Text + "9";
            }
        }

        private void ButPoint_Click(object sender, EventArgs e)
        {
            string text = TbScreen.Text;
            char lastDigit = text[text.Length - 1];
            bool containsCharacter = text.IndexOf('.') >= 0;

            if (containsCharacter || lastDigit == '.')
            {
                TbScreen.Text += "";
            }
            else
            {
                TbScreen.Text += (text != "") ? "." : "0.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButSum_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "+";
                first = double.Parse(TbScreen.Text);
                TbScreen.Clear();
            }
            catch(Exception error)
            {
                if (TbScreen.Text.Length < 5)
                {
                    TbScreen.Text = TbScreen.Text + "Error";
                }
            }
        }

        private void ButRest_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "-";
                first = double.Parse(TbScreen.Text);
                TbScreen.Clear();
            }catch(Exception error)
            {
                if (TbScreen.Text.Length < 5)
                {
                    TbScreen.Text = TbScreen.Text + "Error";

                }
            }
        }

        private void ButDivision_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "/";
                first = double.Parse(TbScreen.Text);
                TbScreen.Clear();
            }catch(Exception error)
            {
                if(TbScreen.Text.Length < 5)
                {
                    TbScreen.Text = TbScreen.Text + "Error";

                }
            }
        }
        private void ButMultiplication_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "*";
                first = double.Parse(TbScreen.Text);
                TbScreen.Clear();
            }catch (Exception error) {
                if( TbScreen.Text.Length < 5)
                {
                    TbScreen.Text = TbScreen.Text + "Error";
                }
            }
        }

        private void ButEqual_Click_1(object sender, EventArgs e)
        {
            second = double.Parse(TbScreen.Text);

            double SUM;
            double RES;
            double MUL;
            double DIV;

            switch (operador)
            {
                case "+":
                    SUM = Obj.Sumar((first), (second));
                    TbScreen.Text = SUM.ToString();
                    break;
                case "-":
                    RES = Obj2.Restar((first), (second));
                    TbScreen.Text = RES.ToString();
                    break;
                case "*":
                    MUL = Obj3.Multiplicar((first), (second));
                    TbScreen.Text = MUL.ToString();
                    break;
                case "/":
                    DIV = Obj4.Dividir((first), (second));
                    TbScreen.Text = DIV.ToString();
                    break;
            }

        }

        private void ButCE_Click(object sender, EventArgs e)
        {
            if (TbScreen.Text.Length >= 1)
            {
                TbScreen.Clear();
            }
        }

        private void ButDelete_Click(object sender, EventArgs e)
        {
            if (TbScreen.Text.Length >= 1)
            {
                if (TbScreen.Text.Length == 1)
                {
                    TbScreen.Text = "";
                }
                else
                {
                    TbScreen.Text = TbScreen.Text.Substring(0, TbScreen.Text.Length - 1);
                }
            }

        }


    }
}