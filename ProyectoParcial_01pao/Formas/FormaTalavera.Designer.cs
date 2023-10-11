
namespace ProyectoParcial_01pao.Formas
{
    partial class FormaTalavera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaTalavera));
            this.buttonSalir = new System.Windows.Forms.Button();
            this.labelincremento = new System.Windows.Forms.Label();
            this.labelsalario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttoncalsal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1sal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.LightCyan;
            this.buttonSalir.Location = new System.Drawing.Point(391, 306);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(108, 53);
            this.buttonSalir.TabIndex = 0;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelincremento
            // 
            this.labelincremento.AutoSize = true;
            this.labelincremento.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelincremento.Location = new System.Drawing.Point(170, 30);
            this.labelincremento.Name = "labelincremento";
            this.labelincremento.Size = new System.Drawing.Size(349, 29);
            this.labelincremento.TabIndex = 1;
            this.labelincremento.Text = "Incremento salarial del 25%";
            // 
            // labelsalario
            // 
            this.labelsalario.AutoSize = true;
            this.labelsalario.BackColor = System.Drawing.Color.Aqua;
            this.labelsalario.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsalario.Location = new System.Drawing.Point(37, 155);
            this.labelsalario.Name = "labelsalario";
            this.labelsalario.Size = new System.Drawing.Size(183, 26);
            this.labelsalario.TabIndex = 2;
            this.labelsalario.Text = "Salario Actual:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Con el 25%";
            // 
            // buttoncalsal
            // 
            this.buttoncalsal.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttoncalsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncalsal.Location = new System.Drawing.Point(156, 306);
            this.buttoncalsal.Name = "buttoncalsal";
            this.buttoncalsal.Size = new System.Drawing.Size(150, 53);
            this.buttoncalsal.TabIndex = 4;
            this.buttoncalsal.Text = "Calcular el sueldo con el 25%";
            this.buttoncalsal.UseVisualStyleBackColor = false;
            this.buttoncalsal.Click += new System.EventHandler(this.buttoncalsal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = ".";
            // 
            // textBox1sal
            // 
            this.textBox1sal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1sal.Location = new System.Drawing.Point(283, 155);
            this.textBox1sal.Name = "textBox1sal";
            this.textBox1sal.Size = new System.Drawing.Size(100, 29);
            this.textBox1sal.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(410, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(548, 264);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // FormaTalavera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(691, 428);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1sal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttoncalsal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelsalario);
            this.Controls.Add(this.labelincremento);
            this.Controls.Add(this.buttonSalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaTalavera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaTalavera";
            this.Load += new System.EventHandler(this.FormaTalavera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label labelincremento;
        private System.Windows.Forms.Label labelsalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttoncalsal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1sal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}