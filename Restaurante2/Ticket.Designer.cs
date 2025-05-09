namespace Restaurante2
{
    partial class Ticket
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtIdTicket = new TextBox();
            txtIdPedido = new TextBox();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            txtMetodoPago = new TextBox();
            txtMonto = new TextBox();
            button4 = new Button();
            txtIdPedido1 = new TextBox();
            txtIdPlato = new TextBox();
            txtEstado = new TextBox();
            txtIdCamarero = new TextBox();
            txtCantidad = new TextBox();
            button5 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Location = new Point(223, 353);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 1;
            button1.Text = "eliminar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Location = new Point(223, 168);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 2;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 192);
            button3.Location = new Point(507, 168);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 3;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txtIdTicket
            // 
            txtIdTicket.Location = new Point(507, 80);
            txtIdTicket.Margin = new Padding(3, 2, 3, 2);
            txtIdTicket.Name = "txtIdTicket";
            txtIdTicket.Size = new Size(49, 23);
            txtIdTicket.TabIndex = 8;
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(589, 80);
            txtIdPedido.Margin = new Padding(3, 2, 3, 2);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(49, 23);
            txtIdPedido.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 223);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 11;
            label1.Text = "PEDIDO";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.LightGray;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(42, 51);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(439, 98);
            dataGridView2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 240);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(439, 98);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtMetodoPago
            // 
            txtMetodoPago.Location = new Point(507, 126);
            txtMetodoPago.Name = "txtMetodoPago";
            txtMetodoPago.Size = new Size(82, 23);
            txtMetodoPago.TabIndex = 14;
            txtMetodoPago.TextChanged += textBox3_TextChanged;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(606, 126);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(82, 23);
            txtMonto.TabIndex = 15;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 255, 192);
            button4.Location = new Point(519, 343);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 16;
            button4.Text = "Agregar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // txtIdPedido1
            // 
            txtIdPedido1.Location = new Point(517, 256);
            txtIdPedido1.Name = "txtIdPedido1";
            txtIdPedido1.Size = new Size(49, 23);
            txtIdPedido1.TabIndex = 17;
            txtIdPedido1.TextChanged += txtI_TextChanged;
            // 
            // txtIdPlato
            // 
            txtIdPlato.Location = new Point(584, 256);
            txtIdPlato.Name = "txtIdPlato";
            txtIdPlato.Size = new Size(37, 23);
            txtIdPlato.TabIndex = 18;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(651, 256);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(66, 23);
            txtEstado.TabIndex = 19;
            // 
            // txtIdCamarero
            // 
            txtIdCamarero.Location = new Point(517, 314);
            txtIdCamarero.Name = "txtIdCamarero";
            txtIdCamarero.Size = new Size(59, 23);
            txtIdCamarero.TabIndex = 20;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(606, 315);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(66, 23);
            txtCantidad.TabIndex = 21;
            // 
            // button5
            // 
            button5.Location = new Point(12, 374);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 22;
            button5.Text = "Atras";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(505, 63);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 23;
            label2.Text = "Id_ticket";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(588, 63);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 24;
            label3.Text = "Id_pedido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(505, 108);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 25;
            label4.Text = "Metodo Pago";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(606, 108);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 26;
            label5.Text = "Monto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(511, 238);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 27;
            label6.Text = "Id Pedido";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(584, 238);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 28;
            label7.Text = "Id Plato";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(651, 238);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 29;
            label8.Text = "Estado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(511, 296);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 30;
            label9.Text = "Id Camarero";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(606, 296);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 31;
            label10.Text = "Cantidad";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(42, 34);
            label11.Name = "label11";
            label11.Size = new Size(43, 15);
            label11.TabIndex = 32;
            label11.Text = "TICKET";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(723, 261);
            label12.Name = "label12";
            label12.Size = new Size(103, 15);
            label12.TabIndex = 33;
            label12.Text = "2 - En preparacion";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(723, 246);
            label13.Name = "label13";
            label13.Size = new Size(77, 15);
            label13.TabIndex = 34;
            label13.Text = "1 - Pendiente";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(723, 279);
            label14.Name = "label14";
            label14.Size = new Size(78, 15);
            label14.TabIndex = 35;
            label14.Text = "3 - Entregado";
            // 
            // Ticket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(844, 409);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(txtCantidad);
            Controls.Add(txtIdCamarero);
            Controls.Add(txtEstado);
            Controls.Add(txtIdPlato);
            Controls.Add(txtIdPedido1);
            Controls.Add(button4);
            Controls.Add(txtMonto);
            Controls.Add(txtMetodoPago);
            Controls.Add(dataGridView1);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(txtIdTicket);
            Controls.Add(txtIdPedido);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ticket";
            Text = "Ticket";
            Load += Ticket_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtIdTicket;
        private TextBox txtIdPedido;
        private Label label1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private TextBox txtMetodoPago;
        private TextBox txtMonto;
        private Button button4;
        private TextBox txtIdPedido1;
        private TextBox txtIdPlato;
        private TextBox txtEstado;
        private TextBox txtIdCamarero;
        private TextBox txtCantidad;
        private Button button5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}