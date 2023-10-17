
namespace ProyectoParcial_01pao.Formas
{
    partial class FormaVisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaVisor));
            this.buttonSalir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxpaisaje = new System.Windows.Forms.PictureBox();
            this.checkBoxajustar = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonborrar = new System.Windows.Forms.Button();
            this.buttoncolor = new System.Windows.Forms.Button();
            this.buttoncerrar = new System.Windows.Forms.Button();
            this.buttonmostrar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxpaisaje)).BeginInit();
            this.button1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(559, 353);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(109, 31);
            this.buttonSalir.TabIndex = 0;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxpaisaje, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxajustar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 373);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBoxpaisaje
            // 
            this.pictureBoxpaisaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBoxpaisaje, 2);
            this.pictureBoxpaisaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxpaisaje.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxpaisaje.Image")));
            this.pictureBoxpaisaje.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxpaisaje.Name = "pictureBoxpaisaje";
            this.pictureBoxpaisaje.Size = new System.Drawing.Size(561, 329);
            this.pictureBoxpaisaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxpaisaje.TabIndex = 0;
            this.pictureBoxpaisaje.TabStop = false;
            this.pictureBoxpaisaje.Click += new System.EventHandler(this.pictureBoxpaisaje_Click);
            // 
            // checkBoxajustar
            // 
            this.checkBoxajustar.AutoSize = true;
            this.checkBoxajustar.Location = new System.Drawing.Point(3, 338);
            this.checkBoxajustar.Name = "checkBoxajustar";
            this.checkBoxajustar.Size = new System.Drawing.Size(58, 17);
            this.checkBoxajustar.TabIndex = 2;
            this.checkBoxajustar.Text = "Ajustar\r\n";
            this.checkBoxajustar.UseVisualStyleBackColor = true;
            this.checkBoxajustar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Controls.Add(this.buttonborrar);
            this.button1.Controls.Add(this.buttoncolor);
            this.button1.Controls.Add(this.buttoncerrar);
            this.button1.Controls.Add(this.buttonmostrar);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(88, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(476, 32);
            this.button1.TabIndex = 3;
            // 
            // buttonborrar
            // 
            this.buttonborrar.Location = new System.Drawing.Point(3, 3);
            this.buttonborrar.Name = "buttonborrar";
            this.buttonborrar.Size = new System.Drawing.Size(97, 23);
            this.buttonborrar.TabIndex = 1;
            this.buttonborrar.Text = "Borrar imagen";
            this.buttonborrar.UseVisualStyleBackColor = true;
            this.buttonborrar.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // buttoncolor
            // 
            this.buttoncolor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoncolor.Location = new System.Drawing.Point(106, 3);
            this.buttoncolor.Name = "buttoncolor";
            this.buttoncolor.Size = new System.Drawing.Size(136, 23);
            this.buttoncolor.TabIndex = 2;
            this.buttoncolor.Text = "Establecer color de fondo";
            this.buttoncolor.UseVisualStyleBackColor = true;
            this.buttoncolor.Click += new System.EventHandler(this.backgroundButton_Click);
            // 
            // buttoncerrar
            // 
            this.buttoncerrar.Location = new System.Drawing.Point(248, 3);
            this.buttoncerrar.Name = "buttoncerrar";
            this.buttoncerrar.Size = new System.Drawing.Size(75, 23);
            this.buttoncerrar.TabIndex = 3;
            this.buttoncerrar.Text = "Cerrar";
            this.buttoncerrar.UseVisualStyleBackColor = true;
            this.buttoncerrar.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // buttonmostrar
            // 
            this.buttonmostrar.Location = new System.Drawing.Point(329, 3);
            this.buttonmostrar.Name = "buttonmostrar";
            this.buttonmostrar.Size = new System.Drawing.Size(139, 23);
            this.buttonmostrar.TabIndex = 0;
            this.buttonmostrar.Text = "Mostrar una imagen";
            this.buttonmostrar.UseVisualStyleBackColor = true;
            this.buttonmostrar.Click += new System.EventHandler(this.showButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(570, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(4, 100);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // FormaVisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(580, 373);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonSalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaVisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imagen";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxpaisaje)).EndInit();
            this.button1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxpaisaje;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox checkBoxajustar;
        private System.Windows.Forms.FlowLayoutPanel button1;
        private System.Windows.Forms.Button buttonborrar;
        private System.Windows.Forms.Button buttoncolor;
        private System.Windows.Forms.Button buttoncerrar;
        private System.Windows.Forms.Button buttonmostrar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}