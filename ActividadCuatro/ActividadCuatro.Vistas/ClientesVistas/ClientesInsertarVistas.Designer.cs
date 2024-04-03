namespace ActividadCuatro.Vistas.ClientesVistas
{
    partial class ClientesInsertarVistas
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
            textBox2 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(409, 27);
            textBox2.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 68);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 55;
            label2.Text = "NOMBRES";
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(290, 545);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 53;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(139, 545);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 52;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(409, 27);
            textBox1.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 165);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 62;
            label1.Text = "APELLIDOS";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(50, 299);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(409, 27);
            textBox3.TabIndex = 65;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 256);
            label3.Name = "label3";
            label3.Size = new Size(165, 20);
            label3.TabIndex = 64;
            label3.Text = "CORREO ELECTRONICO";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(50, 389);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(409, 27);
            textBox4.TabIndex = 67;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 346);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 66;
            label4.Text = "TELEFONO";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(50, 475);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(409, 27);
            textBox5.TabIndex = 69;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 432);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 68;
            label5.Text = "DIRECCION ";
            // 
            // ClientesInsertarVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 612);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ClientesInsertarVistas";
            Text = "ClientesInsertarVistas";
            Load += ClientesInsertarVistas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private Label label2;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
    }
}