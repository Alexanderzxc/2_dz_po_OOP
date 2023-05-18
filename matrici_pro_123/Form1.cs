using System.Drawing.Drawing2D;

namespace matrici_pro_123
{
    public partial class Form1 : Form
    {
        MyMatrix matrixVisual1;
        MyMatrix matrixVisual2;
        MyMatrix matrixResult;

        public Form1()
        {
            InitializeComponent();
            Razmer_Matrici.Text = "3";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Visualize_Matrix_1_Click(object sender, EventArgs e)
        {
            matrixVisual1 = new MyMatrix(Convert.ToInt32(Razmer_Matrici.Text));
            matrixVisual2 = new MyMatrix(Convert.ToInt32(Razmer_Matrici.Text));
            matrixVisual1.GenerateMatrix();
            matrixVisual2.GenerateMatrix();
            matrixVisual1.FillMatrix(dataGridView1);
            matrixVisual2.FillMatrix(dataGridView2);
        }

        private void GetValuesFromData_Click(object sender, EventArgs e)
        {
            matrixVisual1.GetValueFromDataGribView(dataGridView1);
            matrixVisual2.GetValueFromDataGribView(dataGridView2);
        }

        private void Razmer_Matrici_TextChanged(object sender, EventArgs e)
        {
            try
            {
                matrixVisual1 = new MyMatrix(Convert.ToInt32(Razmer_Matrici.Text));
                matrixVisual2 = new MyMatrix(Convert.ToInt32(Razmer_Matrici.Text));
            }
            catch
            {
                MessageBox.Show("Неправильный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Razmer_Matrici.Text = null;
            }
        }

        private void Matrix_Sum_Click(object sender, EventArgs e)
        {
            matrixResult = matrixVisual1.Sum(matrixVisual2);
            matrixResult.FillMatrix(dataGridView3);
        }

        private void Multiply_Button_Click(object sender, EventArgs e)
        {
            matrixResult = matrixVisual1.Multiply(matrixVisual2);
            matrixResult.FillMatrix(dataGridView3);
        }

        private void Transposition_Button_1_Click(object sender, EventArgs e)
        {
            matrixResult = matrixVisual1.Transposition();
            matrixResult.FillMatrix(dataGridView3);
        }

        private void Transposition_Button_2_Click(object sender, EventArgs e)
        {
            matrixResult = matrixVisual2.Transposition();
            matrixResult.FillMatrix(dataGridView3);
        }
    }
}