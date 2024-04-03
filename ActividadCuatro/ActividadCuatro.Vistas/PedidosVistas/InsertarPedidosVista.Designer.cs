namespace ActividadCuatro.Vistas.PedidosVistas
{
    partial class InsertarPedidosVista
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
            textBox3 = new TextBox();
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(30, 318);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(348, 27);
            textBox3.TabIndex = 74;
            // 
            // button3
            // 
            button3.Location = new Point(407, 85);
            button3.Name = "button3";
            button3.Size = new Size(123, 29);
            button3.TabIndex = 73;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(30, 168);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(348, 27);
            dateTimePicker1.TabIndex = 72;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 232);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(348, 27);
            textBox2.TabIndex = 71;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(348, 27);
            textBox1.TabIndex = 70;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 209);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 69;
            label4.Text = "TOTAL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 274);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 68;
            label3.Text = "ESTADO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 134);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 67;
            label2.Text = "FECHA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 42);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 66;
            label1.Text = "ID CLIENTE";
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(279, 382);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 65;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(39, 382);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 64;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // InsertarPedidosVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 450);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "InsertarPedidosVista";
            Text = "InsertarPedidosVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Button button3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}