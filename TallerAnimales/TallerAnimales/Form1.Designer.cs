
namespace TallerAnimales
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
            this.comboBoxtipo = new System.Windows.Forms.ComboBox();
            this.listBoxAnimal = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDuenio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHabitad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxtipo
            // 
            this.comboBoxtipo.FormattingEnabled = true;
            this.comboBoxtipo.Location = new System.Drawing.Point(115, 254);
            this.comboBoxtipo.Name = "comboBoxtipo";
            this.comboBoxtipo.Size = new System.Drawing.Size(100, 23);
            this.comboBoxtipo.TabIndex = 0;
            this.comboBoxtipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxtipo_SelectedIndexChanged);
            this.comboBoxtipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxtipo_KeyPress);
            // 
            // listBoxAnimal
            // 
            this.listBoxAnimal.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxAnimal.FormattingEnabled = true;
            this.listBoxAnimal.ItemHeight = 15;
            this.listBoxAnimal.Location = new System.Drawing.Point(22, 34);
            this.listBoxAnimal.Name = "listBoxAnimal";
            this.listBoxAnimal.Size = new System.Drawing.Size(286, 154);
            this.listBoxAnimal.TabIndex = 1;
            this.listBoxAnimal.SelectedIndexChanged += new System.EventHandler(this.listBoxAnimal_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAgregar.Location = new System.Drawing.Point(353, 34);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumPurple;
            this.button2.Location = new System.Drawing.Point(353, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "quitar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(115, 224);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Agregar Animales";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumPurple;
            this.btnGuardar.Location = new System.Drawing.Point(253, 236);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dueño";
            // 
            // txtDuenio
            // 
            this.txtDuenio.Location = new System.Drawing.Point(115, 283);
            this.txtDuenio.Name = "txtDuenio";
            this.txtDuenio.Size = new System.Drawing.Size(100, 23);
            this.txtDuenio.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Habitad";
            // 
            // txtHabitad
            // 
            this.txtHabitad.Location = new System.Drawing.Point(115, 313);
            this.txtHabitad.Name = "txtHabitad";
            this.txtHabitad.Size = new System.Drawing.Size(100, 23);
            this.txtHabitad.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(468, 349);
            this.Controls.Add(this.txtHabitad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDuenio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listBoxAnimal);
            this.Controls.Add(this.comboBoxtipo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxtipo;
        private System.Windows.Forms.ListBox listBoxAnimal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDuenio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHabitad;
    }
}

