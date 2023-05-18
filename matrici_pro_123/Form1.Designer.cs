namespace matrici_pro_123
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
            dataGridView1 = new DataGridView();
            Visualize_Matrix_1 = new Button();
            Razmer_Matrici = new TextBox();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            GetValuesFromData = new Button();
            Matrix_Sum = new Button();
            dataGridView3 = new DataGridView();
            Multiply_Button = new Button();
            Transposition_Button_1 = new Button();
            Transposition_Button_2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(212, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(421, 235);
            dataGridView1.TabIndex = 0;
            // 
            // Visualize_Matrix_1
            // 
            Visualize_Matrix_1.Location = new Point(12, 61);
            Visualize_Matrix_1.Name = "Visualize_Matrix_1";
            Visualize_Matrix_1.Size = new Size(161, 33);
            Visualize_Matrix_1.TabIndex = 1;
            Visualize_Matrix_1.Text = "Сгенерировать матрицы";
            Visualize_Matrix_1.UseVisualStyleBackColor = true;
            Visualize_Matrix_1.Click += Visualize_Matrix_1_Click;
            // 
            // Razmer_Matrici
            // 
            Razmer_Matrici.Location = new Point(12, 32);
            Razmer_Matrici.Name = "Razmer_Matrici";
            Razmer_Matrici.Size = new Size(161, 23);
            Razmer_Matrici.TabIndex = 2;
            Razmer_Matrici.Text = "3";
            Razmer_Matrici.TextChanged += Razmer_Matrici_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 3;
            label1.Text = "Укажите размер матрицы";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(708, 12);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(421, 235);
            dataGridView2.TabIndex = 4;
            // 
            // GetValuesFromData
            // 
            GetValuesFromData.Location = new Point(12, 100);
            GetValuesFromData.Name = "GetValuesFromData";
            GetValuesFromData.Size = new Size(161, 33);
            GetValuesFromData.TabIndex = 5;
            GetValuesFromData.Text = "Взять данные из таблицы";
            GetValuesFromData.UseVisualStyleBackColor = true;
            GetValuesFromData.Click += GetValuesFromData_Click;
            // 
            // Matrix_Sum
            // 
            Matrix_Sum.Location = new Point(12, 139);
            Matrix_Sum.Name = "Matrix_Sum";
            Matrix_Sum.Size = new Size(161, 33);
            Matrix_Sum.TabIndex = 6;
            Matrix_Sum.Text = "Суммировать матрицы";
            Matrix_Sum.UseVisualStyleBackColor = true;
            Matrix_Sum.Click += Matrix_Sum_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(471, 272);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(421, 235);
            dataGridView3.TabIndex = 7;
            // 
            // Multiply_Button
            // 
            Multiply_Button.Location = new Point(12, 178);
            Multiply_Button.Name = "Multiply_Button";
            Multiply_Button.Size = new Size(161, 33);
            Multiply_Button.TabIndex = 8;
            Multiply_Button.Text = "Перемножить матрицы";
            Multiply_Button.UseVisualStyleBackColor = true;
            Multiply_Button.Click += Multiply_Button_Click;
            // 
            // Transposition_Button_1
            // 
            Transposition_Button_1.Location = new Point(12, 217);
            Transposition_Button_1.Name = "Transposition_Button_1";
            Transposition_Button_1.Size = new Size(161, 43);
            Transposition_Button_1.TabIndex = 9;
            Transposition_Button_1.Text = "Транспонировать 1ую матрицу";
            Transposition_Button_1.UseVisualStyleBackColor = true;
            Transposition_Button_1.Click += Transposition_Button_1_Click;
            // 
            // Transposition_Button_2
            // 
            Transposition_Button_2.Location = new Point(12, 266);
            Transposition_Button_2.Name = "Transposition_Button_2";
            Transposition_Button_2.Size = new Size(161, 43);
            Transposition_Button_2.TabIndex = 10;
            Transposition_Button_2.Text = "Транспонировать 2ую матрицу";
            Transposition_Button_2.UseVisualStyleBackColor = true;
            Transposition_Button_2.Click += Transposition_Button_2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 547);
            Controls.Add(Transposition_Button_2);
            Controls.Add(Transposition_Button_1);
            Controls.Add(Multiply_Button);
            Controls.Add(dataGridView3);
            Controls.Add(Matrix_Sum);
            Controls.Add(GetValuesFromData);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(Razmer_Matrici);
            Controls.Add(Visualize_Matrix_1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Visualize_Matrix_1;
        private TextBox Razmer_Matrici;
        private Label label1;
        private DataGridView dataGridView2;
        private Button GetValuesFromData;
        private Button Matrix_Sum;
        private DataGridView dataGridView3;
        private Button Multiply_Button;
        private Button Transposition_Button_1;
        private Button Transposition_Button_2;
    }
}