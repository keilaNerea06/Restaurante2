namespace Restaurante2
{
    partial class frmMenuComida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            textBox3 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Location = new Point(208, 229);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 1;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 192);
            button3.Location = new Point(517, 210);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 2;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(494, 120);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(494, 164);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 41);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 11;
            label1.Text = "MENU";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.LightGray;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = Color.MediumOrchid;
            dataGridView2.Location = new Point(74, 58);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(351, 167);
            dataGridView2.TabIndex = 14;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(494, 76);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(43, 23);
            textBox3.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(12, 303);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(494, 58);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 17;
            label2.Text = "id_Plato";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(494, 103);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 18;
            label3.Text = "Nombre plato";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(494, 147);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 19;
            label4.Text = "Monto";
            label4.Click += label4_Click;
            // 
            // frmMenuComida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(700, 338);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMenuComida";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView2;
        private TextBox textBox3;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}