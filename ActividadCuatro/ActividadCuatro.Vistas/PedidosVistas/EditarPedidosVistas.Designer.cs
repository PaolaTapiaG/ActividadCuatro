namespace ActividadCuatro.Vistas.PedidosVistas
{
    partial class EditarPedidosVistas
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
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 261);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(348, 27);
            textBox1.TabIndex = 81;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(36, 79);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(348, 27);
            dateTimePicker1.TabIndex = 80;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(36, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(348, 27);
            textBox2.TabIndex = 79;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 129);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 78;
            label4.Text = "TOTAL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 217);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 77;
            label3.Text = "ESTADO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 33);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 76;
            label2.Text = "FECHA";
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(276, 346);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 75;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(36, 346);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 74;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditarPedidosVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 450);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "EditarPedidosVistas";
            Text = "EditarPedidosVistas";
            Load += EditarPedidosVistas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
    }
}