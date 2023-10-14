namespace Practica4._2
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
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            button3 = new Button();
            listBox2 = new ListBox();
            label1 = new Label();
            listBox3 = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(80, 31);
            button1.Name = "button1";
            button1.Size = new Size(247, 58);
            button1.TabIndex = 0;
            button1.Text = "Agregar Producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(488, 31);
            button2.Name = "button2";
            button2.Size = new Size(168, 51);
            button2.TabIndex = 1;
            button2.Text = "Mostrar productos ordenados";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(45, 108);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(315, 324);
            listBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(413, 404);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(552, 404);
            button3.Name = "button3";
            button3.Size = new Size(185, 28);
            button3.TabIndex = 4;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(413, 108);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(324, 244);
            listBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(436, 355);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 6;
            label1.Text = "Su total es de:";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(544, 355);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(89, 24);
            listBox3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 381);
            label2.Name = "label2";
            label2.Size = new Size(274, 20);
            label2.TabIndex = 8;
            label2.Text = "Ingrese la clave del producto a eliminar:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(listBox3);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private TextBox textBox1;
        private Button button3;
        private ListBox listBox2;
        private Label label1;
        private ListBox listBox3;
        private Label label2;
    }
}